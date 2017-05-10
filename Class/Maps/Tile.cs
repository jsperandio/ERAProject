using System.Drawing;

namespace ERAProject.Class.Maps
{
    public class Tile
    {
        private PointF _point;
        private int _type;
        private string _hint;


        public Brush TileBrushColor { get { return GetTileColor(); } } 
        public Color TileColor { get { return ((SolidBrush)TileBrushColor).Color; } }
        public int Column { get => (int)_point.Y; }
        public PointF Point { get => _point; set => _point = value; }
        public int Row { get => (int)_point.X; }
        public int Type { get => _type; set => _type = value; }
        public string Hint { get => _hint; set => _hint = value; }

        public Tile()
        {
            Type = 0;
            Hint = "Tipo " + Type + " do piso";
        }

        private Brush GetTileColor()
        {
            Brush br = Brushes.Blue;
            switch (_type)
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
