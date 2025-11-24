using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chuthuong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nhap_text.Clear();
        }

        private void ketqua_Click(object sender, EventArgs e)
        {
            if (chuthuong.Checked == true)
            {
                hienthikq.Text = nhap_text.Text.ToLower();
            }
            else if (chuthuong.Checked == false)
            {
                hienthikq.Text = nhap_text.Text.ToUpper();
            }
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
