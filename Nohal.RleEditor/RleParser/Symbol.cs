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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

using System.Text;

namespace Nohal.RleEditor.RleParser
{
    /// <summary>
    /// TODO: divide into bitmap, vector and ancestor
    /// </summary>
    public abstract class Symbol : RleObject
    {
        public const char TransparentChar = '@';

        public new const string ObjectType = "SY";

        public ColorTable ColorTable { get; set; }

        public System.Drawing.Bitmap Image
        {
            get
            {
                if (SymbolType == 'R')
                {
                    int counter = 0;
                    System.Drawing.Bitmap img = new System.Drawing.Bitmap(Width, Height);
                    foreach (char pixel in _symboldata.ToString().Replace(Environment.NewLine, string.Empty))
                    {
                        if (pixel == TransparentChar)
                            img.SetPixel(counter%Width, counter/Width, Color.Transparent);
                        else
                        {
                            img.SetPixel(counter%Width, counter/Width, Colors[pixel].Color);
                        }
                        counter++;
                    }
                    return img;
                }
                if (SymbolType == 'V')
                {
                    return GetVectorRendering(null);
                }
                throw new NotImplementedException(string.Format("I think, that Symbol type {0} shouldn't exist.", SymbolType));
            }
        }
        public string Code { get; set; }
        public string Description { get; set; }
        public char SymbolType { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int HotspotX { get; set; }
        public int HotspotY { get; set; }
        public Dictionary<char, ColorRecord> Colors { get; set; }

        private StringBuilder _symboldata = new StringBuilder();

        internal void AddLine(string line)
        {
            _symboldata.AppendLine(line);
        }

        public string BitmapData
        {
            get { return _symboldata.ToString(); }
        }

        internal Symbol()
        {
            Colors = new Dictionary<char, ColorRecord>();
        }

        public void ChangeColorTable(ColorTable colortable)
        {
            Dictionary<char, ColorRecord> newcolors = new Dictionary<char, ColorRecord>();
            foreach (var color in Colors)
            {
                newcolors.Add(color.Key, colortable.Colors[color.Value.Code]);
            }
            Colors = newcolors;
        }

        public System.Drawing.Bitmap GetZoomedImage(int zoomLevel, bool showGrid)
        {
            int counter = 0;
            System.Drawing.Bitmap img = new System.Drawing.Bitmap(Width * zoomLevel, Height * zoomLevel);
            foreach (char pixel in _symboldata.ToString().Replace(Environment.NewLine, string.Empty))
            {
                if (pixel == TransparentChar)
                {
                    RenderSquare(ref img, counter % Width * zoomLevel, counter / Width * zoomLevel, zoomLevel, Color.Transparent, showGrid);
                }
                else
                {
                    RenderSquare(ref img, counter % Width * zoomLevel, counter / Width * zoomLevel, zoomLevel, Colors[pixel].Color, showGrid);
                }
                counter++;
            }
            if (showGrid && zoomLevel > 5)
            {
                for (int i = 1; i <= Width * zoomLevel; i++)
                {
                    img.SetPixel(i - 1, Height * zoomLevel - 1, Color.Black);
                }
                for (int i = 1; i <= Height * zoomLevel; i++)
                {
                    img.SetPixel(Width * zoomLevel - 1, i - 1, Color.Black);
                }
            }
            return img;
        }

        public static void RenderSquare(ref System.Drawing.Bitmap image, int x, int y, int size, Color color, bool border)
        {
            Color myclr = color;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (border && size >= 5)
                    {
                        if (i == 0 || j == 0)
                        {
                            myclr = Color.Black; //border
                        }
                        else
                        {
                            myclr = color;
                        }
                    }
                    image.SetPixel(x + i, y + j, myclr);
                }
            }
        }

        //vector symbols
        public Bitmap GetVectorRendering(ColorTable colortable)
        {
            double reduction = 5;
            string[] commands = _symboldata.ToString().Replace(Environment.NewLine, string.Empty).Split(';');
            Bitmap btmp = new Bitmap((int)(Width / reduction) + 1, (int)(Height / reduction) + 1);
            Graphics canvas = Graphics.FromImage(btmp);
            Point curpos = new Point();
            Point newpos = new Point();
            Pen curpen = new Pen(Color.Transparent, 1);
            List<Point> polygonbuffer = new List<Point>();
            bool polygonmode = false;
            foreach (string command in commands)
            {
                if (command.Length >= 2)
                {
                    string[] points;
                    switch (command.Substring(0, 2))
                        //http://www.informatics-consulting.de/software/plot2emf/p2e_hpgl.htm and http://www.isoplotec.co.jp/HPGL/eHPGL.htm
                    {
                        case "SP": //Select pen
                            //curpen.Color = Colors[command[command.Length - 1]].Color;
                            curpen.Color = colortable.Colors[Colors[command[command.Length - 1]].Code].Color;
                            break;
                        case "SW": //Select width - TODO: not part of the standard, is it really line width
                            curpen.Width = Convert.ToInt32(command[command.Length - 1].ToString()) * 2;
                            break;
                        case "PU": //Move with pen up
                            points = command.Substring(2).Split(',');
                            for (int i = 0; i < points.Length/2; i++)
                            {
                                curpos.X = Convert.ToInt32(command.Substring(2).Split(',')[2 * i]) - HotspotX;
                                curpos.X = (int) (curpos.X/reduction);
                                curpos.Y = Convert.ToInt32(command.Substring(2).Split(',')[2 * i + 1]) - HotspotY;
                                curpos.Y = (int)(curpos.Y / reduction);
                                if (polygonmode)
                                    polygonbuffer.Add(curpos);

                            }
                            break;
                        case "PD": //Move with pen down
                            if (command.Length > 2)
                            {
                                points = command.Substring(2).Split(',');
                                for (int i = 0; i < points.Length / 2; i++)
                                {
                                    newpos.X = Convert.ToInt32(command.Substring(2).Split(',')[2 * i]) - HotspotX;
                                    newpos.X = (int) (newpos.X/reduction);
                                    newpos.Y = Convert.ToInt32(command.Substring(2).Split(',')[2 * i + 1]) - HotspotY;
                                    newpos.Y = (int) (newpos.Y/reduction);
                                    canvas.DrawLine(curpen, curpos, newpos);
                                    curpos = newpos;
                                    if (polygonmode)
                                        polygonbuffer.Add(curpos);
                                }
                            }
                            else //Weird, but some symbols have just PD without coordinates so I assume it to be a point
                            {
                                canvas.DrawEllipse(curpen, curpos.X, curpos.Y, 1, 1);
                            }
                            break;
                        case "CI": //CI r [, qd]  	Draw Circle
                            int radius = Convert.ToInt32(command.Substring(2));
                            radius = (int)(radius / reduction);
                            if (polygonmode)
                                canvas.FillEllipse(new SolidBrush(curpen.Color), curpos.X - radius, curpos.Y - radius,
                                                   radius*2, radius*2);
                            else
                                canvas.DrawEllipse(curpen, curpos.X - radius, curpos.Y - radius, radius*2, radius*2);
                            break;
                        case "PM": //PM [n]  	Polygon mode (HPGL/2)
                            polygonmode = !polygonmode;
                            if (polygonmode)
                                polygonbuffer.Add(curpos);
                            break;
                        case "FP": //FP  	Filled Polygon (HPGL/2)
                            if (polygonbuffer.Count > 0)
                            {
                                canvas.FillPolygon(new SolidBrush(curpen.Color), polygonbuffer.ToArray());
                                polygonbuffer.Clear();
                            }
                            break;
                        default:
                            Debug.Print("HP-GL command {0} unknown.", command);
                            break;
                    }
                }
            }
            return btmp;
        }

        public void ChangePixel(int x, int y, string colorcode)
        {
            char colchar = '@';
            foreach (KeyValuePair<char, ColorRecord> pair in Colors)
            {
                if (pair.Value.Code == colorcode)
                {
                    colchar = pair.Key;
                }
            }
            int charpos = y*(_symboldata.ToString().IndexOf(Environment.NewLine) + Environment.NewLine.Length) + x;
            _symboldata[charpos] = colchar;
        }
    }
}
