namespace Benim_Bakkalım
{
    partial class sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sale));
            listBox1 = new ListBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnHesapla = new Button();
            btnSepeteEkle = new Button();
            sepetList = new ListBox();
            label2 = new Label();
            sepetTutarıLabel = new Label();
            receiptBtn = new Button();
            tutar = new Label();
            panel1 = new Panel();
            addBtn = new Button();
            priceTxt = new TextBox();
            productTxt = new TextBox();
            price = new Label();
            name = new Label();
            tutarLabel = new Label();
            open_closeBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            dontConfirmPicture = new PictureBox();
            ConfirmBtn = new Button();
            confirmPicture = new PictureBox();
            sonTutar = new Label();
            newCustomerBtn = new Button();
            label4 = new Label();
            krediRadio = new RadioButton();
            nakitRadio = new RadioButton();
            label3 = new Label();
            sepetBaslik = new Label();
            urunBaslik = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dontConfirmPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)confirmPicture).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(54, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 344);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 469);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Adet :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.ImeMode = ImeMode.NoControl;
            numericUpDown1.Location = new Point(133, 467);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Salmon;
            btnHesapla.FlatAppearance.BorderColor = Color.Salmon;
            btnHesapla.FlatStyle = FlatStyle.Popup;
            btnHesapla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.Location = new Point(241, 467);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(100, 35);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.BackColor = Color.Salmon;
            btnSepeteEkle.FlatStyle = FlatStyle.Popup;
            btnSepeteEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSepeteEkle.Location = new Point(241, 523);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(100, 35);
            btnSepeteEkle.TabIndex = 4;
            btnSepeteEkle.Text = "Sepete ekle";
            btnSepeteEkle.UseVisualStyleBackColor = false;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // sepetList
            // 
            sepetList.BackColor = Color.White;
            sepetList.FormattingEnabled = true;
            sepetList.ItemHeight = 20;
            sepetList.Location = new Point(485, 103);
            sepetList.Name = "sepetList";
            sepetList.Size = new Size(509, 344);
            sepetList.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(532, 479);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 6;
            label2.Text = "Toplam Tutar:";
            // 
            // sepetTutarıLabel
            // 
            sepetTutarıLabel.AutoSize = true;
            sepetTutarıLabel.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sepetTutarıLabel.Location = new Point(670, 481);
            sepetTutarıLabel.Name = "sepetTutarıLabel";
            sepetTutarıLabel.Size = new Size(0, 21);
            sepetTutarıLabel.TabIndex = 7;
            sepetTutarıLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // receiptBtn
            // 
            receiptBtn.BackColor = Color.Salmon;
            receiptBtn.FlatStyle = FlatStyle.Popup;
            receiptBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            receiptBtn.Location = new Point(880, 616);
            receiptBtn.Name = "receiptBtn";
            receiptBtn.Size = new Size(105, 35);
            receiptBtn.TabIndex = 8;
            receiptBtn.Text = "Fiş Kes";
            receiptBtn.UseVisualStyleBackColor = false;
            receiptBtn.Visible = false;
            receiptBtn.Click += receiptBtn_Click;
            // 
            // tutar
            // 
            tutar.AutoSize = true;
            tutar.FlatStyle = FlatStyle.Flat;
            tutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tutar.Location = new Point(59, 531);
            tutar.Name = "tutar";
            tutar.Size = new Size(54, 20);
            tutar.TabIndex = 9;
            tutar.Text = "Tutar :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(priceTxt);
            panel1.Controls.Add(productTxt);
            panel1.Controls.Add(price);
            panel1.Controls.Add(name);
            panel1.Location = new Point(1025, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 198);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Salmon;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = SystemColors.ActiveCaptionText;
            addBtn.Location = new Point(142, 148);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(83, 35);
            addBtn.TabIndex = 4;
            addBtn.Text = "Ekle";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // priceTxt
            // 
            priceTxt.BackColor = Color.LightGray;
            priceTxt.Location = new Point(168, 96);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(168, 27);
            priceTxt.TabIndex = 3;
            // 
            // productTxt
            // 
            productTxt.BackColor = Color.LightGray;
            productTxt.Location = new Point(168, 44);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(168, 27);
            productTxt.TabIndex = 2;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(21, 101);
            price.Name = "price";
            price.Size = new Size(124, 18);
            price.TabIndex = 1;
            price.Text = "Product Price :";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(21, 49);
            name.Name = "name";
            name.Size = new Size(128, 18);
            name.TabIndex = 0;
            name.Text = "Product Name :";
            // 
            // tutarLabel
            // 
            tutarLabel.AutoSize = true;
            tutarLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tutarLabel.Location = new Point(119, 531);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new Size(0, 23);
            tutarLabel.TabIndex = 11;
            tutarLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // open_closeBtn
            // 
            open_closeBtn.BackColor = Color.LightGray;
            open_closeBtn.FlatAppearance.BorderColor = SystemColors.Info;
            open_closeBtn.FlatAppearance.BorderSize = 0;
            open_closeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            open_closeBtn.FlatStyle = FlatStyle.Flat;
            open_closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            open_closeBtn.ForeColor = Color.Red;
            open_closeBtn.Location = new Point(1218, 90);
            open_closeBtn.Name = "open_closeBtn";
            open_closeBtn.Size = new Size(170, 40);
            open_closeBtn.TabIndex = 13;
            open_closeBtn.Text = "ürün ekleme kapalı";
            open_closeBtn.UseVisualStyleBackColor = false;
            open_closeBtn.Click += open_closeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dontConfirmPicture);
            panel2.Controls.Add(ConfirmBtn);
            panel2.Controls.Add(confirmPicture);
            panel2.Controls.Add(sonTutar);
            panel2.Controls.Add(newCustomerBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(krediRadio);
            panel2.Controls.Add(nakitRadio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(sepetBaslik);
            panel2.Controls.Add(urunBaslik);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(tutarLabel);
            panel2.Controls.Add(open_closeBtn);
            panel2.Controls.Add(sepetTutarıLabel);
            panel2.Controls.Add(sepetList);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(receiptBtn);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(btnHesapla);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tutar);
            panel2.Controls.Add(btnSepeteEkle);
            panel2.Location = new Point(246, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(1405, 737);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1405, 49);
            panel3.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_close_48;
            pictureBox1.Location = new Point(1353, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 49);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dontConfirmPicture
            // 
            dontConfirmPicture.Image = Properties.Resources.close_32;
            dontConfirmPicture.Location = new Point(834, 520);
            dontConfirmPicture.Name = "dontConfirmPicture";
            dontConfirmPicture.Size = new Size(32, 32);
            dontConfirmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            dontConfirmPicture.TabIndex = 25;
            dontConfirmPicture.TabStop = false;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.LimeGreen;
            ConfirmBtn.FlatStyle = FlatStyle.Popup;
            ConfirmBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmBtn.Location = new Point(880, 516);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(105, 35);
            ConfirmBtn.TabIndex = 24;
            ConfirmBtn.Text = "Onayla";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += confirmBtn_Click;
            // 
            // confirmPicture
            // 
            confirmPicture.Image = Properties.Resources.confirm_32;
            confirmPicture.Location = new Point(834, 520);
            confirmPicture.Name = "confirmPicture";
            confirmPicture.Size = new Size(32, 32);
            confirmPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            confirmPicture.TabIndex = 23;
            confirmPicture.TabStop = false;
            confirmPicture.Visible = false;
            // 
            // sonTutar
            // 
            sonTutar.AutoSize = true;
            sonTutar.Font = new Font("Bahnschrift", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sonTutar.ForeColor = SystemColors.ActiveCaptionText;
            sonTutar.Location = new Point(633, 579);
            sonTutar.Name = "sonTutar";
            sonTutar.Size = new Size(0, 21);
            sonTutar.TabIndex = 21;
            sonTutar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // newCustomerBtn
            // 
            newCustomerBtn.BackColor = Color.Khaki;
            newCustomerBtn.FlatStyle = FlatStyle.Popup;
            newCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newCustomerBtn.Location = new Point(880, 565);
            newCustomerBtn.Name = "newCustomerBtn";
            newCustomerBtn.Size = new Size(105, 35);
            newCustomerBtn.TabIndex = 20;
            newCustomerBtn.Text = "Yeni Müşteri";
            newCustomerBtn.UseVisualStyleBackColor = false;
            newCustomerBtn.Click += newCustomerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(532, 577);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 19;
            label4.Text = "Son Tutar:";
            // 
            // krediRadio
            // 
            krediRadio.AutoSize = true;
            krediRadio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            krediRadio.Location = new Point(726, 527);
            krediRadio.Name = "krediRadio";
            krediRadio.Size = new Size(102, 24);
            krediRadio.TabIndex = 18;
            krediRadio.TabStop = true;
            krediRadio.Text = "Kredi Kartı";
            krediRadio.UseVisualStyleBackColor = true;
            // 
            // nakitRadio
            // 
            nakitRadio.AutoSize = true;
            nakitRadio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nakitRadio.Location = new Point(633, 529);
            nakitRadio.Name = "nakitRadio";
            nakitRadio.Size = new Size(67, 24);
            nakitRadio.TabIndex = 17;
            nakitRadio.TabStop = true;
            nakitRadio.Text = "Nakit";
            nakitRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(532, 531);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 16;
            label3.Text = "Ödeme :";
            // 
            // sepetBaslik
            // 
            sepetBaslik.AutoSize = true;
            sepetBaslik.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sepetBaslik.ForeColor = Color.Salmon;
            sepetBaslik.Location = new Point(704, 69);
            sepetBaslik.Name = "sepetBaslik";
            sepetBaslik.Size = new Size(74, 31);
            sepetBaslik.TabIndex = 15;
            sepetBaslik.Text = "Sepet";
            // 
            // urunBaslik
            // 
            urunBaslik.AutoSize = true;
            urunBaslik.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            urunBaslik.ForeColor = Color.Salmon;
            urunBaslik.Location = new Point(133, 69);
            urunBaslik.Name = "urunBaslik";
            urunBaslik.Size = new Size(96, 31);
            urunBaslik.TabIndex = 14;
            urunBaslik.Text = "Ürünler";
            // 
            // sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1902, 953);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "sale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SATIŞ İŞLEMLERİ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dontConfirmPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)confirmPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button btnHesapla;
        private Label label2;
        private Label sepetTutarıLabel;
        private Button receiptBtn;
        private Label tutar;
        public ListBox listBox1;
        private Panel panel1;
        private Button addBtn;
        public TextBox priceTxt;
        public TextBox productTxt;
        private Label price;
        private Label name;
        private Button open_closeBtn;
        private Label tutarLabel;
        public Button btnSepeteEkle;
        public ListBox sepetList;
        private Panel panel2;
        private Label sepetBaslik;
        private Label urunBaslik;
        private Button newCustomerBtn;
        private Label label4;
        private RadioButton krediRadio;
        private RadioButton nakitRadio;
        private Label label3;
        public Label sonTutar;
        private Button ConfirmBtn;
        public PictureBox dontConfirmPicture;
        public PictureBox confirmPicture;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}