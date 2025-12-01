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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[i];
                    row.Cells[0].Value = textBox1.Text;
                    row.Cells[1].Value = textBox2.Text;
                    row.Cells[2].Value = textBox3.Text;

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[i];
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (textBox1.Text == row.Cells[0].Value.ToString() &&
                    textBox2.Text == row.Cells[1].Value.ToString() &&
                    textBox3.Text == row.Cells[2].Value.ToString())
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
