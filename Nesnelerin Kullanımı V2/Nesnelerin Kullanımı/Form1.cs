using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesnelerin_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam, sonuc, fiyat, adet;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cpu");
            comboBox1.Items.Add("Gpu");
            comboBox1.Items.Add("Psu");
            comboBox1.Items.Add("Anakart");
            comboBox1.Items.Add("Monitör");
            comboBox1.Items.Add("Masa");
            comboBox1.Items.Add("Mouse");
        }
        int topp;
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Add(textBox1.Text);
            listView1.Items[x].SubItems.Add(textBox2.Text);
            listView1.Items[x].SubItems.Add(comboBox1.Text);
            listView1.Items[x].SubItems.Add(textBox3.Text);
            listView1.Items[x].SubItems.Add(textBox4.Text);
            fiyat = Convert.ToInt32(textBox3.Text);
            adet = Convert.ToInt32(textBox4.Text);


            topp = adet * fiyat;
            listView1.Items[x].SubItems.Add(topp.ToString());

            topp = adet * fiyat;
            if (radioButton1.Checked == true)
            {
                sonuc = (topp * 10) / 100;
                toplam = topp - sonuc;

                listView1.Items[x].SubItems.Add(toplam.ToString());

            }
            else if (radioButton2.Checked == true)
            {
                sonuc = (topp * 5) / 100;
                toplam = sonuc + topp;
                listView1.Items[x].SubItems.Add(toplam.ToString());

            }
            else if (radioButton3.Checked == true)
            {
                sonuc = (topp * 3) / 100;
                toplam = sonuc + topp;

                listView1.Items[x].SubItems.Add(toplam.ToString());
            }



            if (checkBox1.Checked == true)
            {

                listView1.Items[x].SubItems.Add(checkBox1.Text);

            }
            if (checkBox2.Checked == true)
            {

                listView1.Items[x].SubItems.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {

                listView1.Items[x].SubItems.Add(checkBox3.Text);
            }
            /*     if ((checkBox1.Checked == true) && (checkBox2.Checked == true)) 
                {
                    listView1.Items[x].SubItems.Add(checkBox1.Text);
                    listView1.Items[x].SubItems.Add(checkBox2.Text);

                }
                if ((checkBox2.Checked == true) && (checkBox3.Checked == true)) 

                {
                    listView1.Items[x].SubItems.Add(checkBox2.Text);
                    listView1.Items[x].SubItems.Add(checkBox3.Text);
                }
                if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                     listView1.Items[x].SubItems.Add(checkBox1.Text);
                    listView1.Items[x].SubItems.Add(checkBox3.Text);
                }*/

            x++;

        }
    }
}
