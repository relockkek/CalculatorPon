namespace CalculatorPon
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void DotButtonClick(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
                return;
            textBox1.Text += ".";
        }

        string operation;
        double x;

        private void OpertionButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            double.TryParse(textBox1.Text, out x);
            textBox1.Text = "";
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {
            if (a >= 50)
            {
                double.TryParse(textBox1.Text, out double y);
                double result = y;
                switch (operation)
                {
                    case "%":
                        result = x % y;
                        break;

                    case "√":
                        result = Math.Sqrt(x);
                        break;

                    case "^":
                        result = Math.Pow(x, y);
                        break;
                    case "*":
                        result = x * y;
                        break;

                    case "+":
                        result = x + y;
                        break;

                    case "-":
                        result = x - y;
                        break;

                    case "/":
                        result = x / y;
                        break;
                }

                textBox1.Text = result.ToString();
                a = a - 50;
                textBox3.Text = "я все решил";
                textBox2.Text = $"{a}";
            }
            else
            {
                textBox3.Text = "ты бомж";
            }

        }
        private void stirka(object sender, EventArgs e)
        {
            textBox2.Text = "";
            a++;
            textBox2.Text += a;

        }
        private void ads(object sender, EventArgs e)
        {
            textBox2.Text = "";
            a = a + 10;
            textBox2.Text += a;

        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            a++;
            textBox2.Text += a;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
