namespace Deutsch_v1._0.Forms
{
    partial class gamefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dWordLbl = new System.Windows.Forms.Label();
            this.ansTxtbox = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.cnBtn = new System.Windows.Forms.Button();
            this.resLbl = new System.Windows.Forms.Label();
            this.gameProg = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dWordLbl
            // 
            this.dWordLbl.AutoSize = true;
            this.dWordLbl.Location = new System.Drawing.Point(330, 141);
            this.dWordLbl.Name = "dWordLbl";
            this.dWordLbl.Size = new System.Drawing.Size(81, 15);
            this.dWordLbl.TabIndex = 0;
            this.dWordLbl.Text = "German Word";
            // 
            // ansTxtbox
            // 
            this.ansTxtbox.Location = new System.Drawing.Point(259, 199);
            this.ansTxtbox.Name = "ansTxtbox";
            this.ansTxtbox.Size = new System.Drawing.Size(252, 23);
            this.ansTxtbox.TabIndex = 1;
            this.ansTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ansTxtbox_KeyDown);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(601, 354);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // cnBtn
            // 
            this.cnBtn.Location = new System.Drawing.Point(601, 354);
            this.cnBtn.Name = "cnBtn";
            this.cnBtn.Size = new System.Drawing.Size(75, 23);
            this.cnBtn.TabIndex = 3;
            this.cnBtn.Text = "Continue";
            this.cnBtn.UseVisualStyleBackColor = true;
            this.cnBtn.Visible = false;
            this.cnBtn.Click += new System.EventHandler(this.cnBtn_Click);
            // 
            // resLbl
            // 
            this.resLbl.AutoSize = true;
            this.resLbl.Location = new System.Drawing.Point(259, 354);
            this.resLbl.Name = "resLbl";
            this.resLbl.Size = new System.Drawing.Size(0, 15);
            this.resLbl.TabIndex = 4;
            this.resLbl.Visible = false;
            // 
            // gameProg
            // 
            this.gameProg.Location = new System.Drawing.Point(72, 32);
            this.gameProg.Name = "gameProg";
            this.gameProg.Size = new System.Drawing.Size(641, 23);
            this.gameProg.TabIndex = 5;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameProg);
            this.Controls.Add(this.resLbl);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.ansTxtbox);
            this.Controls.Add(this.dWordLbl);
            this.Controls.Add(this.cnBtn);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dWordLbl;
        private TextBox ansTxtbox;
        private Button checkBtn;
        private Button cnBtn;
        private Label resLbl;
        private ProgressBar gameProg;
    }
}