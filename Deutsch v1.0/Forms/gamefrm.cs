using deutsch_code;
using Deutsch_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deutsch_v1._0.Forms
{
    public partial class gamefrm : Form
    {
        static int gId;
        static int probIdx = 0;
        static saves s = new saves(gId);
        static int[] rngs = rng.rngBetween(s.getFrom(), s.getTo());
        static int range = s.getTo() - s.getFrom() + 1;
        static Question q = new Question();

        public gamefrm(int gameId)
        {
            gId = gameId;
            InitializeComponent();
            gameProg.Maximum = range;
            q.setwPath(s.getPath());
            newQ();
            dWordLbl.Text = q.getDWord();
            this.ActiveControl = ansTxtbox;
            ansTxtbox.Focus();
        }


        public static void newQ()
        {
            q.setIdx(rngs[probIdx]);
            q.newQuestion();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (q.dtoe(ansTxtbox.Text) == true)
            {
                resLbl.Visible = true;
                resLbl.Text = "You're Goddamn Right!";
                cnBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value = probIdx+1;
            }
            else
            {
                resLbl.Visible = true;
                resLbl.Text = "Wrong the right answer is " + q.getEWord();
                cnBtn.Visible = true;
                checkBtn.Visible = false;
                gameProg.Value = probIdx + 1;
            }
            
            
            
        }

        private void cnBtn_Click(object sender, EventArgs e)
        {
            probIdx++;
            if (probIdx > rngs.Length - 1) 
            { 
            }
            else
            {
                cnBtn.Visible = false;
                checkBtn.Visible = true;
                newQ();
                dWordLbl.Text = q.getDWord();
                resLbl.Visible = false;
                ansTxtbox.Text = "";
            }
            
        }

        private void ansTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBtn_Click(sender,e);
                cnBtn.Focus();
            }
        }
    }
}
