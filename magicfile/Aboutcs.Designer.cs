namespace magicfile
{
    partial class Aboutcs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMagicFile = new System.Windows.Forms.TabPage();
            this.tbFile = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbDonate = new System.Windows.Forms.TabPage();
            this.txtMagicFile = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtDonate = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbMagicFile.SuspendLayout();
            this.tbFile.SuspendLayout();
            this.tbDonate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbMagicFile);
            this.tabControl1.Controls.Add(this.tbFile);
            this.tabControl1.Controls.Add(this.tbDonate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tbMagicFile
            // 
            this.tbMagicFile.Controls.Add(this.txtMagicFile);
            this.tbMagicFile.Location = new System.Drawing.Point(4, 22);
            this.tbMagicFile.Name = "tbMagicFile";
            this.tbMagicFile.Padding = new System.Windows.Forms.Padding(3);
            this.tbMagicFile.Size = new System.Drawing.Size(406, 228);
            this.tbMagicFile.TabIndex = 0;
            this.tbMagicFile.Text = "MagicFile";
            this.tbMagicFile.UseVisualStyleBackColor = true;
            // 
            // tbFile
            // 
            this.tbFile.Controls.Add(this.txtFile);
            this.tbFile.Location = new System.Drawing.Point(4, 22);
            this.tbFile.Margin = new System.Windows.Forms.Padding(0);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(406, 228);
            this.tbFile.TabIndex = 1;
            this.tbFile.Text = "file";
            this.tbFile.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(347, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tbDonate
            // 
            this.tbDonate.Controls.Add(this.txtDonate);
            this.tbDonate.Location = new System.Drawing.Point(4, 22);
            this.tbDonate.Name = "tbDonate";
            this.tbDonate.Size = new System.Drawing.Size(406, 228);
            this.tbDonate.TabIndex = 2;
            this.tbDonate.Text = "Donate";
            this.tbDonate.UseVisualStyleBackColor = true;
            // 
            // txtMagicFile
            // 
            this.txtMagicFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMagicFile.Location = new System.Drawing.Point(3, 3);
            this.txtMagicFile.Multiline = true;
            this.txtMagicFile.Name = "txtMagicFile";
            this.txtMagicFile.ReadOnly = true;
            this.txtMagicFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMagicFile.Size = new System.Drawing.Size(400, 222);
            this.txtMagicFile.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Location = new System.Drawing.Point(0, 0);
            this.txtFile.Margin = new System.Windows.Forms.Padding(0);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFile.Size = new System.Drawing.Size(406, 228);
            this.txtFile.TabIndex = 1;
            // 
            // txtDonate
            // 
            this.txtDonate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonate.Location = new System.Drawing.Point(0, 0);
            this.txtDonate.Multiline = true;
            this.txtDonate.Name = "txtDonate";
            this.txtDonate.ReadOnly = true;
            this.txtDonate.Size = new System.Drawing.Size(406, 228);
            this.txtDonate.TabIndex = 1;
            this.txtDonate.Text = "Donation helps develop our software. See http://ambiesoft.fam.cx/donate/";
            // 
            // Aboutcs
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 311);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aboutcs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About MagicFile";
            this.Load += new System.EventHandler(this.Aboutcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbMagicFile.ResumeLayout(false);
            this.tbMagicFile.PerformLayout();
            this.tbFile.ResumeLayout(false);
            this.tbFile.PerformLayout();
            this.tbDonate.ResumeLayout(false);
            this.tbDonate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMagicFile;
        private System.Windows.Forms.TabPage tbFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMagicFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TabPage tbDonate;
        private System.Windows.Forms.TextBox txtDonate;
    }
}