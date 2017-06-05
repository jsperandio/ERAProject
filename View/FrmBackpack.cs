using System.Windows.Forms;

namespace ERAProject.Forms
{
    public partial class FrmBackpack : Form
    {
        public FrmBackpack()
        {
            InitializeComponent();
        }

        private void FrmBackpack_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
