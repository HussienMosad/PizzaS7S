using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }
       
        private void lbOrder_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder();
            frm.ShowDialog();
        }
    }
}
