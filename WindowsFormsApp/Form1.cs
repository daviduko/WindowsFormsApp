using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnChange.Text = txtName.Text;
        }

        private void lbxWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChange.Text = lbxWeek.Text;
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
