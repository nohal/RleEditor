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
    public class S57ObjectClass
    {
        public int Code { get; set;}
        public string ObjectClass { get; set;}
        public string Acronym { get; set;}
        public string AttributeA { get; set;}
        public string AttributeB { get; set;}
        public string AttributeC { get; set;}
        public string Class { get; set;}
        public string Primitives { get; set; }

        public static string CsvHeader = "\"Code\",\"ObjectClass\",\"Acronym\",\"Attribute_A\",\"Attribute_B\",\"Attribute_C\",\"Class\",\"Primitives\"";

        public string CsvLine
        {
            get
            {
                return String.Format("{0},\"{1}\",{2},{3},{4},{5},{6},{7}", Code, ObjectClass, Acronym, AttributeA, AttributeB, AttributeC, Class, Primitives);
            }
        }
    }
}
