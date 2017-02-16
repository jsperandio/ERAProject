using System.Drawing;

namespace ERAProject.Class.Maps
{
    class Tile
    {
        public int Collum { get; set; }
        public int Row { get; set; }
        public PointF Point { get; set; }
        public int Type { get; set; }
        public string Hint { get; set; }
        public Tile()
        {
            Type = 0;
            Hint = "Tipo " + Type + "do piso";
        }

    }
}
