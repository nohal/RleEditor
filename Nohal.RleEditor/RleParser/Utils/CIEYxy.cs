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
    public struct CIEYxy
    {
        /// <summary>
        /// Gets an empty CIEYxy structure.
        /// </summary>
        public static readonly CIEYxy Empty = new CIEYxy();

        #region Fields
        private double _x;
        private double _y;
        private double _Y;

        #endregion

        #region Operators
        public static bool operator ==(CIEYxy item1, CIEYxy item2)
        {
            return (
                       item1.Y == item2.Y
                       && item1.x == item2.x
                       && item1.y == item2.y
                   );
        }

        public static bool operator !=(CIEYxy item1, CIEYxy item2)
        {
            return (
                       item1.Y != item2.Y
                       || item1.x != item2.x
                       || item1.y != item2.y
                   );
        }

        #endregion

        #region Accessors
        /// <summary>
        /// Gets or sets Y component.
        /// </summary>
        public double Y
        {
            get
            {
                return this._Y;
            }
            set
            {
                this._Y = (value > 100) ? 100 : ((value < 0) ? 0 : value);
            }
        }

        /// <summary>
        /// Gets or sets x component.
        /// </summary>
        public double x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = (value > 1.0) ? 1.0 : ((value < 0) ? 0 : value);
            }
        }

        /// <summary>
        /// Gets or sets y component.
        /// </summary>
        public double y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = (value > 1.0) ? 1.0 : ((value < 0) ? 0 : value);
            }
        }

        #endregion

        public CIEYxy(double Y, double x, double y)
        {
            this._Y = (Y> 100) ? 100 : ((Y < 0) ? 0 : Y);
            this._x = (x > 1.0) ? 1.0 : ((x < 0) ? 0 : x);
            this._y = (y > 1.0) ? 1.0 : ((y < 0) ? 0 : y);
        }

        #region Methods
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            return (this == (CIEYxy)obj);
        }

        public override int GetHashCode()
        {
            return Y.GetHashCode() ^ x.GetHashCode() ^ y.GetHashCode();
        }

        #endregion
    }
}