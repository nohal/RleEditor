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

namespace Nohal.RleEditor.RleParser.Utils
{
    /// <summary>
    /// Structure to define CMYK.
    /// </summary>
    public struct CMYK 
    {
        /// <summary>
        /// Gets an empty CMYK structure;
        /// </summary>
        public readonly static CMYK Empty = new CMYK();

        #region Fields
        private double c; 
        private double m; 
        private double y; 
        private double k;
        #endregion

        #region Operators
        public static bool operator ==(CMYK item1, CMYK item2)
        {
            return (
                       item1.Cyan == item2.Cyan 
                       && item1.Magenta == item2.Magenta 
                       && item1.Yellow == item2.Yellow
                       && item1.Black == item2.Black
                   );
        }

        public static bool operator !=(CMYK item1, CMYK item2)
        {
            return (
                       item1.Cyan != item2.Cyan 
                       || item1.Magenta != item2.Magenta 
                       || item1.Yellow != item2.Yellow
                       || item1.Black != item2.Black
                   );
        }


        #endregion

        #region Accessors
        public double Cyan
        { 
            get
            {
                return c;
            } 
            set
            { 
                c = value; 
                c = (c>1)? 1 : ((c<0)? 0 : c); 
            } 
        } 

        public double Magenta
        { 
            get
            {
                return m;
            } 
            set
            { 
                m = value; 
                m = (m>1)? 1 : ((m<0)? 0 : m); 
            } 
        } 

        public double Yellow
        { 
            get
            {
                return y;
            } 
            set
            { 
                y = value; 
                y = (y>1)? 1 : ((y<0)? 0 : y); 
            } 
        } 

        public double Black 
        { 
            get
            {
                return k;
            } 
            set
            { 
                k = value; 
                k = (k>1)? 1 : ((k<0)? 0 : k); 
            } 
        } 
        #endregion

        /// <summary>
        /// Creates an instance of a CMYK structure.
        /// </summary>
        public CMYK(double c, double m, double y, double k) 
        {
            this.c = c;
            this.m = m;
            this.y = y;
            this.k = k;
        }

        #region Methods
        public override bool Equals(Object obj) 
        {
            if(obj==null || GetType()!=obj.GetType()) return false;

            return (this == (CMYK)obj);
        }

        public override int GetHashCode() 
        {
            return Cyan.GetHashCode() ^ Magenta.GetHashCode() ^ Yellow.GetHashCode() ^ Black.GetHashCode();
        }

        #endregion
    }
}