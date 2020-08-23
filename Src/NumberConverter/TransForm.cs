using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class TransForm : Form
    {
        public TransForm()
        {
            InitializeComponent();
        }

        private void TransForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("是否退出?");

            e.Cancel = false;
        }
    }
}
