namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSoA_31_Khang_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int soA = int.Parse(txtSoA.Text);
            int soB = int.Parse(txtSoB.Text);
            int tong= soA + soB;
            lblKQ.Text = String.Format("Ket qua: {0}", tong);
        }
    }
}
