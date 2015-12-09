namespace magicfile
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtMime = new System.Windows.Forms.TextBox();
            this.txtMagic = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnChangeExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExt
            // 
            this.txtExt.AccessibleDescription = null;
            this.txtExt.AccessibleName = null;
            resources.ApplyResources(this.txtExt, "txtExt");
            this.txtExt.BackgroundImage = null;
            this.txtExt.Font = null;
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = true;
            // 
            // txtMime
            // 
            this.txtMime.AccessibleDescription = null;
            this.txtMime.AccessibleName = null;
            resources.ApplyResources(this.txtMime, "txtMime");
            this.txtMime.BackgroundImage = null;
            this.txtMime.Font = null;
            this.txtMime.Name = "txtMime";
            this.txtMime.ReadOnly = true;
            // 
            // txtMagic
            // 
            this.txtMagic.AccessibleDescription = null;
            this.txtMagic.AccessibleName = null;
            resources.ApplyResources(this.txtMagic, "txtMagic");
            this.txtMagic.BackgroundImage = null;
            this.txtMagic.Font = null;
            this.txtMagic.Name = "txtMagic";
            this.txtMagic.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFile
            // 
            this.txtFile.AccessibleDescription = null;
            this.txtFile.AccessibleName = null;
            resources.ApplyResources(this.txtFile, "txtFile");
            this.txtFile.BackgroundImage = null;
            this.txtFile.Font = null;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // btnNavigate
            // 
            this.btnNavigate.AccessibleDescription = null;
            this.btnNavigate.AccessibleName = null;
            resources.ApplyResources(this.btnNavigate, "btnNavigate");
            this.btnNavigate.BackgroundImage = null;
            this.btnNavigate.Font = null;
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // btnChangeExt
            // 
            this.btnChangeExt.AccessibleDescription = null;
            this.btnChangeExt.AccessibleName = null;
            resources.ApplyResources(this.btnChangeExt, "btnChangeExt");
            this.btnChangeExt.BackgroundImage = null;
            this.btnChangeExt.Font = null;
            this.btnChangeExt.Name = "btnChangeExt";
            this.btnChangeExt.UseVisualStyleBackColor = true;
            this.btnChangeExt.Click += new System.EventHandler(this.btnChangeExt_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnOK;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnChangeExt);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtMime);
            this.Controls.Add(this.txtMagic);
            this.Font = null;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormMain_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtMime;
        private System.Windows.Forms.TextBox txtMagic;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnChangeExt;
    }
}

