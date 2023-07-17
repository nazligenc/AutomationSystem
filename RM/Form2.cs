using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.Common;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using System.Diagnostics.Eventing.Reader;

namespace RM
{
    public partial class Form2 : Form
    {
    //  SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");
        
        List<Button> buttons = null;
       
            public Form2()
        {
            InitializeComponent();

            buttons = new List<Button>() { button2, button3, button4 };

            }
        int adet = 0;
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //parametreli method oluştur.
            object a=button2.Tag;
            ButonYazdırma(button2.Tag);
            adet++;





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public void ButonYazdırma(object x) { 
        
           SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");
            conn.Open();
            string qry = ($"SELECT urunadi,urunadedi,urunfiyati FROM operation WHERE urunID={x}");
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            

             //ListBox'a alt alta veri yazdırma
            if (reader.Read())
            {
                
                
                String a2 = "              "+ reader["urunadi"] + "                 " +adet.ToString()+"                "  + "                  " + reader["urunfiyati"];
                listBox1.Items.Add (a2);



                
            }

            reader.Close();


        }
        
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            object c = button3.Tag;
            ButonYazdırma(button3.Tag);
            adet++;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            object c = button4.Tag;
            ButonYazdırma(button4.Tag);
            adet++;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
            this.Hide(); 
        }
        //listbox'tan verileri seçili veya tamamı şeklinde silme işlemi.
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");
            conn.Open();
            foreach (Button button in buttons)
            {

                string a = button.Tag.ToString();
                string qry = ($"SELECT uruntipi FROM operation WHERE urunID={a}");
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows==true)
                {
                    reader.Close();  
                    if (comboBox1.SelectedIndex == 0)
                    {
                        string uruns = comboBox1.SelectedText;
                        string qry2 = ($"SELECT uruntipi FROM operation WHERE uruntipi={a}");
                        SqlCommand cmd2 = new SqlCommand(qry2, conn);
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        Console.WriteLine((string)reader2["uruntipi"]);
                    }
                    string c1 = "Yiyecek";
                    object cx = (object) c1;
                    //    string ac = (string)reader["uruntipi"];
                   // Console.WriteLine(ac);
                    if (reader["uruntipi"]==cx)
                    {

                            button.Visible = true;
                           Console.WriteLine("okuyor");

                    }
                    else

                    {
                        Console.WriteLine(comboBox1.SelectedIndex.GetType());
                       
                        Console.WriteLine(comboBox1.SelectedIndex);
                        button.Visible = false;
                        Console.WriteLine("else okuyor");

                    }
                }

                reader.Close(); 
            }  


            










            //  string a=button2.Tag.ToString();



            //string a2 = reader["uruntipi"].ToString();

            // if (comboBox1.SelectedIndex == 0)
            //{
            //    if (a == "YİYECEK")
            //    {
            //        button2.Visible = true;
            //    }
            //    else
            //    {
            //        button2.Visible = false;
            //    }

            //}
        }
        public void kontrol(ButtonBase buttony)
        {
            

        }

    }
}

