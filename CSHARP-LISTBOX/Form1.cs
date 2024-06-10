using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_LISTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbsTên.Items.Add("Nguyễn Văn Duy\tKhang");
            lbsTên.Items.Add("Nguyễn Hoàng\tTuấn");

        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            lbsTên.Items.Add(txtName.Text);
            txtName.Text = string.Empty;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbsTên.Items.RemoveAt(lbsTên.SelectedIndex);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lbsTên.SelectedIndex < 0) return;
            lbsTên.Items[lbsTên.SelectedIndex] = txtName.Text;
        }
    }
}
