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
using System.Drawing;
using System.Globalization;

using System.Text;
using Nohal.RleEditor.RleParser.Utils;

namespace Nohal.RleEditor.RleParser
{
    public class ColorRecord
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public CIEYxy Yxy { get; set; }

        public RGB Rgb
        {
            get
            {
                return ColorSpaceHelper.XYZtoRGB(ColorSpaceHelper.YxytoXYZ(Yxy));
            }
        }

        public ColorRecord(string code, string name, CIEYxy cieyxy)
        {
            Code = code;
            Name = name;
            Yxy = cieyxy;
        }

        public Color Color
        {
            get
            {
                if (Code == "TRANS")
                {
                    return System.Drawing.Color.Transparent;
                }
                return Color.FromArgb(255, Rgb.Red, Rgb.Green, Rgb.Blue);
            }
        }

        public static ColorRecord Black
        {
            get { return new ColorRecord("BLACK", "black", new CIEYxy(0.1, 0.1, 0.1)); }
        }

        public static ColorRecord White
        {
            get { return new ColorRecord("WHITE", "white", new CIEYxy(80, 0.2, 0.2)); }
        }

        public override string ToString()
        {
            return string.Format("CCIE{0}", RleParser.AddTermAndLength(string.Format(CultureInfo.InvariantCulture, "{0}{1:0.0000}{2}{3:0.0000}{4}{5:0.00}{6}{7}", Code, Yxy.x, RleParser.Term, Yxy.y, RleParser.Term, Yxy.Y, RleParser.Term, Name)));
        }
    }
}
