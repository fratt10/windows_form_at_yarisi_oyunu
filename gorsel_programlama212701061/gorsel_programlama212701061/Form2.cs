using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama212701061
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random a = new Random(); //Oluşturulan Random sayı oyuncuları ilerletmek için kullanılacak        
        int player1 = 0;
        int player2 = 0;
        int player3 = 0;
        int player4 = 0; //Oyuncular ve başlangıc puanları tanımlandı
        int x;   //random sayıyı atamak için oluşturduğumuz değer
        int oyuncuSay; // form1 den alınan parametreye eşitlemek için oluşturduk

        public Form2(int oyuncuSayisi)
        {
            oyuncuSay = oyuncuSayisi; // form1 den alınan parametreye oluşturduğumuz değişken atandı
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(oyuncuSay==2) // Girilen oyucu sayısı 2 olmasına  göre form tasarımı düzenlendi
            {        // başlatve sıfırla butonu haricinde bütün oyuncu butonları kapatıldı
                     //3 ve 4. oyuncuların butonları gizlendi
                     //3 ve 4. oyunculara ait resim ve paneller gizlendi
                button1_212701061.Enabled = false; 
                button2_212701061.Enabled = false;
                button3_212701061.Visible = false;
                button4_212701061.Visible = false;
                pictureBox3_212701061.Visible = false;
                pictureBox4_212701061.Visible = false;
                pictureBox7_212701061.Visible = false;
                pictureBox8_212701061.Visible = false;
                panel3_212701061.Visible = false;
                panel4_212701061.Visible = false;

            }
            else if (oyuncuSay == 3) // Girilen oyucu sayısı 3 olmasına  göre form tasarımı düzenlendi
            {
                // başlat ve sıfırla butonu haricinde bütün oyuncu butonları kapatıldı
                //4. oyuncunu  buton,resim ve paneli gizlendi
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Visible = false;
                pictureBox4_212701061.Visible = false;
                pictureBox8_212701061.Visible = false;
                panel4_212701061.Visible = false;
            }
            else// Girilen oyucu sayısı 4 olmasına  göre form tasarımı düzenlendi
            { //butonların sadece aktifliği kapatıldı
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           button1_212701061.Enabled = true; // oyuna başlandıve 1. oyuncunu  butonu aktif edildi
           button5_212701061.Enabled = false;  // başla butonu kapatıldı 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //x değişkenine oluşturduğumuz x random sayısını atıyoruz
            x = a.Next(60, 100);
            //at resimlerini ilertmek için x değişkenini player a atadık ki değeri sürekli artsın
            player1 += x;
            pictureBox1_212701061.Left += x;

            //random sayıyla oyuncu ilerletildi, oyuncu ikinin butonu aktif edildi
            button2_212701061.Enabled = true;
            button1_212701061.Enabled = false;

            //player1 değeri 620 olunca döngüye girer
            if(player1>=620)
            {
                //oyuncu1 in kazandığı bildirilir
                MessageBox.Show("1.Oyuncu Kazandı");

                //başla butonu haricinde bütün butonlar pasif olur ve oyun ilk konumuna geri döner
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Enabled = false;
                button5_212701061.Enabled = true;

                //sıfırla butonu ile aynı görevi görmektedir
                pictureBox1_212701061.Left = 0;
                pictureBox2_212701061.Left = 0;
                pictureBox3_212701061.Left = 0;
                pictureBox4_212701061.Left = 0;
                player1 = 0;
                player2 = 0;
                player3 = 0;
                player4 = 4;

            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //x değişkenine oluşturduğumuz x random sayısını atıyoruz
            x = a.Next(60, 100);
            //at resimlerini ilertmek için x değişkenini player a atadık ki değeri sürekli artsın
            player2 += x;
            pictureBox2_212701061.Left += x;
            button2_212701061.Enabled = false;

            if (oyuncuSay==2)//oyuncu sayısı 2 olduğunda oyuncu1 in butonu aktif edilir
            {
                button1_212701061.Enabled = true;
            }
            else if(oyuncuSay>2)//oyuncu sayısı 3 veya 4 olduğunda 3. oyuncunun butonu aktif edilir
            {
                button3_212701061.Enabled = true;
            }
            if (player2 >= 620)
            {    //oyuncu2 nin kazandığı bildirilir
                MessageBox.Show("2.Oyuncu Kazandı");
                //başla butonu haricinde bütün butonlar pasif olur ve oyun ilk konumuna geri döner
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Enabled = false;
                button5_212701061.Enabled = true;
                //sıfırla butonu ile aynı görevi görmektedir
                pictureBox1_212701061.Left = 0;
                pictureBox2_212701061.Left = 0;
                pictureBox3_212701061.Left = 0;
                pictureBox4_212701061.Left = 0;
                player1 = 0;
                player2 = 0;
                player3 = 0;
                player4 = 4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = a.Next(60, 100);//x değişkenine oluşturduğumuz x random sayısını atıyoruz
            player3 += x;
            //at resimlerini ilertmek için x değişkenini player a atadık ki değeri sürekli artsın
            pictureBox3_212701061.Left += x;
            button3_212701061.Enabled = false;
            
             if (oyuncuSay == 3)//oyuncu sayısı 3 olduğunda oyuncu1 in butonu aktif edilir
            {
                button1_212701061.Enabled = true;
            }
             else if(oyuncuSay>3)//oyuncu sayısı4 olduğunda 1. oyuncunun butonu aktif edilir
            {
                button4_212701061.Enabled = true;
            }
            if (player3 >= 620)
            {
                //oyuncu3 ün kazandığı bildirilir
                MessageBox.Show("3.Oyuncu Kazandı");

                //başla butonu haricinde bütün butonlar pasif olur ve oyun ilk konumuna geri döner
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Enabled = false;
                button5_212701061.Enabled = true;
                //sıfırla butonu ile aynı görevi görmektedir
                pictureBox1_212701061.Left = 0;
                pictureBox2_212701061.Left = 0;
                pictureBox3_212701061.Left = 0;
                pictureBox4_212701061.Left = 0;
                player1 = 0;
                player2 = 0;
                player3 = 0;
                player4 = 4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = a.Next(60, 100);//x değişkenine oluşturduğumuz x random sayısını atıyoruz
            player4 += x;
            //at resimlerini ilertmek için x değişkenini player a atadık ki değeri sürekli artsın
            pictureBox4_212701061.Left += x;
            button4_212701061.Enabled = false;//oyuncu 4 ün butonu pasifleştirilip  oyuncu 1 in butonu aktif edildi
            button1_212701061.Enabled = true;
            if (player4 >= 620)
            {
                //oyuncu4 ün kazandığı bildirilir
                MessageBox.Show("4.Oyuncu Kazandı");

                //başla butonu haricinde bütün butonlar pasif olur ve oyun ilk konumuna geri döner
                button1_212701061.Enabled = false;
                button2_212701061.Enabled = false;
                button3_212701061.Enabled = false;
                button4_212701061.Enabled = false;
                button5_212701061.Enabled = true;
                //sıfırla butonu ile aynı görevi görmektedir
                pictureBox1_212701061.Left = 0;
                pictureBox2_212701061.Left = 0;
                pictureBox3_212701061.Left = 0;
                pictureBox4_212701061.Left = 0;
                player1 = 0;
                player2 = 0;
                player3 = 0;
                player4 = 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sıfırlama butonuna basınca bütün butonların aktifliğini pasif yapıyoruz
            button1_212701061.Enabled = false;
            button2_212701061.Enabled = false;
            button3_212701061.Enabled = false;
            button4_212701061.Enabled = false;
            button5_212701061.Enabled = true;
            //ve bütün resimlerin konumunu sıfırlıyoruz (en başa alıyoruz)
            pictureBox1_212701061.Left = 0;
            pictureBox2_212701061.Left = 0;
            pictureBox3_212701061.Left = 0;
            pictureBox4_212701061.Left = 0;
            //bütün oyuncuların ilerleme değerlerini sıfırlıyoruz
            player1 = 0;
            player2 = 0;
            player3 = 0;
            player4 = 4;
        }
    }
}
