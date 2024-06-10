namespace HamburgerProject
{
    partial class SiparisOlusturEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlusturEkrani));
            gboxBoylar = new GroupBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            lblToplam = new Label();
            label4 = new Label();
            lboxSiparisler = new ListBox();
            btnSiparisOnay = new Button();
            btnEkle = new Button();
            nudAdet = new NumericUpDown();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            cboxMenu = new ComboBox();
            pictureBox1 = new PictureBox();
            gboxBoylar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gboxBoylar
            // 
            gboxBoylar.Controls.Add(rbBuyuk);
            gboxBoylar.Controls.Add(rbOrta);
            gboxBoylar.Controls.Add(rbKucuk);
            gboxBoylar.Location = new Point(17, 468);
            gboxBoylar.Margin = new Padding(2);
            gboxBoylar.Name = "gboxBoylar";
            gboxBoylar.Padding = new Padding(2);
            gboxBoylar.Size = new Size(262, 81);
            gboxBoylar.TabIndex = 48;
            gboxBoylar.TabStop = false;
            gboxBoylar.Text = "Boyu Seçiniz";
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(164, 36);
            rbBuyuk.Margin = new Padding(2);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(88, 29);
            rbBuyuk.TabIndex = 11;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(86, 36);
            rbOrta.Margin = new Padding(2);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(74, 29);
            rbOrta.TabIndex = 11;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(-2, 36);
            rbKucuk.Margin = new Padding(2);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(88, 29);
            rbKucuk.TabIndex = 11;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Red;
            lblToplam.Location = new Point(433, 588);
            lblToplam.Margin = new Padding(2, 0, 2, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(83, 45);
            lblToplam.TabIndex = 47;
            lblToplam.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(333, 592);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 37);
            label4.TabIndex = 46;
            label4.Text = "Toplam";
            // 
            // lboxSiparisler
            // 
            lboxSiparisler.FormattingEnabled = true;
            lboxSiparisler.ItemHeight = 25;
            lboxSiparisler.Location = new Point(321, 22);
            lboxSiparisler.Margin = new Padding(2);
            lboxSiparisler.Name = "lboxSiparisler";
            lboxSiparisler.Size = new Size(757, 529);
            lboxSiparisler.TabIndex = 45;
            // 
            // btnSiparisOnay
            // 
            btnSiparisOnay.Location = new Point(805, 588);
            btnSiparisOnay.Margin = new Padding(2);
            btnSiparisOnay.Name = "btnSiparisOnay";
            btnSiparisOnay.Size = new Size(262, 68);
            btnSiparisOnay.TabIndex = 43;
            btnSiparisOnay.Text = "Siparişi Onayla";
            btnSiparisOnay.UseVisualStyleBackColor = true;
            btnSiparisOnay.Click += btnSiparisOnay_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(17, 611);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(262, 45);
            btnEkle.TabIndex = 44;
            btnEkle.Text = "Siparişi Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(111, 560);
            nudAdet.Margin = new Padding(2);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(167, 33);
            nudAdet.TabIndex = 42;
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.FlowDirection = FlowDirection.TopDown;
            flpEkstraMalzemeler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            flpEkstraMalzemeler.Location = new Point(17, 279);
            flpEkstraMalzemeler.Margin = new Padding(2);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(262, 174);
            flpEkstraMalzemeler.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 251);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 39;
            label2.Text = "Ekstra Malzeme Seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 174);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 40;
            label1.Text = "Menu Seçiniz";
            // 
            // cboxMenu
            // 
            cboxMenu.FormattingEnabled = true;
            cboxMenu.Location = new Point(17, 202);
            cboxMenu.Margin = new Padding(2);
            cboxMenu.Name = "cboxMenu";
            cboxMenu.Size = new Size(262, 33);
            cboxMenu.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 22);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // SiparisOlusturEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 686);
            Controls.Add(gboxBoylar);
            Controls.Add(lblToplam);
            Controls.Add(label4);
            Controls.Add(lboxSiparisler);
            Controls.Add(btnSiparisOnay);
            Controls.Add(btnEkle);
            Controls.Add(nudAdet);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxMenu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SiparisOlusturEkrani";
            Text = "SiparisOlusturEkrani";
            Load += SiparisOlusturEkrani_Load;
            gboxBoylar.ResumeLayout(false);
            gboxBoylar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxBoylar;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private Label lblToplam;
        private Label label4;
        private ListBox lboxSiparisler;
        private Button btnSiparisOnay;
        private Button btnEkle;
        private NumericUpDown nudAdet;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label2;
        private Label label1;
        private ComboBox cboxMenu;
        private PictureBox pictureBox1;
    }
}