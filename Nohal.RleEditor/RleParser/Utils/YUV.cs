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
    /// Structure to define YUV.
    /// </summary>
    public struct YUV 
    {
        /// <summary>
        /// Gets an empty YUV structure.
        /// </summary>
        public static readonly YUV Empty = new YUV();

        #region Fields
        private double y; 
        private double u; 
        private double v; 
        #endregion

        #region Operators
        public static bool operator ==(YUV item1, YUV item2)
        {
            return (
                       item1.Y == item2.Y 
                       && item1.U == item2.U 
                       && item1.V == item2.V
                   );
        }

        public static bool operator !=(YUV item1, YUV item2)
        {
            return (
                       item1.Y != item2.Y 
                       || item1.U != item2.U 
                       || item1.V != item2.V
                   );
        }

        #endregion

        #region Accessors
        public double Y
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

        public double U
        { 
            get
            {
                return u;
            } 
            set
            { 
                u = value; 
                u = (u>0.436)? 0.436 : ((u<-0.436)? -0.436 : u); 
            } 
        } 

        public double V
        { 
            get
            {
                return v;
            } 
            set
            { 
                v = value; 
                v = (v>0.615)? 0.615 : ((v<-0.615)? -0.615 : v); 
            } 
        } 

        #endregion

        /// <summary>
        /// Creates an instance of a YUV structure.
        /// </summary>
        public YUV(double y, double u, double v) 
        {
            this.y = y;
            this.u = u;
            this.v = v;
        }

        #region Methods
        public override bool Equals(Object obj) 
        {
            if(obj==null || GetType()!=obj.GetType()) return false;

            return (this == (YUV)obj);
        }

        public override int GetHashCode() 
        {
            return Y.GetHashCode() ^ U.GetHashCode() ^ V.GetHashCode();
        }

        #endregion
    }
}