using Azure;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel2.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.Show();
            this.Hide();
            hideSubMenu();
            

        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmoperation frm = new frmoperation();
            frm.Show();
            this.Hide();
            hideSubMenu();
            
            
        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            frmoperation frmo = new frmoperation();
            frmo.Show();
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }
        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle= FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag=childForm;
                childForm.BringToFront();
                childForm.Show();

            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
