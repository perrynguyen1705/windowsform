using System.Runtime.CompilerServices;

namespace WDFB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 10;


        void NewMethod()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

        }

        private void BTnpause_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = i.ToString();
            i--;
            if (i < 0)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("Hết giờ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                i = result;
            }
        }
    }
}
