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
using System.Globalization;
using Nohal.RleEditor.RleParser.Utils;

using System.Text;

namespace Nohal.RleEditor.RleParser
{
    //* Each line contains minimum 6 fields:
    //* 1. field - code of the object class
    //* 2. field - attribute combination
    //* 3. field - symbolization instruction
    //* 4. field - display priority
    //* 5. field - radar
    //* 6. field - IMO display category
    //* 7. field - viewing group (optional)
    //*
    //* Each field entry is framed by '"' and fields are separated by ','.
    //"CANALS","","LS(SOLD,1,CHBLK)","2","O","DISPLAYBASE","12420"
    public class LookupTable : RleObject, IComparable
    {
        private readonly List<string> _displayCategories = new List<string> { "STANDARD", "OTHER", "DISPLAYBASE", "MARINERS OTHER", "MARINERS STANDARD" };
        private readonly List<string> _radars = new List<string> { "O", "S" };

        public string LUPT { get; set; }
        public string ATTC { get; set; }
        public string INST { get; set; }
        public string DISC { get; set; }
        public string LUCM { get; set; }

        public string Code { get; set; }
        public string Symbolization { get; set; }
        public string AttributeCombination { get; set; }
        public string SymbolizationInstructions { get; set; }
        public string DisplayPriority { get; set; }
        public string Radar { get; set; }
        public string ImoDisplayCategory { get; set; }
        public string ViewingGroup { get; set; }
        public new const string ObjectType = "LU";
        public string SymbolizationLetter
        {
            get
            {
                return SymbolizationToSymbolizationLetter(Symbolization);
            }
        }

        private static string SymbolizationToSymbolizationLetter(string symbolization)
        {
            switch (symbolization)
            {
                case RleParser.PAPER_CHART:
                    return "P";
                case RleParser.SIMPLIFIED:
                    return "P";
                case RleParser.LINES:
                    return "L";
                case RleParser.SYMBOLIZED_BOUNDARIES:
                    return "A";
                case RleParser.PLAIN_BOUNDARIES:
                    return "A";
                default:
                    return String.Empty;
            }
        }

        public LookupTable Clone()
        {
            LookupTable lt = new LookupTable(this.ToString());
            lt.AttributeCombination = AttributeCombination;
            return lt;
        }

        public string ToLuptString()
        {
            return String.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"", Code, AttributeCombination,
                                 SymbolizationInstructions, DisplayPriority, Radar, ImoDisplayCategory, ViewingGroup);
        }

        //"convyr","CATCON2|CONRAD1|","LS(SOLD,3,CHGRD);SY(RACNSP01);TE('clr %4.1lf','VERCLR',3,1,2,'15110',1,0,CHBLK,11)","8","O","DISPLAYBASE","12210"
        //0 - "convyr",
        //1 - "CATCON2|CONRAD1|",
        //2 - "LS(SOLD,3,CHGRD);SY(RACNSP01);TE('clr %4.1lf','VERCLR',3,1,2,'15110',1,0,CHBLK,11)",
        //3 - "8",
        //4 - "O",
        //5 - "DISPLAYBASE",
        //6 - "12210"
        //-----------------------
        //0001    500540
        //LUPT   29LU00540NILCOALNEL00007OLINES
        //ATTC    1
        //INST   13CS(QUAPOS01)
        //DISC   12DISPLAYBASE
        //LUCM    612410
        //****    0
        public static string LuptStringToRle(string ltline, int objectId, string symbolization)
        {
            try
            {
                //29LU00540NILCOALNEL00007OLINES
                string LUPT = "LU{0}NIL{1}{2}{3}{4}{5}";
                string[] components = ltline.Replace("\",\"", "~").Replace("\"", string.Empty).Split('~');
                StringBuilder retstr = new StringBuilder();
                retstr.AppendLine(ObjectHeader);
                //LUPT
                int x;
                Int32.TryParse(components[3], out x);

                string lupt = String.Format(LUPT, objectId.ToString("00000;-0000"), components[0], SymbolizationToSymbolizationLetter(symbolization),
                                            x.ToString("00000;-0000"), components[4],
                                            symbolization);
                retstr.Append("LUPT   ").Append(lupt.Length).AppendLine(lupt);
                //ATTC    1
                string attc;
                if (components[1].Length > 1 && !components[1].Contains("|")) //ENC tables from th PDF don't contain the attribute separators so we have to "invent them"
                {
                    string attrstr = components[1];
                    StringBuilder sb = new StringBuilder();
                    while (attrstr.Length > 0)
                    {
                        sb.Append(attrstr.Substring(0, 6));
                        attrstr = attrstr.Substring(6);
                        while (attrstr.Length > 0 && !Char.IsLetter(attrstr[0]))
                        {
                            sb.Append(attrstr[0]);
                            attrstr = attrstr.Substring(1);
                        }
                        sb.Append(RleParser.Term);
                    }
                    attc = sb.ToString();
                }
                else
                {
                    attc = components[1].Replace('|', RleParser.Term);
                }
                if (attc.Length == 0)
                    attc = RleParser.Term.ToString();
                retstr.AppendLine(String.Format("ATTC{0}", RleParser.AddLength(attc)));
                //INST
                retstr.AppendLine(String.Format("INST{0}", RleParser.AddTermAndLength(components[2])));
                //DISC
                retstr.AppendLine(String.Format("DISC{0}", RleParser.AddTermAndLength(components[5])));
                //LUCM
                retstr.AppendLine(String.Format("LUCM{0}", RleParser.AddTermAndLength(components[6])));
                retstr.Append(ObjectFooter);
                return retstr.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return LuptStringToRle(this.ToLuptString(), this.ObjectId, Symbolization);
        }

        public override bool IsValid()
        {
            bool valid = true;
            
            if (this.Code.Length != 6)
            {
                valid = false;
            }
            if (AttributeCombination.Length > 0)
            {
                if (!AttributeCombination.EndsWith("|"))
                {
                    valid = false;
                }
            }
            if (Radar.Length != 1 || !_radars.Contains(Radar))
            {
                valid = false;
            }
            if (Convert.ToInt32(DisplayPriority) < 0 || Convert.ToInt32(DisplayPriority) > 9)
            {
                valid = false;
            }
            if (!_displayCategories.Contains(this.ImoDisplayCategory))
            {
                valid = false;
            }
            if (ViewingGroup.Length > 0 && (!ViewingGroup.IsNumeric(NumberStyles.Integer) || Convert.ToInt32(ViewingGroup) < 0))
            {
                valid = false;
            }

            return valid;
        }

        public LookupTable(string objecttext, int nr, string symbolization)
        {
            this.ObjectId = nr;
            this.Symbolization = symbolization;
            string component = LuptStringToRle(objecttext, 0, this.Symbolization);
            FillObjectFromText(component);
        }

        public LookupTable(string objecttext)
        {
            FillObjectFromText(objecttext);
        }

        private void FillObjectFromText(string objecttext)
        {
            string[] lines = objecttext.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                switch (line.Substring(0, 4))
                {
                    case "0001":
                        break;
                    case "####":
                        break;
                    case "LUPT":
                        LUPT = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term); //TODO: what does it mean?
                        ObjectId = Convert.ToInt32(LUPT.Substring(2, 5));
                        Code = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(10, 6);
                        //replaced by smarter property - SymbolizationLetter = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(16, 1);
                        DisplayPriority = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(21, 1);
                        if (line.Length > 31)
                        {
                            Radar = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(22, 1);
                        }
                        if (line.Length > 32)
                        {
                            Symbolization =
                                RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(23).Trim(RleParser.Term);
                        }
                        break;
                    case "ATTC":
                        AttributeCombination = RleParser.StripLenFromString(line.Substring(4).Trim()).Replace(RleParser.Term, '|');
                        if (AttributeCombination == "|")
                        {
                            AttributeCombination = string.Empty;
                        }
                        break;
                    case "INST":
                        SymbolizationInstructions = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                        break;
                    case "DISC":
                        ImoDisplayCategory = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                        break;
                    case "LUCM":
                        ViewingGroup = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                        break;
                    default:
                        //Debug.WriteLine(line);
                        break;
                }
            }
        }

        private string ReplaceLeadingSpecialChars(string code)
        {
            if (code != null)
            {
                StringBuilder cod = new StringBuilder(code);
                if (cod[0] == '$')
                {
                    cod[0] = '{';
                }
                if (cod[0] == '_')
                {
                    cod[0] = '}';
                }
                return cod.ToString();
            }
            return null;
        }

        public int CompareTo(object t2)
        {
            string code1 = ReplaceLeadingSpecialChars(this.Code);
            string code2 = ReplaceLeadingSpecialChars(((LookupTable)t2).Code);
            if (code1 == code2 && this.AttributeCombination == ((LookupTable)t2).AttributeCombination)
            {
                return 0;
            }
            if (string.CompareOrdinal(code1, code2) < 0)
            {
                return -1;
            }
            if (string.CompareOrdinal(code1, code2) > 0)
            {
                return 1;
            }
            // now the Codes are for sure the same and AttributeCombinations different
            if (this.AttributeCombination.Length > ((LookupTable)t2).AttributeCombination.Length)
            {
                return -1;
            }
            if (this.AttributeCombination.Length == ((LookupTable)t2).AttributeCombination.Length && string.CompareOrdinal(this.Code, ((LookupTable)t2).Code) == 0 && (string.CompareOrdinal(this.AttributeCombination, ((LookupTable)t2).AttributeCombination) < 0))
            {
                return -1;
            }
            return 1;
        }
    }
}
