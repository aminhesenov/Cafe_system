namespace Cafe_system
{
    public partial class Form1 : Form
    {
        double tort = 2.5;
        double burger = 5.3;
        double sand = 3.6;
        double htdg = 4.2;
        double pizza = 12.87;
        double cake = 6.22;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort");
            total += tort;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text + " səbətdən silindi");
            listBox1.Items.Remove(listBox1.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k1.png";
            pictureBox2.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k4.png";
            pictureBox3.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k5.png";
            pictureBox4.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k6.png";
            pictureBox5.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k7.png";
            pictureBox6.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k8.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k2.png";
            pictureBox2.ImageLocation = "C:\\Users\\aminh\\OneDrive\\İş masası\\img\\k3.png";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger");
            total += burger;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sandwich");
            total += sand;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hotdog");
            total += htdg;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cake");
            total += cake;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza");
            total += pizza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text=total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (double.Parse(maskedTextBox1.Text) < total)
            {
                MessageBox.Show("Yetərsiz məbləğ");
            }
            else
            {
                double h = double.Parse(maskedTextBox1.Text) - total;
                label7.Text = h.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}