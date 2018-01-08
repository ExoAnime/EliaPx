namespace SpaceMap
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.SpaceMap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // SpaceMap
            // 
            this.SpaceMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceMap.Location = new System.Drawing.Point(0, 0);
            this.SpaceMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.SpaceMap.Name = "SpaceMap";
            this.SpaceMap.ScrollBarsEnabled = false;
            this.SpaceMap.Size = new System.Drawing.Size(905, 495);
            this.SpaceMap.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 495);
            this.Controls.Add(this.SpaceMap);
            this.Name = "Form1";
            this.Text = "SpaceMap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser SpaceMap;
    }
}

