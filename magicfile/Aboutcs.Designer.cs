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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aboutcs));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMagicFile = new System.Windows.Forms.TabPage();
            this.txtMagicFile = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TabPage();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.tbDonate = new System.Windows.Forms.TabPage();
            this.txtDonate = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbGitrev = new System.Windows.Forms.TabPage();
            this.txtGitrev = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbMagicFile.SuspendLayout();
            this.tbFile.SuspendLayout();
            this.tbDonate.SuspendLayout();
            this.tbGitrev.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tbMagicFile);
            this.tabControl1.Controls.Add(this.tbFile);
            this.tabControl1.Controls.Add(this.tbGitrev);
            this.tabControl1.Controls.Add(this.tbDonate);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tbMagicFile
            // 
            this.tbMagicFile.Controls.Add(this.txtMagicFile);
            resources.ApplyResources(this.tbMagicFile, "tbMagicFile");
            this.tbMagicFile.Name = "tbMagicFile";
            this.tbMagicFile.UseVisualStyleBackColor = true;
            // 
            // txtMagicFile
            // 
            resources.ApplyResources(this.txtMagicFile, "txtMagicFile");
            this.txtMagicFile.Name = "txtMagicFile";
            this.txtMagicFile.ReadOnly = true;
            // 
            // tbFile
            // 
            this.tbFile.Controls.Add(this.txtFile);
            resources.ApplyResources(this.tbFile, "tbFile");
            this.tbFile.Name = "tbFile";
            this.tbFile.UseVisualStyleBackColor = true;
            // 
            // txtFile
            // 
            resources.ApplyResources(this.txtFile, "txtFile");
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            // 
            // tbDonate
            // 
            this.tbDonate.Controls.Add(this.txtDonate);
            resources.ApplyResources(this.tbDonate, "tbDonate");
            this.tbDonate.Name = "tbDonate";
            this.tbDonate.UseVisualStyleBackColor = true;
            // 
            // txtDonate
            // 
            resources.ApplyResources(this.txtDonate, "txtDonate");
            this.txtDonate.Name = "txtDonate";
            this.txtDonate.ReadOnly = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tbGitrev
            // 
            this.tbGitrev.Controls.Add(this.txtGitrev);
            resources.ApplyResources(this.tbGitrev, "tbGitrev");
            this.tbGitrev.Name = "tbGitrev";
            this.tbGitrev.UseVisualStyleBackColor = true;
            // 
            // txtGitrev
            // 
            resources.ApplyResources(this.txtGitrev, "txtGitrev");
            this.txtGitrev.Name = "txtGitrev";
            this.txtGitrev.ReadOnly = true;
            // 
            // Aboutcs
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aboutcs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Aboutcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbMagicFile.ResumeLayout(false);
            this.tbMagicFile.PerformLayout();
            this.tbFile.ResumeLayout(false);
            this.tbFile.PerformLayout();
            this.tbDonate.ResumeLayout(false);
            this.tbDonate.PerformLayout();
            this.tbGitrev.ResumeLayout(false);
            this.tbGitrev.PerformLayout();
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
        private System.Windows.Forms.TabPage tbGitrev;
        private System.Windows.Forms.TextBox txtGitrev;
    }
}