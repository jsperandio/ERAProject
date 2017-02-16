using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAProject.Class.Controllers
{
    class CtrlPlayer
    {
        public void ConstructPlayer(int playertype)
        {
            GlobalVariables.User = new Player();
        }
    }
}
