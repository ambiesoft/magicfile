
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.chkCloseAfterRenaming = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkSkipWarning = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCloseAfterRenaming
            // 
            resources.ApplyResources(this.chkCloseAfterRenaming, "chkCloseAfterRenaming");
            this.chkCloseAfterRenaming.Name = "chkCloseAfterRenaming";
            this.chkCloseAfterRenaming.UseVisualStyleBackColor = true;
            this.chkCloseAfterRenaming.CheckedChanged += new System.EventHandler(this.chkCloseAfterRenaming_CheckedChanged);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkSkipWarning
            // 
            resources.ApplyResources(this.chkSkipWarning, "chkSkipWarning");
            this.chkSkipWarning.Name = "chkSkipWarning";
            this.chkSkipWarning.UseVisualStyleBackColor = true;
            this.chkSkipWarning.CheckedChanged += new System.EventHandler(this.chkSkipWarning_CheckedChanged);
            // 
            // Option
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.chkSkipWarning);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkCloseAfterRenaming);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Option";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox chkCloseAfterRenaming;
        private System.Windows.Forms.CheckBox chkSkipWarning;
    }
}