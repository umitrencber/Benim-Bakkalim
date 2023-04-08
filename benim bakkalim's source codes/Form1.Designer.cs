namespace Benim_Bakkalım
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            girisButon = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            parola = new TextBox();
            Kullanici = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(girisButon);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(parola);
            panel1.Controls.Add(Kullanici);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(122, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 532);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // girisButon
            // 
            girisButon.BackColor = Color.Salmon;
            girisButon.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            girisButon.Location = new Point(539, 394);
            girisButon.Name = "girisButon";
            girisButon.Padding = new Padding(2);
            girisButon.Size = new Size(410, 53);
            girisButon.TabIndex = 4;
            girisButon.Text = "GİRİŞ";
            girisButon.UseVisualStyleBackColor = false;
            girisButon.Click += girisButon_Click;
            girisButon.MouseEnter += girisButon_MouseEnter;
            girisButon.MouseLeave += girisButon_MouseLeave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_password_lock_30;
            pictureBox5.Location = new Point(900, 322);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_user_30;
            pictureBox4.Location = new Point(900, 235);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_lock_68;
            pictureBox3.Location = new Point(694, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 49);
            panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = Properties.Resources.icons8_close_48;
            pictureBox2.Location = new Point(432, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 49);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // parola
            // 
            parola.Font = new Font("Courier New", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            parola.Location = new Point(539, 308);
            parola.Multiline = true;
            parola.Name = "parola";
            parola.PasswordChar = '*';
            parola.Size = new Size(410, 53);
            parola.TabIndex = 3;
            parola.Text = "\r\n";
            // 
            // Kullanici
            // 
            Kullanici.Font = new Font("Courier New", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Kullanici.Location = new Point(539, 224);
            Kullanici.MaxLength = 100;
            Kullanici.Multiline = true;
            Kullanici.Name = "Kullanici";
            Kullanici.Size = new Size(410, 53);
            Kullanici.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(539, 280);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 2;
            label2.Text = "Parola :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(539, 196);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullancı Adı :";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 532);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Premium_Vector___Man_character_confuse_with_question_mark_concept_illustration_in_flat_design;
            pictureBox1.Location = new Point(56, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1315, 903);
            ControlBox = false;
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1333, 950);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LOGİN";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox parola;
        private TextBox Kullanici;
        private Label label2;
        private Label label1;
        private Button girisButon;
    }
}