using System.Drawing;

namespace ERAProject.Class.Maps
{
    public class Tile
    {
        public Brush TileBrushColor { get { return GetTileColor(); } } 
        public Color TileColor { get { return ((SolidBrush)TileBrushColor).Color; } }
        public int Column { get => (int)Point.Y; }
        public PointF Point { get; set; }
        public int Row { get => (int)Point.X; }
        public int Type { get; set; }
        public string Hint { get; set; }

        public Tile()
        {
            Type = 0;
            Hint = "Tipo " + Type + " do piso";
        }

        private Brush GetTileColor()
        {
            Brush br = Brushes.Blue;
            switch (Type)
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
            return br;
        }
    }
}
