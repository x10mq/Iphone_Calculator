namespace WinFormsApp5
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string Calculato;
        int num1;
        int num2;
        string options;
        int result;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonAll(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            options = "+";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            options = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            options = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            options = "/";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text);

            if (options.Equals("+"))
                result = num1 + num2;
            if (options.Equals("-"))
                result = num1 - num2;
            if (options.Equals("*"))
                result = num1 * num2;
            if (options.Equals("/"))
                result = num1 / num2;
            txtDisplay.Text = result + " ";


        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}