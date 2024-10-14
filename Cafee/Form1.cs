namespace Cafee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double cake = 5.32;
        double cola = 1.23;
        double ju = 2.87;
        double brgr = 6.47;
        double snd = 5.12;
        double pza = 12.38;
        double cpck = 3.98;
        double htdg = 7.45;
        double cks = 15.32;
        double total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text + " Removed");
            listBox1.Items.Remove(listBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label7.Text = "";
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cake - "+cake+" Azn");
            total += cake;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cola - "+ cola+" Azn");
            total+=cola;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Juice - " +ju+" Azn");
            total += ju;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - "+brgr+" Azn");
            total += brgr;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sandwich - "+snd+" Azn");
            total += snd;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza - "+pza+" Azn");
            total += pza;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cup cake - "+cpck+" Azn");
            total += cpck;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hot dog - "+htdg+" Azn");
            total += htdg;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cookies - "+cks+" Azn");
            total += cks;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ntc=total.ToString();
            label7.Text= string.Format("{0:0.00}", ntc+" Azn");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double cvt = double.Parse(maskedTextBox1.Text);
            if (cvt < total)
            {
                MessageBox.Show("The amount is small");
            }
            double bill = cvt - total;
            string bill_s= bill.ToString();
            textBox1.Text = string.Format("{0:0.00}", bill_s); 
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 120)
            {
                Form1 fr=new Form1();   
                this.Close();
            }
            textBox2.Text=i.ToString();
        }
        
        private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }
    }
}