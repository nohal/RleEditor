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
    //0001
    //PATT   10SY00001NIL
    //         |code   1|val2 |val3|val4|offx|offy|widt|heig|hotx|hoty
    //PATD   55FOULAR01RLINCON0000000000000050000500009000090000000000
    //PXPO   43area of depth less than the safety contour
    //PCRF    6ACHGRD
    //PBTM   10A@@@@@@@A
    //PBTM   10@A@@@@@A@
    //PBTM   10@@A@@@A@@
    //PBTM   10@@@A@A@@@
    //PBTM   10@@@@A@@@@
    //PBTM   10@@@A@A@@@
    //PBTM   10@@A@@@A@@
    //PBTM   10@A@@@@@A@
    //PBTM   10A@@@@@@@A
    //****
    public class BitmapPattern : Symbol
    {
        public string PATT { get; set; }
        public string PATD { get; set; }
        public string PXPO { get; set; }
        public string PCRF { get; set; }

        public string Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }

        public BitmapPattern(string bitmapdata, ColorTable colortable)
            : base()
        {
            this.ColorTable = colortable;
            string[] lines = bitmapdata.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                switch (line.Substring(0, 4))
                {
                    case "PATT":
                        PATT = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term); //TODO: what does it mean?
                        ObjectId = Convert.ToInt32(PATT.Substring(2, 5));
                        break;
                    case "PATD":
                        Code = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(0, 8);
                        SymbolType = RleParser.StripLenFromString(line.Substring(4).Trim())[8];
                        Value2 = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(9, 6);
                        Value3 = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(15, 5));
                        Value4 = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(20, 5));
                        OffsetX = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(25, 5));
                        OffsetY = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(30, 5));
                        Width = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(35, 5));
                        Height = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(40, 5));
                        HotspotX = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(45, 5));
                        HotspotY = Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(50).Trim(RleParser.Term)); //TODO: it looks shorter, should be 55 in total, but is just 54!
                        break;
                    case "PXPO":
                        Description = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                        break;
                    case "PCRF":
                        string pal = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                        Colors.Clear();
                        while (pal.Length > 0)
                        {
                            Colors.Add(pal[0], colortable.Colors[pal.Substring(1, 5)]);
                            pal = pal.Substring(6);
                        }
                        break;
                    case "PBTM":
                        AddLine(RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term));
                        break;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ObjectHeader);
            //PATT   10SY00095NIL
            sb.AppendLine(string.Format("PATT{0}", RleParser.AddLength(string.Format("{0}{1:00000;-0000}{2}", ObjectType, ObjectId, RleParser.Nil)))); 
            //PATD   55NODATA04RSTGCON0000300326000200000000048000240000000000
            sb.AppendLine(string.Format("PATD{0}", RleParser.AddLength(string.Format("{0}{1}{2}{3:00000;-0000}{4:00000;-0000}{5:00000;-0000}{6:00000;-0000}{7:00000;-0000}{8:00000;-0000}{9:00000;-0000}{10:00000;-0000}", Code, 'R', Value2, Value3, Value4, OffsetX, OffsetY, Width, Height, HotspotX, HotspotY))));
            //PXPO   22area of no chart data
            sb.AppendLine(string.Format("PXPO{0}", RleParser.AddTermAndLength(string.Format("{0}", Description)))); 
            //PCRF    6ACHGRD
            StringBuilder sb1 = new StringBuilder();
            foreach (var color in Colors)
            {
                sb1.Append(String.Format("{0}{1}", color.Key, color.Value.Code));
            }
            sb.AppendLine(String.Format("PCRF{0}", RleParser.AddLength(sb1.ToString())));
            //PBTM   49@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            foreach (var s in BitmapData.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
            {
                sb.AppendLine(String.Format("PBTM{0}", RleParser.AddTermAndLength(s)));
            }
            sb.Append(ObjectFooter);
            return sb.ToString();
        }

        public override bool IsValid()
        {
            bool valid = true;
            //TODO - implement more validation
            if (BitmapData.Length < 1) //Not enough...
            {
                valid = false;
            }
            if (this.Code.Length != 8)
            {
                valid = false;
            }
            if (this.Colors.Count < 1)
            {
                valid = false;
            }
            if (this.Height < 1 || this.Width < 1)
            {
                valid = false;
            }
            return valid;
        }

        public BitmapPattern Clone()
        {
            BitmapPattern bs = new BitmapPattern(this.ToString(), this.ColorTable);
            return bs;
        }
    }
}
