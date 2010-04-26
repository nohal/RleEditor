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

using System.Text;

namespace Nohal.RleEditor.RleParser
{
    using System.Diagnostics;

    public class VectorPattern : Symbol
    {
        public new const string ObjectType = "PT";

        public string PATT { get; set; }
        public string PATD { get; set; }
        public string PXPO { get; set; }
        public string PCRF { get; set; }

        public string Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }

        private bool _isvalid = true;

        public VectorPattern(string vectordata, ColorTable colortable)
            : base()
        {
            this.ColorTable = colortable;
            string[] lines = vectordata.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                try
                {
                    switch (line.Substring(0, 4))
                    {
                        case "PATT":
                            PATT = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                                //TODO: what does it mean? - means ID
                            ObjectId = Convert.ToInt32(PATT.Substring(2, 5));
                            break;
                        case "PATD":
                            Code = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(0, 8);
                            SymbolType = RleParser.StripLenFromString(line.Substring(4).Trim())[8];
                            Value2 = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(9, 6);
                            Value3 =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(15, 5));
                            Value4 =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(20, 5));
                            OffsetX =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(25, 5));
                            OffsetY =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(30, 5));
                            Width =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(35, 5));
                            Height =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(40, 5));
                            HotspotX =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(45, 5));
                            HotspotY =
                                Convert.ToInt32(
                                    RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(50).Trim(
                                        RleParser.Term));
                                //TODO: it looks shorter, should be 55 in total, but is just 54!
                            break;
                        case "PXPO":
                            Description = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                            break;
                        case "PCRF":
                            string pal = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                            while (pal.Length > 0)
                            {
                                try
                                {
                                    Colors.Add(pal[0], colortable.Colors[pal.Substring(1, 5)]);
                                }
                                catch (Exception e)
                                {
                                    Debug.Print(
                                        "Symbol {0}. The requested color {1} doesn't exist in the palette.",
                                        this.Code,
                                        pal.Substring(1, 5));
                                }
                                pal = pal.Substring(6);
                            }
                            break;
                        case "PVCT":
                            AddLine(RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print("Error while parsing object: {0}", vectordata);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ObjectHeader);
            sb.AppendLine(string.Format("PATT{0}", RleParser.AddLength(string.Format("{0}{1:00000;-0000}{2}", ObjectType, ObjectId, RleParser.Nil)))); 
            sb.AppendLine(string.Format("PATD{0}", RleParser.AddLength(string.Format("{0}{1}{2}{3:00000;-0000}{4:00000;-0000}{5:00000;-0000}{6:00000;-0000}{7:00000;-0000}{8:00000;-0000}{9:00000;-0000}{10:00000;-0000}", Code, SymbolType, Value2, Value3, Value4, OffsetX, OffsetY, Width, Height, HotspotX, HotspotY)))); 
            sb.AppendLine(string.Format("PXPO{0}", RleParser.AddTermAndLength(string.Format("{0}", Description)))); 
            StringBuilder sb1 = new StringBuilder();
            foreach (var color in Colors)
            {
                sb1.Append(String.Format("{0}{1}", color.Key, color.Value.Code));
            }
            sb.AppendLine(String.Format("PCRF{0}", RleParser.AddLength(sb1.ToString())));
            foreach (var s in BitmapData.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                sb.AppendLine(String.Format("PVCT{0}", RleParser.AddLength(s)));
            }
            sb.Append(ObjectFooter);
            return sb.ToString();
        }

        public override bool IsValid()
        {
            //TODO - implement more validation
            if (BitmapData.Length < 1) //Not enough...
            {
                _isvalid = false;
            }
            if (this.Code.Length != 8)
            {
                _isvalid = false;
            }
            if (this.Colors.Count < 1)
            {
                _isvalid = false;
            }
            if (this.Height < 0 || this.Width < 0) //lines have width or height = 0, it's weird...
            {
                _isvalid = false;
            }
            return _isvalid;
        }

        public VectorPattern Clone()
        {
            VectorPattern vs = new VectorPattern(this.ToString(), this.ColorTable);
            return vs;
        }
    }
}
