
namespace magicfile
{
    partial class Option
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
            this.chkCloseAfterRenaming = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkSkipWarning = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCloseAfterRenaming
            // 
            this.chkCloseAfterRenaming.AutoSize = true;
            this.chkCloseAfterRenaming.Location = new System.Drawing.Point(12, 12);
            this.chkCloseAfterRenaming.Name = "chkCloseAfterRenaming";
            this.chkCloseAfterRenaming.Size = new System.Drawing.Size(148, 19);
            this.chkCloseAfterRenaming.TabIndex = 100;
            this.chkCloseAfterRenaming.Text = "&Close after renaming";
            this.chkCloseAfterRenaming.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(187, 81);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 23);
            this.btnOK.TabIndex = 10000;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(12, 81);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(88, 23);
            this.btnAbout.TabIndex = 200;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkSkipWarning
            // 
            this.chkSkipWarning.AutoSize = true;
            this.chkSkipWarning.Location = new System.Drawing.Point(12, 37);
            this.chkSkipWarning.Name = "chkSkipWarning";
            this.chkSkipWarning.Size = new System.Drawing.Size(101, 19);
            this.chkSkipWarning.TabIndex = 150;
            this.chkSkipWarning.Text = "&Skip warning";
            this.chkSkipWarning.UseVisualStyleBackColor = true;
            // 
            // Option
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(293, 116);
            this.Controls.Add(this.chkSkipWarning);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkCloseAfterRenaming);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(227, 117);
            this.Name = "Option";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.CheckBox chkCloseAfterRenaming;
        private System.Windows.Forms.Button btnAbout;
        internal System.Windows.Forms.CheckBox chkSkipWarning;
    }
}