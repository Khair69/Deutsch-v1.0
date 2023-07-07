using Deutsch_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deutsch_v1._0.Forms
{
    public partial class loadfrm : Form
    {
        public loadfrm()
        {
            InitializeComponent();
            saves s = new saves();
            int numOfS = s.numOfSaves();
            string[] list = new string[numOfS];
            for (int i = 0; i < numOfS; i++)
            {
                s.loadSave(i + 1);
                list[i] = s.getName();
            }
            savesCmb.Items.AddRange(list);
        }
    }
}
