using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Builder_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); // sınıfımızı tanımladık.
             
            string kelime = textBox1.Text; // texte gelen değeri kelime değişkenine aldık.

            sb.Append(kelime); // append metodu ile sınıfımız içine kelime değişkenini dahil ettik.

            label4.Text = sb.Length.ToString(); // ve length metodu ile de ifadenin uzunluğunu bulduk.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb2 = new StringBuilder(); 

            string kelime2 = textBox2.Text;

            sb2.Append(kelime2);

            label5.Text = sb2.Capacity.ToString(); // capacity metodu ile değerimizi aldık.
            
        }

        StringBuilder sb3 = new StringBuilder(); // İki butondada ortak kullanacağımız için global tanımladım.

        private void button3_Click(object sender, EventArgs e)
        {
            // Kapasite Butonu

            string kelime3= textBox3.Text;

            sb3.Append(kelime3);

            label8.Text = sb3.Capacity.ToString(); // Öncelikle burada kapasite değerini bulduk.


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Oluştur Butonu

            int a = int.Parse(textBox4.Text); // istediğimiz kapasite değerini aldık.

            sb3.EnsureCapacity(a); // yeni kapasite değerini belirledik.

            label13.Text = sb3.Capacity.ToString(); // byu değeri yazdırdık.
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder sb4 = new StringBuilder();

            

            label17.Text = sb4.MaxCapacity.ToString();

        }

        
    }
}
