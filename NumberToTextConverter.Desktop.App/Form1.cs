using NumberToTextConverter.Core;

namespace NumberToTextConverter.Desktop.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal value = numericUpDown1.Value;
            var converter = new NumberConverter(value);
            richTextBox1.Text = converter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
