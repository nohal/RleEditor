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
    /// Structure to define CIE XYZ.
    /// </summary>
    public struct CIEXYZ
    {
        /// <summary>
        /// Gets an empty CIEXYZ structure.
        /// </summary>
        public static readonly CIEXYZ Empty = new CIEXYZ();
        /// <summary>
        /// Gets the CIE D65 (white) structure.
        /// </summary>
        public static readonly CIEXYZ D65 = new CIEXYZ(0.9505, 1.0, 1.0890);

        #region Fields
        private double x;
        private double y;
        private double z;

        #endregion

        #region Operators
        public static bool operator ==(CIEXYZ item1, CIEXYZ item2)
        {
            return (
                       item1.X == item2.X 
                       && item1.Y == item2.Y 
                       && item1.Z == item2.Z
                   );
        }

        public static bool operator !=(CIEXYZ item1, CIEXYZ item2)
        {
            return (
                       item1.X != item2.X 
                       || item1.Y != item2.Y 
                       || item1.Z != item2.Z
                   );
        }

        #endregion

        #region Accessors
        /// <summary>
        /// Gets or sets X component.
        /// </summary>
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = (value>0.9505)? 0.9505 : ((value<0)? 0 : value);
            }
        }

        /// <summary>
        /// Gets or sets Y component.
        /// </summary>
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = (value>1.0)? 1.0 : ((value<0)?0 : value);
            }
        }

        /// <summary>
        /// Gets or sets Z component.
        /// </summary>
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = (value>1.089)? 1.089 : ((value<0)? 0 : value);
            }
        }

        #endregion

        public CIEXYZ(double x, double y, double z) 
        {
            this.x = (x>0.9505)? 0.9505 : ((x<0)? 0 : x);
            this.y = (y>1.0)? 1.0 : ((y<0)? 0 : y);
            this.z = (z>1.089)? 1.089 : ((z<0)? 0 : z);
        }

        #region Methods
        public override bool Equals(Object obj) 
        {
            if(obj==null || GetType()!=obj.GetType()) return false;

            return (this == (CIEXYZ)obj);
        }

        public override int GetHashCode() 
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        #endregion
    }
}