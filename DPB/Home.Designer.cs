namespace DPB
{
    partial class Home
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.loginhome = new System.Windows.Forms.Panel();
            this.spacemapbt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtspace = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtspace);
            this.tabPage1.Controls.Add(this.txtUrl);
            this.tabPage1.Controls.Add(this.loginhome);
            this.tabPage1.Controls.Add(this.spacemapbt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Darkorbit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(7, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(22, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // loginhome
            // 
            this.loginhome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginhome.Location = new System.Drawing.Point(7, 32);
            this.loginhome.Name = "loginhome";
            this.loginhome.Size = new System.Drawing.Size(826, 393);
            this.loginhome.TabIndex = 3;
            this.loginhome.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // spacemapbt
            // 
            this.spacemapbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spacemapbt.Location = new System.Drawing.Point(755, 4);
            this.spacemapbt.Name = "spacemapbt";
            this.spacemapbt.Size = new System.Drawing.Size(75, 23);
            this.spacemapbt.TabIndex = 1;
            this.spacemapbt.Text = "SpaceMap";
            this.spacemapbt.UseVisualStyleBackColor = true;
            this.spacemapbt.Click += new System.EventHandler(this.spacemapbt_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtspace
            // 
            this.txtspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtspace.Location = new System.Drawing.Point(671, 6);
            this.txtspace.Name = "txtspace";
            this.txtspace.Size = new System.Drawing.Size(78, 20);
            this.txtspace.TabIndex = 5;
            this.txtspace.Text = "https://tr5.darkorbit.com/indexInternal.es?action=internalMapRevolution";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button spacemapbt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel loginhome;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtspace;
        public System.Windows.Forms.TabControl tabControl1;
    }
}