using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.DirectoryServices.ActiveDirectory;

namespace ev_tapsiriq_8_vefral_2
{
    public partial class Form2 : Form
    {
        int saniye = 600;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\Fairytale-melody.wav");
            Simple.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formatini deyismek isteyirsiniz?", "sual", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResult cavab = fontDialog1.ShowDialog();
                if (cavab == DialogResult.OK)
                {
                    textBox1.Font = fontDialog1.Font;
                }
                else
                {
                    MessageBox.Show("Tamam!");
                }
            }
            else
            {
                MessageBox.Show("Tamam");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formatini deyismek isteyirsiniz?", "sual", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResult cavab = fontDialog1.ShowDialog();
                if (cavab == DialogResult.OK)
                {
                    textBox2.Font = fontDialog1.Font;
                }
                else
                {
                    MessageBox.Show("Tamam!");
                }
            }
            else
            {
                MessageBox.Show("Tamam");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"D:\Fairytale-melody.wav");
            Simple.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formatini deyismek isteyirsiniz?", "sual", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResult cavab = fontDialog1.ShowDialog();
                if (cavab == DialogResult.OK)
                {
                    textBox1.Font = fontDialog1.Font;
                }
                else
                {
                    MessageBox.Show("Tamam!");
                }
            }
            else
            {
                MessageBox.Show("Tamam");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Formatini deyismek isteyirsiniz?", "sual", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResult cavab = fontDialog1.ShowDialog();
                if (cavab == DialogResult.OK)
                {
                    textBox2.Font = fontDialog1.Font;
                }
                else
                {
                    MessageBox.Show("Tamam!");
                }
            }
            else
            {
                MessageBox.Show("Tamam");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string yas = numericUpDown1.Value.ToString();
            ListViewItem lvi = new ListViewItem(new string[3] { name, surname, yas});
            listView1.Items.Add(lvi);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg File(*.jpeg)|*.jpeg | Png File(*.png)|*.png";
            openFileDialog1.InitialDirectory = @"D:\Fairytale-melody.jpeg";
            DialogResult cavab = openFileDialog1.ShowDialog();
            if (cavab == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);

            }
        }
        int i = 0;

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            saniye--;
            if (saniye < 600)
            {
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label6.Text = (saniye/60).ToString();
                label7.Text = (saniye%60).ToString();
            }
            if (saniye==300)
            {
                Application.Exit();
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            label6.Visible = false;
            label9.Visible = false;
            label7.Visible = false;
            timer1.Enabled = true;
        }
    }
}
