using deutsch_code;
using Deutsch_v1._0.Forms;
using System.Diagnostics;

namespace Deutsch_v1._0
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            gamefrm gfrm = new gamefrm();
            gfrm.Show();
            this.Hide();
        }
    }
}