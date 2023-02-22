namespace ev_tapsiriq_8_vefral_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ad = "Amina";
        string password = "amina1234";
        private void button1_Click(object sender, EventArgs e)
        {
            if (ad == textBox1.Text && password == textBox2.Text)
            {
                MessageBox.Show("Duzgundur!");
            }
            else
            {
                MessageBox.Show("Duzgun deyil!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ad == textBox1.Text && password == textBox2.Text)
            {
                MessageBox.Show("Duzgundur!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Duzgun deyil!");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (ad == textBox1.Text && password == textBox2.Text)
            {
                MessageBox.Show("Duzgundur!");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Duzgun deyil!");
            }
        }
    }
}