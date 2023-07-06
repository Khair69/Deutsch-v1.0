namespace Deutsch_v1._0.Forms
{
    partial class newSavefrm
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
            this.saveTxtbox = new System.Windows.Forms.TextBox();
            this.langCmb = new System.Windows.Forms.ComboBox();
            this.selectFileLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromTxtbox = new System.Windows.Forms.TextBox();
            this.toTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveTxtbox
            // 
            this.saveTxtbox.Location = new System.Drawing.Point(170, 63);
            this.saveTxtbox.Name = "saveTxtbox";
            this.saveTxtbox.Size = new System.Drawing.Size(410, 23);
            this.saveTxtbox.TabIndex = 0;
            this.saveTxtbox.Text = "preset name";
            // 
            // langCmb
            // 
            this.langCmb.FormattingEnabled = true;
            this.langCmb.Items.AddRange(new object[] {
            "German To English"});
            this.langCmb.Location = new System.Drawing.Point(170, 104);
            this.langCmb.Name = "langCmb";
            this.langCmb.Size = new System.Drawing.Size(410, 23);
            this.langCmb.TabIndex = 1;
            // 
            // selectFileLbl
            // 
            this.selectFileLbl.AutoSize = true;
            this.selectFileLbl.Location = new System.Drawing.Point(170, 156);
            this.selectFileLbl.Name = "selectFileLbl";
            this.selectFileLbl.Size = new System.Drawing.Size(89, 15);
            this.selectFileLbl.TabIndex = 3;
            this.selectFileLbl.Text = "Select Text File..";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(611, 387);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(170, 207);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(35, 15);
            this.fromLbl.TabIndex = 3;
            this.fromLbl.Text = "From";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(349, 207);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(19, 15);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "To";
            // 
            // fromTxtbox
            // 
            this.fromTxtbox.Location = new System.Drawing.Point(228, 207);
            this.fromTxtbox.Name = "fromTxtbox";
            this.fromTxtbox.Size = new System.Drawing.Size(97, 23);
            this.fromTxtbox.TabIndex = 0;
            // 
            // toTxtbox
            // 
            this.toTxtbox.Location = new System.Drawing.Point(393, 204);
            this.toTxtbox.Name = "toTxtbox";
            this.toTxtbox.Size = new System.Drawing.Size(97, 23);
            this.toTxtbox.TabIndex = 0;
            // 
            // newSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.selectFileLbl);
            this.Controls.Add(this.langCmb);
            this.Controls.Add(this.toTxtbox);
            this.Controls.Add(this.fromTxtbox);
            this.Controls.Add(this.saveTxtbox);
            this.Name = "newSave";
            this.Text = "newSave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox saveTxtbox;
        private ComboBox langCmb;
        private Label selectFileLbl;
        private Button saveBtn;
        private Label fromLbl;
        private Label toLbl;
        private TextBox fromTxtbox;
        private TextBox toTxtbox;
    }
}