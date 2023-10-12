namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        string option;
        double num1;
        double num2;
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // for right align text inside a TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnTopla_Click_1(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnCýkar_Click_1(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnBol_Click_1(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnCarp_Click_1(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnSonuc_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (option)
            {
                case "+":
                    total = num1 + num2;

                    break;
                case "-":
                    total = num1 - num2;
                    break;

                case "*":
                    total = num1 * num2;
                    break;

                //case "/":
                //    total = num1 / num2;
                //    break;

                default:
                    MessageBox.Show("Bir þeyler yanlýþ gitti!");
                    break;
            }
            try
            {
                if (option == "/")
                {
                    total = num1 / num2;
                }
            }
            catch (DivideByZeroException)
            {
                //throw;

            }
            textBox1.Text = total.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            total = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}