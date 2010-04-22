#region License Details
// --------------------------------------------------------------------------------------------
// This file is part of RleEditor.
// 
//     RleEditor is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     RleEditor is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with RleEditor.  If not, see <http://www.gnu.org/licenses/>.
// --------------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using LumenWorks.Framework.IO.Csv;

namespace Nohal.RleEditor.RleParser
{
    public class S57Data
    {
        public Dictionary<string, S57ObjectClass> ObjectClasses { get; set; }
        public Dictionary<string, S57Attribute> Attributes { get; set; }
        private readonly SortedDictionary<int, S57Attribute> _attrs;
        private readonly SortedDictionary<int, S57ObjectClass> _classes;

        public S57Data(string classesFile, string attributesFile, string decodingsFile, string expectedInputFile)
        {
            _attrs = new SortedDictionary<int, S57Attribute>();
            _classes = new SortedDictionary<int, S57ObjectClass>();
            ObjectClasses = new Dictionary<string, S57ObjectClass>();
            Attributes = new Dictionary<string, S57Attribute>();
            CsvReader csvu = new CsvReader(new StreamReader(classesFile), true, ',');
            while (csvu.ReadNextRecord())
            {
                S57ObjectClass cls = new S57ObjectClass
                                         {
                                             Code = Convert.ToInt32(csvu["Code"]),
                                             ObjectClass = csvu["ObjectClass"],
                                             Acronym = csvu["Acronym"],
                                             AttributeA = csvu["Attribute_A"],
                                             AttributeB = csvu["Attribute_B"],
                                             AttributeC = csvu["Attribute_C"],
                                             Class = csvu["Class"],
                                             Primitives = csvu["Primitives"]
                                         };
                ObjectClasses.Add(cls.Acronym, cls);
                _classes.Add(cls.Code, cls);
            }
            csvu.Dispose();

            csvu = new CsvReader(new StreamReader(attributesFile), true, ',');
            while (csvu.ReadNextRecord())
            {
                S57Attribute attr = new S57Attribute()
                {
                    Code = Convert.ToInt32(csvu["Code"]),
                    Acronym = csvu["Acronym"],
                    Class = csvu["Class"],
                    Attribute = csvu["Attribute"],
                    AttributeType = csvu["AttributeType"]
                };
                Attributes.Add(attr.Acronym, attr);
                _attrs.Add(attr.Code, attr);
            }
            csvu.Dispose();

            //warning: there are errors in the distributed attdecode.csv (, instead of ; etc...), duplicates (CATBUA, CATGAT, CATMOR etc.), so the file has to be manually repaired to be CSV before use
            csvu = new CsvReader(new StreamReader(decodingsFile), true, ',', '"', '\\', '#', true);
            while (csvu.ReadNextRecord())
            {
                S57AttributeDecode attrd = new S57AttributeDecode()
                                              {
                                                  Attribute = csvu["Attribute"],
                                                  Values = S57AttributeDecode.ParseValues(csvu["ValueDecode"])
                                              };
                foreach (KeyValuePair<int, string> pair in attrd.Values)
                {
                    try
                    {
                        Attributes[attrd.Attribute].AttrDecode.Add(pair.Key, pair.Value);    
                    }
                    catch (Exception)
                    {
                        Debug.Print("Value {0} ({1}) for attribute {2} already exists.", pair.Key, pair.Value,
                                    attrd.Attribute);
                    }
                }
            }
            csvu.Dispose();

            csvu = new CsvReader(new StreamReader(expectedInputFile), true, ',', '"', '\\', '#', true);
            while (csvu.ReadNextRecord())
            {
                S57ExpectedInput expi = new S57ExpectedInput()
                {
                    Code = Convert.ToInt32(csvu["Code"]),
                    Id = Convert.ToInt32(csvu["Id"]),
                    Meaning = csvu["Meaning"]
                };
                try
                {
                    _attrs[expi.Code].ExpectedInput.Add(expi.Id, expi.Meaning);
                }
                catch (Exception)
                {
                    Debug.Print("Unable to load expected input {0},{1},{2}", expi.Code, expi.Id, expi.Meaning);
                }
            }
            csvu.Dispose();
        }

        public void Save(string classesFile, string attributesFile, string decodingsFile, string expectedInputFile)
        {
            StreamWriter tw;
            tw = new StreamWriter(classesFile);
            tw.WriteLine(S57ObjectClass.CsvHeader);
            foreach (S57ObjectClass cls in _classes.Values)
            {
                tw.WriteLine(cls.CsvLine);
            }
            tw.Close();

            StringBuilder sbDecodes = new StringBuilder(S57AttributeDecode.CsvHeader);
            StringBuilder sbExpectedInputs = new StringBuilder(S57ExpectedInput.CsvHeader);
            sbExpectedInputs.AppendLine();
            sbDecodes.AppendLine();
            tw = new StreamWriter(attributesFile);
            tw.WriteLine(S57Attribute.CsvHeader);
            foreach (S57Attribute attr in _attrs.Values)
            {
                tw.WriteLine(attr.CsvLine);
                if (attr.CsvAttributeDecode.Length > 6)
                {
                    sbDecodes.AppendLine(attr.CsvAttributeDecode);   
                }
                if (attr.CsvExpectedInput.Length > 0)
                {
                    sbExpectedInputs.Append(attr.CsvExpectedInput);   
                }
            }
            tw.Close();

            tw = new StreamWriter(decodingsFile);
            tw.Write(sbDecodes.ToString());
            tw.Close();

            tw = new StreamWriter(expectedInputFile);
            tw.Write(sbExpectedInputs.ToString());
            tw.Close();
        }

        /// <summary>
        /// Merges non-existing data from another set
        /// </summary>
        /// <param name="dataToMerge"></param>
        public void Merge(S57Data dataToMerge)
        {
            foreach (KeyValuePair<string, S57ObjectClass> pair in dataToMerge.ObjectClasses)
            {
                if (!ObjectClasses.Keys.Contains(pair.Key))
                {
                    ObjectClasses.Add(pair.Key, pair.Value);
                    _classes.Add(pair.Value.Code, pair.Value);
                }
            }

            foreach (KeyValuePair<string, S57Attribute> pair in dataToMerge.Attributes)
            {
                if (!Attributes.Keys.Contains(pair.Key))
                {
                    Attributes.Add(pair.Key, pair.Value);
                    _attrs.Add(pair.Value.Code, pair.Value);
                }
                else
                {
                    foreach (KeyValuePair<int, string> decode in pair.Value.AttrDecode)
                    {
                        if (!Attributes[pair.Key].AttrDecode.Keys.Contains(decode.Key))
                        {
                            Attributes[pair.Key].AttrDecode.Add(decode.Key, decode.Value);
                        }
                    }
                    foreach (KeyValuePair<int, string> expectedInput in pair.Value.ExpectedInput)
                    {
                        if (!Attributes[pair.Key].ExpectedInput.Keys.Contains(expectedInput.Key))
                        {
                            Attributes[pair.Key].ExpectedInput.Add(expectedInput.Key, expectedInput.Value);
                        }
                    }
                }
            }
        }
    }
}
