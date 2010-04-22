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
    public class S57AttributeDecode
    {
        //"Attribute","ValueDecode"
        public string Attribute { get; set; }
        public Dictionary<int, string> Values { get; set; }

        public static string CsvHeader = "\"Attribute\",\"ValueDecode\"";

        public S57AttributeDecode()
        {
            Values = new Dictionary<int, string>();
        }

        public static Dictionary<int, string> ParseValues(string valuePairs)
        {
            Dictionary<int, string> vals = new Dictionary<int, string>();
            int key = 0;
            int cnt = 0;
            foreach (string s in valuePairs.Split(';'))
            {
                if (cnt % 2 == 0)
                {
                    if (s != string.Empty) //this happens in case there is a semicolon at the end
                    {
                        key = Convert.ToInt32(s);   
                    }
                }
                else
                {
                    vals.Add(key, s);
                }
                cnt++;
            }
            return vals;
        }
    }
}
