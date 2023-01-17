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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//sayı dışında girilen değerlerde catch e girip bildirim gösterilecek
            {
                int oyuncuSayisi = Convert.ToInt32(textBox1_212701061.Text);//girilen oyuncu sayısını oluşturduğum değişkene atadım
                Form2 frm = new Form2(oyuncuSayisi);//parametre oluşturup oyuncu ssayısını form 2 ye gönderdim
                if(1<oyuncuSayisi && oyuncuSayisi<5)//2,3 ve 4 değeri girildiğinde döngüye girip form 2 yi gösterdim
                {
                    frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Oyuncu Sayısı 2'den 4'e kadar olmalıdır");//2,3 veya 4 dışında bir sayı değeri girildiğinde bu mesaj metni gösterilir
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//sayı dışında bir veri girildiğinde döngüye girilip hata mesajı ekrana yazdırılır
            }
        }
    }
}
