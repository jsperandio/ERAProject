using System.Drawing;

namespace ERAProject
{
    class Tile
    {
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
