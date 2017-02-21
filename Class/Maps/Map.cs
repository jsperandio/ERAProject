﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ERAProject.Class.Maps
{
    class Map
    {
        private List<Tile> _selectedTiles;

        private List<Tile> _tiles;
        // The height of a hexagon.
        private float _tileHeight;

        private int _mapStyle;

        public Map(int mapStyleCreate)
        {
            MapStyle = mapStyleCreate;
            if(mapStyleCreate ==1 )
            {
                _tileHeight = 32;
                _tiles = new List<Tile>();
                _selectedTiles = new List<Tile>();
                ImportMap();
            }
        }

        public float TileHeight
        {
            get
            {
                return _tileHeight;
            }

            set
            {
                _tileHeight = value;
            }
        }

        public int MapStyle
        {
            get
            {
                return _mapStyle;
            }

            set
            {
                _mapStyle = value;
            }
        }


        // Load map by file
        public bool ImportMap()
        {
            int x = 0;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            using (var fs = File.OpenRead(path + "\\LoadFiles\\Map.txt"))
            using (var reader = new StreamReader(fs))
            {

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        Tile t = new Tile();
                        PointF p = new PointF(x, i);

                        t.Row = x;
                        t.Collum = i;
                        
                        t.Point = p;
                        t.Type = Convert.ToInt32(values[i]);
                        t.Hint = "Tipo " + values[i] + " do piso";
                        _tiles.Add(t);
                    }
                    x++;
                }
            }
            return x > 0 ? true : false;
        }

        public bool DrawPlayerPosition(Tile tile,Graphics gr)
        {
            if (tile == null)
                return false;
            else
            {
                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                Image imag = Image.FromFile(path + "\\LoadFiles\\player-flag.png");
                PointF[] points = HexToPoints(_tileHeight, tile.Point.X, tile.Point.Y);

                float x = ((points[0].X + points[3].X) / 3 )+8;
                float y = ((points[1].Y + points[4].Y) / 2)-15;

                gr.DrawImage(imag,x,y );

                //gr.DrawPolygon(Pens.Cyan, HexToPoints(_tileHeight, tile.Point.X, tile.Point.Y));
            }
            return true;
        }

        public void FillMapHexagons(Graphics gr)
        {
            for(int i=0; i<_tiles.Count-1;i++)
            {
                Brush br = Brushes.Blue;
                switch (_tiles[i].Type)
                {
                    //Campo
                    case 1:
                        {
                            br = Brushes.LightGreen;
                            break;
                        }
                    //Floresta
                    case 2:
                        {
                            br = Brushes.Green;
                            break;
                        }
                    //Montanha
                    case 3:
                        {
                            br = Brushes.Gray;
                            break;
                        }
                    //Cidade
                    case 10:
                        {
                            br = Brushes.Red;
                            break;
                        }
                  }
                gr.FillPolygon(br, HexToPoints(_tileHeight, _tiles[i].Point.X, _tiles[i].Point.Y));
            }
        }

        // Draw a hexagonal grid for the indicated area.
        // (You might be able to draw the hexagons without
        // drawing any duplicate edges, but this is a lot easier.)
        public void DrawHexGrid(Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            // Loop until a hexagon won't fit.
            for (int row = 0; ; row++)
            {
                // Get the points for the row's first hexagon.
                PointF[] points = HexToPoints(height, row, 0);

                // If it doesn't fit, we're done.
                if (points[4].Y > ymax) break;

                // Draw the row.
                for (int col = 0; ; col++)
                {
                    // Get the points for the row's next hexagon.
                    points = HexToPoints(height, row, col);

                    // If it doesn't fit horizontally,
                    // we're done with this row.
                    if (points[3].X > xmax) break;

                    // If it fits vertically, draw it.
                    if (points[4].Y <= ymax)
                    {
                        gr.DrawPolygon(pen, points);
                        // Label the hexagon (for Figure 1).
                        //using (StringFormat sf = new StringFormat())
                        //{
                        //    sf.Alignment = StringAlignment.Center;
                        //    sf.LineAlignment = StringAlignment.Center;
                        //    float x = (points[0].X + points[3].X) / 2;
                        //    float y = (points[1].Y + points[4].Y) / 2;
                        //    string label = "(" + row.ToString() + ", " +
                        //        col.ToString() + ")";
                        //    gr.DrawString(label, this.Font,
                        //        Brushes.Black, x, y, sf);
                        //}
                    }
                }
            }
        }


        // Draw list hexagon tile in a graph
        public void DrawHexagons(List<PointF> hex, Brush color, Graphics graph)
        {
            foreach (PointF point in hex)
            {
                graph.FillPolygon(color, HexToPoints(_tileHeight, point.X, point.Y));
            }
        }

        // Return the points that define the indicated hexagon.
        public PointF[] HexToPoints(float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;

            // Move down the required number of rows.
            y += row * height;

            // If the column is odd, move down half a hex more.
            if (col % 2 == 1) y += height / 2;

            // Move over for the column number.
            x += col * (width * 0.75f);

            // Generate the points.
            return new PointF[]
                {
                    new PointF(x, y),
                    new PointF(x + width * 0.25f, y - height / 2),
                    new PointF(x + width * 0.75f, y - height / 2),
                    new PointF(x + width, y),
                    new PointF(x + width * 0.75f, y + height / 2),
                    new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        // Return the row and column of the hexagon at this point.
        public void PointToHex(float x, float y, float height,
         out int row, out int col)
        {
            // Find the test rectangle containing the point.
            float width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
                row = (int)(y / height);
            else
                row = (int)((y - height / 2) / height);

            // Find the test area.
            float testx = col * width * 0.75f;
            float testy = row * height;
            if (col % 2 == 1) testy += height / 2;

            // See if the point is above or
            // below the test hexagon on the left.
            bool is_above = false, is_below = false;
            float dx = x - testx;
            if (dx < width / 4)
            {
                float dy = y - (testy + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    if (dy < 0) is_above = true;
                    if (dy > 0) is_below = true;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    if (-dy / dx > Math.Sqrt(3)) is_above = true;
                }
                else
                {
                    // See if the point is below the test hexagon.
                    if (dy / dx > Math.Sqrt(3)) is_below = true;
                }
            }

            // Adjust the row and column if necessary.
            if (is_above)
            {
                if (col % 2 == 0) row--;
                col--;
            }
            else if (is_below)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }

        public Tile PointToTile(float x, float y)
        {
            //int a=0, b=0;
            //PointToHex(x, y, _tileHeight,out a, out b);
            PointF polygon = new PointF(x, y);
            Tile t = _tiles.Find(polyg => polyg.Point.Equals(polygon));
            return t;
        }

        // Return the width of a hexagon.
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }
    }
}

