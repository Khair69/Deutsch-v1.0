using Deutsch_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deutsch_v1._0.Forms
{
    public partial class newSavefrm : Form
    {
        static saves s = new saves(-1);
        public newSavefrm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            s.setName(saveTxtbox.Text);
            s.setPath(pathTxtBox.Text);
            s.setFrom(int.Parse(fromTxtbox.Text));
            s.setTo(int.Parse(toTxtbox.Text));
            s.setDtoe(true);
            s.newSave();
        }
    }
}
