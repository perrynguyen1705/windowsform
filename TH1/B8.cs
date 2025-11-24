using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Xoa_Click(object sender, EventArgs e)
        {
            inA.Clear();
            inB.Clear();
            outAB.Clear();
        }


        private void giai_Click(object sender, EventArgs e)
        {
            
            double A, B;
            bool isNumberA = double.TryParse((inA.Text), out  A);
            bool isnumberB = double.TryParse(inB.Text, out B);

            if ( !isNumberA || !isnumberB)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            outAB.Text = (-B / A).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inA.Text))
            {
               giai.Enabled = false;
                Xoa.Enabled =false;
            }
            else
            {
                giai.Enabled = true;
                Xoa.Enabled = true;
            }
        }

        private void inB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inA.Text))
            {
                giai.Enabled = false;
                Xoa.Enabled = false;
            }
            else
            {
                giai.Enabled = true;
                Xoa.Enabled = true;
            }
        }
    }
}
