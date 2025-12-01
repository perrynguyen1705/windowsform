using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDFB2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void tvDSTen_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Bai5_Load(object sender, EventArgs e)
        {

            for (int i = 65; i <= 90; i++)
            {
                string kt = ((char)i).ToString();
                tvDSTen.Nodes.Add(kt, kt);
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            String key = txtFirstName.Text.Trim()[0].ToString();
            tvDSTen.Nodes[key].Nodes.Add(txtFirstName.Text + "," + txtLastName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
