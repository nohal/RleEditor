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

    //0001    501656
    //SYMB   10SY03216NIL
    //SYMD   39AISONE01V073710161500405001710717401445
    //SXPO   31one minute mark for AIS vector
    //SCRF    6AARPAT
    //SVCT   57SPA;SW1;PU7174,1616;PD7579,1616;PD7372,1445;PD7174,1616;
    public class VectorSymbol : Symbol
    {
        public new const string ObjectType = "SY";

        public string SYMB { get; set; }
        public string SYMD { get; set; }
        public string SXPO { get; set; }
        public string SCRF { get; set; }

        private bool _isvalid = true;

        public VectorSymbol(string vectordata, ColorTable colortable) : base()
        {
            this.ColorTable = colortable;
            string[] lines = vectordata.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                try
                {
                    switch (line.Substring(0, 4))
                    {
                        case "SYMB":
                            SYMB = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                                //TODO: what does it mean? - means ID
                            ObjectId = Convert.ToInt32(SYMB.Substring(2, 5));
                            break;
                        case "SYMD":
                            Code = RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(0, 8);
                            SymbolType = RleParser.StripLenFromString(line.Substring(4).Trim())[8];
                            OffsetX =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(9, 5));
                            OffsetY =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(14, 5));
                            Width =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(19, 5));
                            Height =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(24, 5));
                            HotspotX =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(29, 5));
                            HotspotY =
                                Convert.ToInt32(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(34, 5));
                            break;
                        case "SXPO":
                            Description = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                            break;
                        case "SCRF":
                            string pal = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term);
                            while (pal.Length > 0)
                            {
                                try
                                {
                                    Colors.Add(pal[0], colortable.Colors[pal.Substring(1, 5)]);
                                }
                                catch (Exception e)
                                {
                                    _isvalid = false;
                                    Debug.Print(
                                        "Symbol {0}. The requested color {1} doesn't exist in the palette.",
                                        this.Code,
                                        pal.Substring(1, 5));
                                }

                                pal = pal.Substring(6);
                            }
                            break;
                        case "SVCT":
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
            //SYMB   10SY00095NIL
            sb.AppendLine(string.Format("SYMB{0}", RleParser.AddLength(string.Format("{0}{1:00000;-0000}{2}", ObjectType, ObjectId, RleParser.Nil))));
            //SYMD   39NMKREG12R000150001500031000310000000000
            sb.AppendLine(string.Format("SYMD{0}", RleParser.AddLength(string.Format("{0}{1}{2:00000;-0000}{3:00000;-0000}{4:00000;-0000}{5:00000;-0000}{6:00000;-0000}{7:00000;-0000}", Code, SymbolType, OffsetX, OffsetY, Width, Height, HotspotX, HotspotY)))); 
            //SXPO   32notice mark, special attention
            sb.AppendLine(string.Format("SXPO{0}", RleParser.AddTermAndLength(string.Format("{0}", Description))));
            //SCRF   18ACHBLKBCHREDCCHWHT
            StringBuilder sb1 = new StringBuilder();
            foreach (var color in Colors)
            {
                sb1.Append(String.Format("{0}{1}", color.Key, color.Value.Code));
            }
            sb.AppendLine(String.Format("SCRF{0}", RleParser.AddLength(sb1.ToString())));
            //SVCT   32AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            foreach (var s in BitmapData.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                sb.AppendLine(String.Format("SVCT{0}", RleParser.AddLength(s)));
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
            if (this.Height < 1 || this.Width < 1)
            {
                _isvalid = false;
            }
            return _isvalid;
        }

        public VectorSymbol Clone()
        {
            VectorSymbol vs = new VectorSymbol(this.ToString(), this.ColorTable);
            return vs;
        }
    }
}
