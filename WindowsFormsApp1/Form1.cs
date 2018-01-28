using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 3;


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string u, p;
            u = txtusername.Text;
            p = txtpassword.Text;
            if (u == "alperjoo" && p == "34108034698")
                MessageBox.Show("Giriş Onaylandı");
            else
            {
                MessageBox.Show("Yanlış girdiniz");
                hak--;

            }
            if (hak == 0)
            {
                txtpassword.Enabled = false;
                txtusername.Enabled = false;
                btnlogin.Enabled = false;
                     }
        }

        private void pctexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
    

