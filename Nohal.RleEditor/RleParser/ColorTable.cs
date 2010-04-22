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
using System.Globalization;

using System.Text;
using Nohal.RleEditor.RleParser.Utils;

namespace Nohal.RleEditor.RleParser
{
    public class ColorTable : RleObject
    {
        public string Name { get; set; }
        public string COLS { get; set; }
        public new const string ObjectType = "CS";
        public Dictionary<string, ColorRecord> Colors { get; set; }

        public ColorTable(string palettedata)
        {
            Colors = new Dictionary<string, ColorRecord>();
            string[] lines = palettedata.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                if (line.StartsWith("COLS"))
                {
                    COLS = RleParser.StripLenFromString(line.Substring(4).Trim()).Trim(RleParser.Term); //TODO: what does it mean?
                    Name = line.Trim(RleParser.Term).Substring(line.LastIndexOf("NIL") + 3);
                    ObjectId = Convert.ToInt32(COLS.Substring(2, 5));
                }
                if (line.StartsWith("CCIE"))
                {
                    // Yxy -> XYZ conversion
                    double x = double.Parse(
                        RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(
                            5).Split(RleParser.Term)[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(line.Trim().Split(RleParser.Term)[1],
                                            CultureInfo.InvariantCulture);
                    double Y = double.Parse(line.Trim().Split(RleParser.Term)[2],
                                               CultureInfo.InvariantCulture);

                    CIEYxy color = new CIEYxy(Y, x, y);
                    Colors.Add(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(0, 5),
                               new ColorRecord(RleParser.StripLenFromString(line.Substring(4).Trim()).Substring(0, 5),
                                               line.Trim().Split(RleParser.Term)[3], color
                                   ));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ObjectHeader);
            //COLS   21CS00002NILDAY_BRIGHT
            sb.AppendLine(string.Format("COLS{0}", RleParser.AddTermAndLength(string.Format("{0}{1:00000;-0000}{2}{3}", ObjectType, ObjectId, RleParser.Nil, Name))));
            foreach (var color in Colors.Values)
            {
                sb.AppendLine(color.ToString());
            }
            sb.Append(ObjectFooter);
            return sb.ToString();
        }

        public override bool IsValid()
        {
            bool valid = true;
            //TODO - implement validation
            return valid;
        }
    }
}
