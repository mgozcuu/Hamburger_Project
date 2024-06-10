namespace HamburgerProject
{
    partial class AnaEkran
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
            menuStrip1 = new MenuStrip();
            siparişİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparişleriGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            ürünİşlemlerToolStripMenuItem = new ToolStripMenuItem();
            menuEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişİşlemleriToolStripMenuItem, ürünİşlemlerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(832, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparişleriGörüntüleToolStripMenuItem });
            siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            siparişİşlemleriToolStripMenuItem.Size = new Size(160, 29);
            siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(287, 34);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // siparişleriGörüntüleToolStripMenuItem
            // 
            siparişleriGörüntüleToolStripMenuItem.Name = "siparişleriGörüntüleToolStripMenuItem";
            siparişleriGörüntüleToolStripMenuItem.Size = new Size(287, 34);
            siparişleriGörüntüleToolStripMenuItem.Text = "Siparişleri Görüntüle";
            siparişleriGörüntüleToolStripMenuItem.Click += siparişleriGörüntüleToolStripMenuItem_Click;
            // 
            // ürünİşlemlerToolStripMenuItem
            // 
            ürünİşlemlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            ürünİşlemlerToolStripMenuItem.Name = "ürünİşlemlerToolStripMenuItem";
            ürünİşlemlerToolStripMenuItem.Size = new Size(141, 29);
            ürünİşlemlerToolStripMenuItem.Text = "Ürün İşlemler";
            // 
            // menuEkleToolStripMenuItem
            // 
            menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            menuEkleToolStripMenuItem.Size = new Size(285, 34);
            menuEkleToolStripMenuItem.Text = "Menu Ekle";
            menuEkleToolStripMenuItem.Click += menuEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(285, 34);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 518);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaEkran";
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem siparişleriGörüntüleToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemlerToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}