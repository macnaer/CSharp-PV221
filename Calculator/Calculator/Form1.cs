namespace Calculator
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        double result = 0;
        string sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // %
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // *
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // -
        }

        private void button15_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            if (sign == "+")
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            textBox1.Text = "";
        }
    }
}