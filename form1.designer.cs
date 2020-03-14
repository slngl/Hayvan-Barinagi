namespace HayvanBarınağı
{
    partial class Ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.barınağımızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayvanlarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sahiplerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işletmemizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerimizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulunduğumuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barınağımızToolStripMenuItem,
            this.işletmemizToolStripMenuItem,
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // barınağımızToolStripMenuItem
            // 
            this.barınağımızToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hayvanlarListesiToolStripMenuItem,
            this.sahiplerListesiToolStripMenuItem});
            this.barınağımızToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barınağımızToolStripMenuItem.Name = "barınağımızToolStripMenuItem";
            this.barınağımızToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.barınağımızToolStripMenuItem.Text = "Barınağımız";
            // 
            // hayvanlarListesiToolStripMenuItem
            // 
            this.hayvanlarListesiToolStripMenuItem.Name = "hayvanlarListesiToolStripMenuItem";
            this.hayvanlarListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hayvanlarListesiToolStripMenuItem.Text = "Hayvanlar Listesi";
            this.hayvanlarListesiToolStripMenuItem.Click += new System.EventHandler(this.hayvanlarListesiToolStripMenuItem_Click);
            // 
            // sahiplerListesiToolStripMenuItem
            // 
            this.sahiplerListesiToolStripMenuItem.Name = "sahiplerListesiToolStripMenuItem";
            this.sahiplerListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sahiplerListesiToolStripMenuItem.Text = "Sahipler Listesi";
            this.sahiplerListesiToolStripMenuItem.Click += new System.EventHandler(this.sahiplerListesiToolStripMenuItem_Click);
            // 
            // işletmemizToolStripMenuItem
            // 
            this.işletmemizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarListesiToolStripMenuItem,
            this.bölümlerimizToolStripMenuItem,
            this.bulunduğumuzToolStripMenuItem});
            this.işletmemizToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.işletmemizToolStripMenuItem.Name = "işletmemizToolStripMenuItem";
            this.işletmemizToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.işletmemizToolStripMenuItem.Text = "İşletmemiz";
            // 
            // çalışanlarListesiToolStripMenuItem
            // 
            this.çalışanlarListesiToolStripMenuItem.Name = "çalışanlarListesiToolStripMenuItem";
            this.çalışanlarListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanlarListesiToolStripMenuItem.Text = "Çalışanlarımız";
            this.çalışanlarListesiToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarListesiToolStripMenuItem_Click);
            // 
            // bölümlerimizToolStripMenuItem
            // 
            this.bölümlerimizToolStripMenuItem.Name = "bölümlerimizToolStripMenuItem";
            this.bölümlerimizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bölümlerimizToolStripMenuItem.Text = "Bölümlerimiz";
            this.bölümlerimizToolStripMenuItem.Click += new System.EventHandler(this.bölümlerimizToolStripMenuItem_Click);
            // 
            // bulunduğumuzToolStripMenuItem
            // 
            this.bulunduğumuzToolStripMenuItem.Name = "bulunduğumuzToolStripMenuItem";
            this.bulunduğumuzToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.bulunduğumuzToolStripMenuItem.Text = "Bulunduğumuz Bölgeler";
            this.bulunduğumuzToolStripMenuItem.Click += new System.EventHandler(this.bulunduğumuzToolStripMenuItem_Click);
            // 
            // barınağımızaBağıçtaBulunanlarToolStripMenuItem
            // 
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem.Name = "barınağımızaBağıçtaBulunanlarToolStripMenuItem";
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem.Text = "Barınağımıza Bağıçta Bulunanlar";
            this.barınağımızaBağıçtaBulunanlarToolStripMenuItem.Click += new System.EventHandler(this.barınağımızaBağıçtaBulunanlarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(358, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ana";
            this.Text = "Hayvan Barınağı";
            this.Load += new System.EventHandler(this.Ana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barınağımızToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayvanlarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sahiplerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işletmemizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerimizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulunduğumuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barınağımızaBağıçtaBulunanlarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

