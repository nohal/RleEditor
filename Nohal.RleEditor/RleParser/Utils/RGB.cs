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
using System.ComponentModel;

namespace Nohal.RleEditor.RleParser.Utils
{
    /// <summary>
    /// Structure to define RGB.
    /// </summary>
    public struct RGB
    {
        /// <summary>
        /// Gets an empty RGB structure;
        /// </summary>
        public static readonly RGB Empty = new RGB();

        #region Fields
        private int red;
        private int green;
        private int blue;

        #endregion

        #region Operators
        public static bool operator ==(RGB item1, RGB item2)
        {
            return (
                       item1.Red == item2.Red 
                       && item1.Green == item2.Green 
                       && item1.Blue == item2.Blue
                   );
        }

        public static bool operator !=(RGB item1, RGB item2)
        {
            return (
                       item1.Red != item2.Red 
                       || item1.Green != item2.Green 
                       || item1.Blue != item2.Blue
                   );
        }

        #endregion

        #region Accessors
        [Description("Red component."),]
        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                red = (value>255)? 255 : ((value<0)?0 : value);
            }
        }

        [Description("Green component."),]
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                green = (value>255)? 255 : ((value<0)?0 : value);
            }
        }

        [Description("Blue component."),]
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = (value>255)? 255 : ((value<0)?0 : value);
            }
        }
        #endregion

        public RGB(int R, int G, int B) 
        {
            red = (R>255)? 255 : ((R<0)?0 : R);
            green = (G>255)? 255 : ((G<0)?0 : G);
            blue = (B>255)? 255 : ((B<0)?0 : B);
        }

        #region Methods
        public override bool Equals(Object obj) 
        {
            if(obj==null || GetType()!=obj.GetType()) return false;

            return (this == (RGB)obj);
        }

        public override int GetHashCode() 
        {
            return Red.GetHashCode() ^ Green.GetHashCode() ^ Blue.GetHashCode();
        }

        #endregion
    }
}