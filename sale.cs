using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benim_Bakkalım
{
    public partial class sale : Form
    {

        public sale()
        {
            InitializeComponent();
        }

        // DİZİLER: 

        String[] productName = new string[15];
        int[] productPrice = new int[15];
        int index = 0;

        /* fiş dizilerimiz -> productName ve productPrice dizilerinin listbox üzerinden
         seçilen indexteki elemanları topladığımız diziler.
        */

        String[] receiptProductName = new string[15];
        int[] receiptProductPrice = new int[15];
        int[] receiptAdet = new int[15];
        int receiptIndex = 0;





        // seçilen ürüneleri tuttan diziler:




        // fonksiyonlarımız:
        private void add() // ürün ekleme fonksiyonumuz:
        {



            productName[index] = productTxt.Text;
            productPrice[index] = Convert.ToInt16(priceTxt.Text);

            listBox1.Items.Add(productName[index] + " " + productPrice[index] + "₺");
            index++;

            productTxt.Clear();
            priceTxt.Clear();
        }
        private void open_close() // ürün ekleme panelinin açılıp kapanması
        {
            if (panel1.Visible == false)
            {

                panel1.Visible = true;
                open_closeBtn.ForeColor = Color.Green;
                open_closeBtn.Text = "ürün ekleme açık";

            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
                open_closeBtn.ForeColor = Color.Red;
                open_closeBtn.Text = "ürün ekleme kapalı";
            }
        }
        public void addToCard() //  sepete ekleme ve eklerken fiş listesini oluşturma
        {



            if (tutarLabel.Text != "")  // hesaplamadan sepete eklememk için
            {
                if (listBox1.SelectedIndex >= 0) // ürün seçmeden sepete eklenmemesi için
                {

                    tutarLabel.Text = ""; // ürünler kısmındaki tutar

                    int adet = ((int)numericUpDown1.Value);
                    int urunFiyatı = productPrice[listBox1.SelectedIndex];
                    string urun = productName[listBox1.SelectedIndex];
                    sepetList.Items.Add(urun + " " + adet + " x " + urunFiyatı + " = " + sonuc + "₺");


                    // seçilen ürünleri,fiyatları ve adetlerini fiş için başka diziye aktardık.
                    receiptProductName[receiptIndex] = urun;
                    receiptProductPrice[receiptIndex] = urunFiyatı;
                    receiptAdet[receiptIndex] = adet;
                    receiptIndex++;

                    // sepet kısmındaki toplam tutar:
                    sepetTutarı += sonuc;
                    sepetTutarıLabel.Text = sepetTutarı.ToString() + "₺";


                }
                else
                {
                    MessageBox.Show("lütfen ürün seçtikten sonra sepete ürün ekleyiniz");
                }
            }
            else
            {
                MessageBox.Show("lütfen tutarı hesaplamadan sepete ürün eklemeyin.Maazallah yanlış fiyat girilir");
            }
        }

        public void cutReceipt() // Fiş kesme fonksiyonumuz
        {



            var urunler = "";
            for (int i = 0; i < sepetList.Items.Count; i++)
            {
                urunler += receiptProductName[i] + " " + receiptAdet[i] +
                    " x " + receiptProductPrice[i] + "₺" + "\n";
            }

            Fis fis = new Fis();
            fis.Show();
            fis.dateLbl.Text = DateTime.Now.ToString();
            fis.FisUrun.Text = urunler;
            fis.fisToplamLbl.Text += sepetTutarı.ToString() + "₺";


        }

        // ürün ekleme
        private void addBtn_Click(object sender, EventArgs e)
        {
            add();

        }
        // ürün eklemeyi açıp-kapatma 
        private void open_closeBtn_Click(object sender, EventArgs e)
        {
            open_close();

        }


        int sonuc, sepetTutarı; 

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    sonuc = ((int)numericUpDown1.Value) * productPrice[listBox1.SelectedIndex];

                    tutarLabel.Text = sonuc.ToString() + "₺";




                }

                else
                {
                    MessageBox.Show("lütfen ürün seçiniz");
                }
            }
            else
            {
                MessageBox.Show("lütfen hesaplamadan önce ürün ekleyiniz !");

            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            addToCard(); // sepete ekleme
        }
        private void receiptBtn_Click(object sender, EventArgs e)
        {
            cutReceipt();
        }


        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (nakitRadio.Checked)
            {
                sepetTutarı += -5;
                sonTutar.Text = sepetTutarı.ToString() + "₺";
                confirmPicture.Visible = true;
                dontConfirmPicture.Visible = false;
                receiptBtn.Visible = true;

            }
            else if (krediRadio.Checked)
            {
                sepetTutarı += 5;
                sonTutar.Text = sepetTutarı.ToString() + "₺";
                confirmPicture.Visible = true;
                dontConfirmPicture.Visible = false;
                receiptBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("LÜTFEN ÖDEME YÖNTEMİNİZİ SEÇİNİZ!!!");
                dontConfirmPicture.Visible = true;
            }
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            sale newCustomer = new sale();
            newCustomer.Show();
            this.Close();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
