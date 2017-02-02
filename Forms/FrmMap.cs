using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmMap : Form
    {
        // The height of a hexagon.
        private const float HexHeight = 25;
        // Selected hexagons.
        private List<PointF> Hexagons = new List<PointF>();

        private List<Tile> Tiles = new List<Tile>();

        private ToolTip Current_tip;

        public FrmMap()
        {
            //LoadMap();
            InitializeComponent();
        }

        private void LoadMap()
        {
            using (var fs = File.OpenRead(@"C:\Users\Usuario\Desktop\Map.txt"))
            using (var reader = new StreamReader(fs))
            {
                int x = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        Tile t = new Tile();
                        PointF p = new PointF(x, i);
                        t.Point = p;
                        t.Type = Convert.ToInt32(values[i]);
                        t.Hint = "Tipo " + values[i] + "do piso";
                        Tiles.Add(t);
                    }
                    x++;
                }
            }
        }

        private void pbMapViewer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;



            foreach (Tile tile in Tiles)
            {
                Brush br = Brushes.Blue;
                switch (tile.Type)
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

                e.Graphics.FillPolygon(br, HexToPoints(HexHeight, tile.Point.X, tile.Point.Y));
            }

            // Draw the selected hexagons.
            foreach (PointF point in Hexagons)
            {
                //e.Graphics.FillPolygon(Brushes.LightBlue,HexToPoints(HexHeight, point.X, point.Y));
                e.Graphics.FillPolygon(Brushes.Purple, HexToPoints(HexHeight, point.X, point.Y));
            }

            // Draw the grid.
            DrawHexGrid(e.Graphics, Pens.Black,
                0, pbMapViewer.ClientSize.Width,
                0, pbMapViewer.ClientSize.Height,
                HexHeight);
        }

        // Draw a hexagonal grid for the indicated area.
        // (You might be able to draw the hexagons without
        // drawing any duplicate edges, but this is a lot easier.)
        private void DrawHexGrid(Graphics gr, Pen pen,
            float xmin, float xmax, float ymin, float ymax,
            float height)
        {
            //SolidBrush bWater = new SolidBrush(Color.LightBlue);
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
                        //if(col>4 && col < 15  && row>8 && row<15)
                        //gr.FillPolygon(bWater,points);


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

        // Return the width of a hexagon.
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        // Return the row and column of the hexagon at this point.
        private void PointToHex(float x, float y, float height,
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

        // Return the points that define the indicated hexagon.
        private PointF[] HexToPoints(float height, float row, float col)
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

        private void pbMapViewer_Resize(object sender, EventArgs e)
        {
            pbMapViewer.Refresh();
        }

        /*
         * Update map X,Y on mouse over tile
        */
        private void pbMapViewer_MouseMove(object sender, MouseEventArgs e)
        {
            int row, col;
            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            this.Text = "(" + row + ", " + col + ")";
        }

        /*
         * if not in selection add else remove from seleteds hexagons
         * case shift press , show information
        */
        private void pbMapViewer_MouseClick(object sender, MouseEventArgs e)
        {
            int row, col;
            PointF polygon;

            PointToHex(e.X, e.Y, HexHeight, out row, out col);
            polygon = new PointF(row, col);

            if (Control.ModifierKeys == Keys.Shift)
            {
                Tile t = Tiles.Find(x => x.Point.Equals(polygon));
                if (t != null)
                {
                    if (!t.Point.IsEmpty)
                    {
                        Current_tip = new ToolTip();
                        Current_tip.ToolTipTitle = "Description of Tyle";
                        Current_tip.Show(t.Hint, this, Cursor.Position.X, Cursor.Position.Y+25, 1000);
                    }
                } 
            }
            else
            {
                if ((Hexagons.Find(x => x.Equals(polygon))).IsEmpty)
                    Hexagons.Add(new PointF(row, col));
                else
                    Hexagons.Remove(polygon);

                pbMapViewer.Refresh();
            }


        }

    }
}
