using System.Diagnostics;

namespace Benim_Bakkalım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int deneme = 4;

        private void girisButon_Click(object sender, EventArgs e)
        {
            // ilk if inşaat süresi boyunca şifre girmemek için yapılmıştır.

        
            String userName = Kullanici.Text;
            int password = Convert.ToInt32(parola.Text);

       
            
                if (userName == "Admin" || userName == "ümit" && password == 3737)
                {
                    MessageBox.Show("Giriş Başarılı ");


                    sale sale2 = new sale();
                    sale2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    Kullanici.Text = "";
                    parola.Text = "";
                    deneme--;
                    MessageBox.Show(deneme + " deneme hakkınız kaldı");

                    if (deneme == 0)
                    {
                        MessageBox.Show("çok sayıda hatalı giriş yapılmıştır.Lütfen daha sonra tekrar deneyiniz");
                        Application.Exit();
                    }

                }
           
            
            


            


        }



        private void girisButon_MouseEnter(object sender, EventArgs e)
        {
            girisButon.BackColor = Color.White;
        }

        private void girisButon_MouseLeave(object sender, EventArgs e)
        {
            girisButon.BackColor = Color.Salmon;
        }


    }
}
