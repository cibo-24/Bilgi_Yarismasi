using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_Bilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Global Alan

        int dogru = 0;
        int yanlis = 0;
        int sorusayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttone.Enabled = true;
            btnsonraki.Enabled = false;


            pictureBox1.Visible = false;
            pictureBox2.Visible= false;

            sorusayisi++;
            lblsoruno.Text = sorusayisi.ToString();

            if (sorusayisi == 1)
            {
                richTextBox1.Text = "Atatürk Kaç Yılında Doğmuştur?";
                buttona.Text = "1881";
                buttonb.Text = "1885";
                buttonc.Text = "1890";
                buttond.Text = "1876";
                buttone.Text = "1938";
                labelcevap.Text = "1881";

            }

            if (sorusayisi==2)
            {
                richTextBox1.Text = "Atatürk Hangi Tarihte Ölmüştür";
                buttona.Text = "1881";
                buttonb.Text = "1948";
                buttonc.Text = "1938";
                buttond.Text = "1939";
                buttone.Text = "1924";
                labelcevap.Text = "1938";

            }

            if (sorusayisi==3)
            {
                richTextBox1.Text = "Atatürk Kaç Yılında Samsuna Çıktı";
                buttona.Text = "1920";
                buttonb.Text = "1921";
                buttonc.Text = "1923";
                buttond.Text = "1929";
                buttone.Text = "1919";
                labelcevap.Text = "1919";
            }
            if (sorusayisi==4)
            {
                richTextBox1.Text = "Atatürk'ün Babasının Adı Nedir?";
                buttona.Text = "Mustafa Ali";
                buttonb.Text = "Ali Rıza Mustafa";
                buttonc.Text = "Rıza Atatürk";
                buttond.Text = "Mustafa Paşa";
                buttone.Text = "Ali Rıza Bey";
                labelcevap.Text = "Ali Rıza Bey";


            }
            if (sorusayisi==5)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edildi";
                buttona.Text = "1934";
                buttonb.Text = "1923";
                buttonc.Text = "1920";
                buttond.Text = "1939";
                buttone.Text = "1940";
                labelcevap.Text = "1923";
            }
            if (sorusayisi==6) 
            {
                richTextBox1.Text = "Atatürk'ün Annesinin Adı Nedir?";
                buttona.Text = "Zübeyde Hanım";
                buttonb.Text = "Zübeyir Hanım";
                buttonc.Text = "Fatma Hanım";
                buttond.Text = "Zeynep Hanım";
                buttone.Text = "Aliye Hanım";
                labelcevap.Text = "Zübeyde Hanım";

             }
            if (sorusayisi==7)
            {
                richTextBox1.Text = ("Doğru Sayısı:" + dogru + "\n" + "Yanlış Sayısı:" + yanlis);
                btnsonraki.Text = "Sonuçlar";

                buttona.Enabled= false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttone.Enabled = false;
                btnsonraki.Enabled = false;
            }

        }

        private void buttona_Click(object sender, EventArgs e)
        {

            buttona.Enabled=false;
            buttonb.Enabled=false;
            buttonc.Enabled=false;
            buttond.Enabled=false;
            buttone.Enabled=false;
            btnsonraki.Enabled = true;


            labelkullanıcıverisi.Text = buttona.Text;                  // Cevapların olduğu veriyi A butonuna yazdırdık.

            if (labelkullanıcıverisi.Text==labelcevap.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();         // labeldogru'ya dogru değişkenini yazdırdık. Doğru yazdıkça labeldogru'ya yazdırılacak.
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            btnsonraki.Enabled = true;



            labelkullanıcıverisi.Text = buttonb.Text;
            if (labelcevap.Text==labelkullanıcıverisi.Text)

            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis++;
                labelyanlis.Text= yanlis.ToString();    
                pictureBox2.Visible = true;
            }


        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            btnsonraki.Enabled = true;


            labelkullanıcıverisi.Text = buttonc.Text;
            if (labelcevap.Text==labelkullanıcıverisi.Text)
            {
                dogru++;
                labeldogru.Text= dogru.ToString();
                pictureBox1.Visible = true; 


            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible= true;
            }



        }

        private void buttond_Click(object sender, EventArgs e)
        {

            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            btnsonraki.Enabled = true;

            labelkullanıcıverisi.Text = buttond.Text;
            if (labelcevap.Text == labelkullanıcıverisi.Text) 
            {
                dogru++;
                labeldogru.Text=dogru.ToString();
                pictureBox1.Visible=true;
            }

            else
            {
                yanlis++;
                labelyanlis.Text=yanlis.ToString();
                pictureBox2.Visible=true;
            }

        }

        private void buttone_Click(object sender, EventArgs e)
        {

            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttone.Enabled = false;
            btnsonraki.Enabled = true;
            


            labelkullanıcıverisi.Text = buttone.Text;
            if (labelcevap.Text==labelkullanıcıverisi.Text)
            {

                dogru++;
                labeldogru.Text=dogru.ToString() ;
                pictureBox1.Visible=true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text=yanlis.ToString() ;
                pictureBox2.Visible=true;
            }

        }
    }
}
