namespace Sozdanie2form
{
    public partial class Form1 : Form
    {
        private Form2 form = new();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new();
            form.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (form.isclick)
            {
                label1.Text = form.T_R_A_V();
            }
        }
    }
}