using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (MainClass.IsValidUser(txtUser.Text, txtPass.Text)==false)
        //    {
        //        frmErrorMessage frmerror = new frmErrorMessage();
        //        frmerror.ShowDialog();
                


        //    }
        //    else
        //    {
                
              
                
                


        //    }
            
              

        //    }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                frmErrorMessage frmerror = new frmErrorMessage();
                frmerror.ShowDialog();
                


            }
            else
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
               
           


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

