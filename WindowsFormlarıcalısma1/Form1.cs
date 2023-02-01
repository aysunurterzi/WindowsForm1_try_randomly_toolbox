using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlarıcalısma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydınız başarıyla eklenmiştir");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double sayi1=0, sayi2=0, sonuc=0;
            sayi1 = Convert.ToDouble(textBox2.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            sonuc = sayi1 + sayi2;
            label5.Text = Convert.ToString(sonuc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox2.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            sonuc = sayi1 - sayi2;
            label5.Text = Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox2.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            sonuc = sayi1 * sayi2;
            label5.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox2.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            sonuc = sayi1 / sayi2;
            label5.Text = Convert.ToString(sonuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                label8.Text = "Bay";
                label9.Text = "Evli";
            }
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                label8.Text = "Bay";
                label9.Text = "Bekâr";
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                label8.Text = "Bayan";
                label9.Text = "Evli";
            }

            else if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                label8.Text = "Bayan";
                label9.Text = "Bekâr";
            }
            else if (radioButton1.Checked == true )
            {
                label8.Text = "Bay"; 
            }
            else if (radioButton2.Checked == true)
            {
                label8.Text = "Bayan";
            }
            else if (radioButton3.Checked == true)
            {
                label9.Text = "Evli";
            }
            else if (radioButton4.Checked == true)
            {
                label9.Text = "Bekâr";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string hobiler = "";

            if (checkBox1.Checked == true)
            {
                hobiler = hobiler + checkBox1.Text + "," + Environment.NewLine ;
            }
            if (checkBox2.Checked == true)
            {
                hobiler = hobiler + checkBox2.Text + "," + Environment.NewLine;
            }
          
            if (checkBox3.Checked == true)
            {
                hobiler = hobiler + checkBox3.Text + "," + Environment.NewLine;
            }
            if (checkBox4.Checked == true)
            {
                hobiler = hobiler + checkBox4.Text + "," + Environment.NewLine;
            }
            if (checkBox5.Checked == true)
            {
                hobiler = hobiler + checkBox5.Text + "," + Environment.NewLine;
            }
            
            label11.Text = hobiler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
