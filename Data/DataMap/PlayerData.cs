using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAProject.Data.DataMap
{
    public class PlayerData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long MaxHitPoints { get; set; }
        public long HitPoints { get; set; }
        public long Gold { get; set; }
        public long Level { get; set; }
        public long ExperiencePoints { get; set; }
        public byte[] Avatar { get; set; }
    }
}
