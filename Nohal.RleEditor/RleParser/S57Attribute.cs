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
using System.Linq;
using System.Text;

namespace Nohal.RleEditor.RleParser
{
    /// <summary>
    /// From s57attributes.csv
    /// </summary>
    public class S57Attribute
    {
        public int Code { get; set; }
        public string Attribute { get; set; }
        public string Acronym { get; set; }
        public string AttributeType { get; set; }
        public string Class { get; set; }
        /// <summary>
        /// From attdecode.csv
        /// </summary>
        public Dictionary<int, string> AttrDecode { get; set; }
        /// <summary>
        /// from s57expectedinput.csv
        /// </summary>
        public Dictionary<int, string> ExpectedInput { get; set; }

        public static string CsvHeader = "\"Code\",\"Attribute\",\"Acronym\",\"Attributetype\",\"Class\"";

        public string CsvLine
        {
            get
            {
                return String.Format("{0},{1},{2},{3},{4}", Code, Attribute, Acronym, AttributeType, Class);
            }
        }

        public string CsvExpectedInput
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<int, string> pair in ExpectedInput)
                {
                    sb.AppendLine(string.Format("{0},{1},\"{2}\"", Code, pair.Key, pair.Value));
                }
                return sb.ToString();
            }
        }

        public string CsvAttributeDecode
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(String.Format("{0},", Acronym));
                foreach (KeyValuePair<int, string> pair in AttrDecode)
                {
                    sb.Append(string.Format("{0};{1};", pair.Key, pair.Value));
                }
                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
        }

        public S57Attribute()
        {
            AttrDecode = new Dictionary<int, string>();
            ExpectedInput = new Dictionary<int, string>();
        }
    }
}
