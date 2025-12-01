using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.mnuView.DropDownItems[0].Click += mnuView_Click; //Details
            this.mnuView.DropDownItems[1].Click += mnuView_Click; //List
            this.mnuView.DropDownItems[2].Click += mnuView_Click; //Small Icon
            this.mnuView.DropDownItems[3].Click += mnuView_Click; //Large Icon
            this.mnuView.DropDownItems[4].Click += mnuView_Click; //Tile

        }

        private TextBox GetTxtFirstName()
        {
            return txtFirstName;
        }

        private void btnAddName_Click(object sender, EventArgs e )
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFirstName.Text); 
            it.SubItems.Add(txtPhone.Text);
            listView1.Items.Add(it);
            it.ImageIndex = 0;
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            switch (item.Text)
            {
                case "Details":
                    listView1.View = View.Details;
                    lblView.Text = "Details";
                    break;
                case "List":
                    listView1.View = View.List;
                    lblView.Text = "List";
                    break;
                case "Small Icon":
                    listView1.View = View.SmallIcon;
                    lblView.Text = "Small Icon";
                    break;
                case "Large Icon":
                    listView1.View = View.LargeIcon;
                    lblView.Text = "Large Icon";
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    lblView.Text = "Tile";
                    break;
            }
        }

        private void mnuFormatListView_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                listView1.BackColor = colorDialog.Color;
            }
        }
    }
}
