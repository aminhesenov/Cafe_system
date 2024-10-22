namespace Cafee
{
    public partial class Form1 : Form
    {
        double cake = 3.8;
        double cola = 1.8;
        double juice = 3.1;
        double burger = 6.27;
        double sandwich = 4.99;
        double pizza = 9.65;
        double cup_cake = 2.3;
        double hot_dog = 2.5;
        double cookie = 1.79;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbət boşdur!");
            }
            else
            {
                MessageBox.Show(listBox1.Text + " Səbətdən silindi!");
                listBox1.Items.Remove(listBox1.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            textBox2.Text = i.ToString();
            if (i == 120)
            {
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cake: " + cake + " Azn");
            total += cake;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cola: " + cola + " Azn");
            total += cola;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Juice: " + juice + " Azn");
            total += juice;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger: " + burger + " Azn");
            total += burger;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sandwich: " + sandwich + " Azn");
            total += sandwich;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza: " + pizza + " Azn");
            total += pizza;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cupcake: " + cup_cake + " Azn");
            total += cup_cake;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hotdog: " + hot_dog + " Azn");
            total += hot_dog;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cookie: " + cookie + " Azn");
            total += cookie;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbət boşdur!");
            }
            else
            {
                string.Format("{0:0.00}", total);

                textBox1.Text = total.ToString() + " Azn";

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty)
            {
                errorProvider1.SetError(maskedTextBox1, "Qiymət daxil edin!");
            }
            else
            {
                errorProvider1.Clear();
                double amount = double.Parse(maskedTextBox1.Text);
                if (amount < total)
                {
                    MessageBox.Show("Yetərsiz məbləğ daxil etdiniz!");
                }
                else
                {
                    double current = amount - total;
                    string.Format("{0:0.00}", current);
                    textBox3.Text = current.ToString() + " Azn";

                }
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
            total = 0;
        }
       
        private void pictureBox11_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Proqram bağlansınmı?",
                           "Tətbiq bildirişi",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
