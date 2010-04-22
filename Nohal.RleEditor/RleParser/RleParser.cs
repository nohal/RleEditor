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
using System.Text;
using Nohal.RleEditor.RleParser.Utils;

namespace Nohal.RleEditor.RleParser
{
    public class RleParser
    {
        public const string PAPER_CHART = "PAPER_CHART";
        public const string SIMPLIFIED = "SIMPLIFIED";
        public const string LINES = "LINES";
        public const string PLAIN_BOUNDARIES = "PLAIN_BOUNDARIES";
        public const string SYMBOLIZED_BOUNDARIES = "SYMBOLIZED_BOUNDARIES";


        private List<string> datacomponents = new List<string>();
        private string remarks;

        public Dictionary<string, ColorTable> ColorTables { get; set; }
        public Dictionary<string, BitmapSymbol> SymbolBitmaps { get; set; }
        public Dictionary<string, BitmapPattern> PatternBitmaps { get; set; }
        public Dictionary<string, VectorSymbol> SymbolVectors { get; set; }
        public Dictionary<string, VectorLine> LineVectors { get; set; }
        public Dictionary<string, VectorPattern> PatternVectors { get; set; }
        public Dictionary<string, Dictionary<int, LookupTable>> LookupTables { get; set; }
        public const char Term = (char)0x1f;
        public const string Nil = "NIL";
        public int NextId = 0;

        public RleParser(string rleFilename)
        {
            ColorTables = new Dictionary<string, ColorTable>();
            SymbolBitmaps = new Dictionary<string, BitmapSymbol>();
            PatternBitmaps = new Dictionary<string, BitmapPattern>();
            SymbolVectors = new Dictionary<string, VectorSymbol>();
            LineVectors = new Dictionary<string, VectorLine>();
            PatternVectors = new Dictionary<string, VectorPattern>();
            LookupTables = new Dictionary<string, Dictionary<int, LookupTable>>();
            LookupTables.Add(PLAIN_BOUNDARIES, new Dictionary<int, LookupTable>());
            LookupTables.Add(SYMBOLIZED_BOUNDARIES, new Dictionary<int, LookupTable>());
            LookupTables.Add(LINES, new Dictionary<int, LookupTable>());
            LookupTables.Add(SIMPLIFIED, new Dictionary<int, LookupTable>());
            LookupTables.Add(PAPER_CHART, new Dictionary<int, LookupTable>());

            StringBuilder sb = new StringBuilder();
            StringBuilder sbremarks = new StringBuilder();
            StreamReader sr = new StreamReader(rleFilename);
            string line;
            int counter = 1;
            while ((line = sr.ReadLine()) != null)
            {
                if (!line.Trim().StartsWith(";") && line.Trim() != string.Empty)
                {
                    if (line.StartsWith("0001"))
                    {
                        sb.Length = 0;
                    }
                    sb.AppendLine(line);
                    if (line.StartsWith("****"))
                    {
                        datacomponents.Add(sb.ToString());
                        if (IsColorTable(sb.ToString()))
                        {
                            ColorTable ct = new ColorTable(sb.ToString());
                            ColorTables.Add(ct.Name, ct);
                        }
                        
                        if (IsBitmap(sb.ToString()))
                        {
                            MergeBitmaps(sb.ToString());
                        }

                        if (IsVector(sb.ToString()))
                        {
                            MergeVectors(sb.ToString());
                        }
                        if (IsPaperChart(sb.ToString()))
                        {
                            LookupTable bp = new LookupTable(sb.ToString());
                            try
                            {
                                LookupTables[PAPER_CHART].Add(bp.ObjectId, bp);
                            }
                            catch (Exception ex)
                            {
                                Debug.Print("Lookup table {0} ({1}) can't be loaded with following message: {2}, replacing with the later definition",
                                                              bp.ObjectId, bp.Code, ex.Message);
                                LookupTables[PAPER_CHART][bp.ObjectId] = bp;
                            }
                            if (bp.ObjectId >= NextId)
                            {
                                NextId = bp.ObjectId + 1;
                            }
                        }

                        if (IsSimplified(sb.ToString()))
                        {
                            LookupTable bp = new LookupTable(sb.ToString());
                            try
                            {
                                LookupTables[RleParser.SIMPLIFIED].Add(bp.ObjectId, bp);
                            }
                            catch (Exception ex)
                            {
                                Debug.Print("Lookup table {0} ({1}) can't be loaded with following message: {2}, replacing with the later definition",
                                                              bp.ObjectId, bp.Code, ex.Message);
                                LookupTables[RleParser.SIMPLIFIED][bp.ObjectId] = bp;
                            }
                            if (bp.ObjectId >= NextId)
                            {
                                NextId = bp.ObjectId + 1;
                            }
                        }

                        if (IsLines(sb.ToString()))
                        {
                            LookupTable bp = new LookupTable(sb.ToString());
                            try
                            {
                                LookupTables[LINES].Add(bp.ObjectId, bp);
                            }
                            catch (Exception ex)
                            {
                                Debug.Print(
                                    "Lookup table {0} ({1}) can't be loaded with following message: {2}, replacing with the later definition",
                                    bp.ObjectId, bp.Code, ex.Message);
                                LookupTables[LINES][bp.ObjectId] = bp;
                            }
                            if (bp.ObjectId >= NextId)
                            {
                                NextId = bp.ObjectId + 1;
                            }
                        }

                        if (IsPlainBoundaries(sb.ToString()))
                        {
                            LookupTable bp = new LookupTable(sb.ToString());
                            try
                            {
                                LookupTables[PLAIN_BOUNDARIES].Add(bp.ObjectId, bp);
                            }
                            catch (Exception ex)
                            {
                                Debug.Print(
                                    "Lookup table {0} ({1}) can't be loaded with following message: {2}, replacing with the later definition",
                                    bp.ObjectId, bp.Code, ex.Message);
                                LookupTables[PLAIN_BOUNDARIES][bp.ObjectId] = bp;
                            }
                            if (bp.ObjectId >= NextId)
                            {
                                NextId = bp.ObjectId + 1;
                            }
                        }

                        if (IsSymbolizedBoundaries(sb.ToString()))
                        {
                            LookupTable bp = new LookupTable(sb.ToString());
                            try
                            {
                                LookupTables[SYMBOLIZED_BOUNDARIES].Add(bp.ObjectId, bp);
                            }
                            catch (Exception ex)
                            {
                                Debug.Print(
                                    "Lookup table {0} ({1}) can't be loaded with following message: {2}, replacing with the later definition",
                                    bp.ObjectId, bp.Code, ex.Message);
                                LookupTables[SYMBOLIZED_BOUNDARIES][bp.ObjectId] = bp;
                            }
                            if (bp.ObjectId >= NextId)
                            {
                                NextId = bp.ObjectId + 1;
                            }
                        }
                        sb.Length = 0; //Just to make sure in the official file at least one '0001' was missing...
                    }
                }
                else
                {
                    sbremarks.AppendLine(String.Format("{0:00000;-0000}: {1}", counter, line));
                }
                counter++;
            }
            sr.Close();
            remarks = sbremarks.ToString();
        }

        public void MergeVectors(string vectorText)
        {
            foreach (string singleVector in vectorText.Split(new string[] { "00001" + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (IsVectorSymbol(singleVector))
                {
                    VectorSymbol vs = new VectorSymbol(singleVector, ColorTables["DAY_BRIGHT"]);
                        //TODO: not nice to assume this ColorTable
                    try
                    {
                        if (vs.IsValid())
                        {
                            SymbolVectors.Add(vs.Code, vs);
                        }
                        else
                        {
                            Debug.Print("Vector symbol {0} is not valid and can't be merged.", vs.Code);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(
                            "Vector symbol {0} can't be loaded with following message: {1}, assuming already exists and replacing",
                            vs.Code, ex.Message);
                        SymbolVectors[vs.Code] = vs;
                    }
                    if (vs.ObjectId >= NextId)
                    {
                        NextId = vs.ObjectId + 1;
                    }
                }

                if (IsVectorLine(singleVector))
                {
                    VectorLine vl = new VectorLine(singleVector, ColorTables["DAY_BRIGHT"]);
                        //TODO: not nice to assume this ColorTable
                    try
                    {
                        if (vl.IsValid())
                        {
                            LineVectors.Add(vl.Code, vl);
                        }
                        else
                        {
                            Debug.Print("Vector symbol {0} is not valid and can't be merged.", vl.Code);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(
                            "Vector {0} can't be loaded with following message: {1}, assuming already exists and replacing",
                            vl.Code, ex.Message);
                        LineVectors[vl.Code] = vl;
                    }
                    if (vl.ObjectId >= NextId)
                    {
                        NextId = vl.ObjectId + 1;
                    }
                }

                if (IsVectorPattern(singleVector))
                {
                    VectorPattern vp = new VectorPattern(singleVector, ColorTables["DAY_BRIGHT"]);
                        //TODO: not nice to assume this ColorTable
                    try
                    {
                        if (vp.IsValid())
                        {
                            PatternVectors.Add(vp.Code, vp);
                        }
                        else
                        {
                            Debug.Print("Bitmap symbol {0} is not valid and can't be merged.", vp.Code);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(
                            "Vector {0} can't be loaded with following message: {1}, assuming already exists and replacing",
                            vp.Code, ex.Message);
                        PatternVectors[vp.Code] = vp;
                    }
                    if (vp.ObjectId >= NextId)
                    {
                        NextId = vp.ObjectId + 1;
                    }
                }
            }
        }

        public void MergeBitmaps(string bitmapText)
        {
            foreach (string singleBitmap in bitmapText.Split(new string[] { "00001" + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (IsBitmapSymbol(singleBitmap))
                {
                    BitmapSymbol bs = new BitmapSymbol(singleBitmap, ColorTables["DAY_BRIGHT"]);
                        //TODO: not nice to assume this ColorTable
                    try
                    {
                        if (bs.IsValid())
                        {
                            SymbolBitmaps.Add(bs.Code, bs);
                        }
                        else
                        {
                            Debug.Print("Bitmap symbol {0} is not valid and can't be merged.", bs.Code);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(
                            "Bitmap symbol {0} can't be loaded with following message: '{1}', assuming already exists and replacing",
                            bs.Code, ex.Message);
                        SymbolBitmaps[bs.Code] = bs;
                    }
                    if (bs.ObjectId >= NextId)
                    {
                        NextId = bs.ObjectId + 1;
                    }
                }

                if (IsBitmapPattern(singleBitmap))
                {
                    BitmapPattern bp = new BitmapPattern(singleBitmap, ColorTables["DAY_BRIGHT"]);
                        //TODO: not nice to assume this ColorTable
                    try
                    {
                        if (bp.IsValid())
                        {
                            PatternBitmaps.Add(bp.Code, bp);
                        }
                        else
                        {
                            Debug.Print("Bitmap symbol {0} is not valid and can't be merged.", bp.Code);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(
                            "Bitmap symbol {0} can't be loaded with following message: '{1}', assuming already exists and replacing",
                            bp.Code, ex.Message);
                        PatternBitmaps[bp.Code] = bp;
                    }
                    if (bp.ObjectId >= NextId)
                    {
                        NextId = bp.ObjectId + 1;
                    }
                }
            }
        }

        private bool IsBitmap(string component)
        {
            return (component.Contains("SBTM") || component.Contains("PBTM"));
        }

        private bool IsBitmapSymbol(string component)
        {
            return component.Contains("SBTM");
        }

        private bool IsBitmapPattern(string component)
        {
            return component.Contains("PBTM");
        }

        private bool IsVector(string component)
        {
            return (component.Contains("LVCT") || component.Contains("PVCT") || component.Contains("SVCT"));
        }

        private bool IsVectorSymbol(string component)
        {
            return component.Contains("SVCT");
        }

        private bool IsVectorPattern(string component)
        {
            return component.Contains("PVCT");
        }

        private bool IsVectorLine(string component)
        {
            return component.Contains("LVCT");
        }

        private bool IsColorTable(string component)
        {
            return component.Contains("CCIE");
        }

        private bool IsLines(string component)
        {
            return component.Contains(LINES);
        }

        private bool IsPaperChart(string component)
        {
            return component.Contains(PAPER_CHART);
        }

        private bool IsSimplified(string component)
        {
            return component.Contains(SIMPLIFIED);
        }

        private bool IsPlainBoundaries(string component)
        {
            return component.Contains(PLAIN_BOUNDARIES);
        }

        private bool IsSymbolizedBoundaries(string component)
        {
            return component.Contains(SYMBOLIZED_BOUNDARIES);
        }

        public string GetBitmapsText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsBitmap(datacomponent))
                {
                    sb.Append(datacomponent);
                }
            }
            return sb.ToString();
        }

        public string GetVectorsText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsVector(datacomponent))
                {
                    sb.Append(datacomponent);
                }
            }
            return sb.ToString();
        }

        public string GetRemarks()
        {
            return remarks;
        }

        public static string StripLenFromString(string original)
        {
            if (original.Length < 11)
            {
                return original.Substring(1);
            }
            if (original.Length < 102)
            {
                return original.Substring(2);
            }
            if (original.Length < 1003)
            {
                return original.Substring(3);
            }
            throw new OverflowException(String.Format("Strings of length of {0} are not yet supported :(", original.Length));
        }

        public static string AddTermAndLength(string data)
        {
            return string.Format("{0,5}{1}{2}", data.Length + 1, data, Term);
        }

        public static string AddLength(string data)
        {
            return string.Format("{0,5}{1}", data.Length, data);
        }

        public string GetColorTablesText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsColorTable(datacomponent))
                {
                    sb.Append(datacomponent);
                }
            }
            return sb.ToString();
        }

        public string GetPointsPaperChartText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsPaperChart(datacomponent))
                {
                    LookupTable lu = new LookupTable(datacomponent);
                    sb.AppendLine(lu.ToLuptString());
                }
            }
            return sb.ToString();
        }

        public string GetPointsSimplifiedText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsSimplified(datacomponent))
                {
                    LookupTable lu = new LookupTable(datacomponent);
                    sb.AppendLine(lu.ToLuptString());
                }
            }
            return sb.ToString();
        }

        public string GetLinesText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsLines(datacomponent))
                {
                    LookupTable lu = new LookupTable(datacomponent);
                    sb.AppendLine(lu.ToLuptString());
                }
            }
            return sb.ToString();
        }

        public string GetAreaPlainBoundariesText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsPlainBoundaries(datacomponent))
                {
                    LookupTable lu = new LookupTable(datacomponent);
                    sb.AppendLine(lu.ToLuptString());
                }
            }
            return sb.ToString();
        }

        public string GetAreaSymbolizedBoundariesText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var datacomponent in datacomponents)
            {
                if (IsSymbolizedBoundaries(datacomponent))
                {
                    LookupTable lu = new LookupTable(datacomponent);
                    sb.AppendLine(lu.ToLuptString());
                }
            }
            return sb.ToString();
        }

        public void SaveRleToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Copy(fileName, fileName + ".bak", true);
            }
            TextWriter tw = new StreamWriter(fileName, false);

            foreach (var table in ColorTables.Values)
            {
                tw.WriteLine(table.ToString());
            }
            foreach (var lupts in LookupTables)
            {
                foreach (var lupt in lupts.Value)
                {
                    tw.WriteLine(lupt.Value.ToString());
                }
            }
            foreach (var vector in LineVectors.Values)
            {
                tw.WriteLine(vector.ToString());
            }
            foreach (var vector in PatternVectors.Values)
            {
                tw.WriteLine(vector.ToString());
            }
            foreach (var vector in SymbolVectors.Values)
            {
                tw.WriteLine(vector.ToString());
            }
            foreach (var bitmap in SymbolBitmaps.Values)
            {
                tw.WriteLine(bitmap.ToString());
            }
            foreach (var bitmap in PatternBitmaps.Values)
            {
                tw.WriteLine(bitmap.ToString());
            }
            tw.Close();
        }

        public void SaveBitmapsToFile(string fileName)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            StringBuilder sb = new StringBuilder();

            foreach (var bitmap in SymbolBitmaps.Values)
            {
                sb.AppendLine(bitmap.ToString());
            }
            foreach (var bitmap in PatternBitmaps.Values)
            {
                sb.AppendLine(bitmap.ToString());
            }
            tw.Write(sb.ToString());
            tw.Close();
        }

        public void SaveVectorsToFile(string fileName)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            StringBuilder sb = new StringBuilder();

            foreach (var vector in LineVectors.Values)
            {
                sb.AppendLine(vector.ToString());
            }
            foreach (var vector in PatternVectors.Values)
            {
                sb.AppendLine(vector.ToString());
            }
            foreach (var vector in SymbolVectors.Values)
            {
                sb.AppendLine(vector.ToString());
            }
            tw.Write(sb.ToString());
            tw.Close();
        }

        public void SaveTextToFile(string fileName, string txt)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            tw.Write(txt);
            tw.Close();
        }

        public void SaveSymbolToFile(string fileName, Symbol symbol)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            tw.Write(symbol.ToString());
            tw.Close();
        }

        public void SaveColorTableToFile(string fileName, ColorTable table)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            tw.WriteLine(table.ToString());
            tw.Close();
        }

        public void SaveColorTablesToFile(string fileName)
        {
            TextWriter tw = new StreamWriter(fileName, false);
            foreach (var ctab in ColorTables.Values)
            {
                tw.WriteLine(ctab.ToString());
            }
            tw.Close();
        }
    }
}
