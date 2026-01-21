namespace CalculaterProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 1 clicked!");
            txtCalculation.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculation.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculation.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculation.Text += "4";
        }
    }

}
