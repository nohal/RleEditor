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
    /// Structure to define HSB.
    /// </summary>
    public struct HSB
    {
        /// <summary>
        /// Gets an empty HSB structure;
        /// </summary>
        public static readonly HSB Empty = new HSB();

        #region Fields
        private double hue;
        private double saturation;
        private double brightness;
        #endregion

        #region Operators
        public static bool operator ==(HSB item1, HSB item2)
        {
            return (
                       item1.Hue == item2.Hue 
                       && item1.Saturation == item2.Saturation 
                       && item1.Brightness == item2.Brightness
                   );
        }

        public static bool operator !=(HSB item1, HSB item2)
        {
            return (
                       item1.Hue != item2.Hue 
                       || item1.Saturation != item2.Saturation 
                       || item1.Brightness != item2.Brightness
                   );
        }

        #endregion

        #region Accessors
        /// <summary>
        /// Gets or sets the hue component.
        /// </summary>
        [Description("Hue component"),]
        public double Hue 
        { 
            get
            {
                return hue;
            } 
            set
            { 
                hue = (value>360)? 360 : ((value<0)?0:value); 
            } 
        } 

        /// <summary>
        /// Gets or sets saturation component.
        /// </summary>
        [Description("Saturation component"),]
        public double Saturation 
        { 
            get
            {
                return saturation;
            } 
            set
            { 
                saturation = (value>1)? 1 : ((value<0)?0:value); 
            } 
        } 

        /// <summary>
        /// Gets or sets the brightness component.
        /// </summary>
        [Description("Brightness component"),]
        public double Brightness 
        { 
            get
            {
                return brightness;
            } 
            set
            { 
                brightness = (value>1)? 1 : ((value<0)? 0 : value); 
            } 
        } 
        #endregion

        /// <summary>
        /// Creates an instance of a HSB structure.
        /// </summary>
        /// <param name="h">Hue value.</param>
        /// <param name="s">Saturation value.</param>
        /// <param name="b">Brightness value.</param>
        public HSB(double h, double s, double b) 
        {
            hue = (h>360)? 360 : ((h<0)?0:h); 
            saturation = (s>1)? 1 : ((s<0)?0:s);
            brightness = (b>1)? 1 : ((b<0)?0:b);
        }

        #region Methods
        public override bool Equals(Object obj) 
        {
            if(obj==null || GetType()!=obj.GetType()) return false;

            return (this == (HSB)obj);
        }

        public override int GetHashCode() 
        {
            return Hue.GetHashCode() ^ Saturation.GetHashCode() ^ Brightness.GetHashCode();
        }

        #endregion
    }
}