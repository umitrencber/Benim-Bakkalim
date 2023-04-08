namespace Benim_Bakkalım
{
    partial class Fis
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
            panel1 = new Panel();
            exitBtn = new Button();
            FisUrun = new Label();
            alinanUrun = new Label();
            dateLbl = new Label();
            buyDate = new Label();
            adress = new Label();
            Baslik = new Label();
            cizik1 = new Label();
            fisToplamLbl = new Label();
            cizik2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cizik2);
            panel1.Controls.Add(fisToplamLbl);
            panel1.Controls.Add(cizik1);
            panel1.Controls.Add(Baslik);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(FisUrun);
            panel1.Controls.Add(alinanUrun);
            panel1.Controls.Add(dateLbl);
            panel1.Controls.Add(buyDate);
            panel1.Controls.Add(adress);
            panel1.Location = new Point(45, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 492);
            panel1.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = SystemColors.ActiveCaption;
            exitBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(259, 439);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(60, 40);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "OK";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // FisUrun
            // 
            FisUrun.AutoSize = true;
            FisUrun.Location = new Point(20, 211);
            FisUrun.Name = "FisUrun";
            FisUrun.Size = new Size(0, 20);
            FisUrun.TabIndex = 4;
            // 
            // alinanUrun
            // 
            alinanUrun.AutoSize = true;
            alinanUrun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            alinanUrun.Location = new Point(11, 177);
            alinanUrun.Name = "alinanUrun";
            alinanUrun.Size = new Size(115, 20);
            alinanUrun.TabIndex = 3;
            alinanUrun.Text = "Alınan Ürünler ";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Location = new Point(110, 110);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(0, 20);
            dateLbl.TabIndex = 2;
            // 
            // buyDate
            // 
            buyDate.AutoSize = true;
            buyDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buyDate.Location = new Point(11, 110);
            buyDate.Name = "buyDate";
            buyDate.Size = new Size(93, 20);
            buyDate.TabIndex = 1;
            buyDate.Text = "Satış Tarihi :";
            // 
            // adress
            // 
            adress.AutoSize = true;
            adress.Location = new Point(11, 78);
            adress.Name = "adress";
            adress.Size = new Size(284, 20);
            adress.TabIndex = 0;
            adress.Text = "Sülüntepe Mah. Şerit Sok. No :16. D : 6235";
            // 
            // Baslik
            // 
            Baslik.AutoSize = true;
            Baslik.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Baslik.ForeColor = SystemColors.ActiveCaptionText;
            Baslik.Location = new Point(47, 10);
            Baslik.Name = "Baslik";
            Baslik.Size = new Size(224, 35);
            Baslik.TabIndex = 6;
            Baslik.Text = "Benim Bakkalım A.Ş";
            // 
            // cizik1
            // 
            cizik1.AutoSize = true;
            cizik1.Location = new Point(11, 327);
            cizik1.Name = "cizik1";
            cizik1.Size = new Size(291, 40);
            cizik1.TabIndex = 7;
            cizik1.Text = "-----------------------------------------------\r\n\r\n";
            // 
            // fisToplamLbl
            // 
            fisToplamLbl.AutoSize = true;
            fisToplamLbl.Location = new Point(11, 347);
            fisToplamLbl.Name = "fisToplamLbl";
            fisToplamLbl.Size = new Size(83, 20);
            fisToplamLbl.TabIndex = 8;
            fisToplamLbl.Text = "TOPLAM = ";
            // 
            // cizik2
            // 
            cizik2.AutoSize = true;
            cizik2.Location = new Point(11, 367);
            cizik2.Name = "cizik2";
            cizik2.Size = new Size(291, 40);
            cizik2.TabIndex = 9;
            cizik2.Text = "-----------------------------------------------\r\n\r\n";
            // 
            // Fis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 541);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "Fis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label dateLbl;
        private Label buyDate;
        private Label adress;
        private Label alinanUrun;
        public Label FisUrun;
        private Button exitBtn;
        private Label label4;
        private Label Baslik;
        private Label cizik1;
        private Label cizik2;
        public Label fisToplamLbl;
    }
}