using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using System.IO;
using System.Web.UI.WebControls;
using System.Diagnostics.Eventing.Reader;


namespace RM
{
    public partial class frmoperation : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");

        void Goruntu()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM operation", conn);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;



        }
      


        public frmoperation()
        {

            InitializeComponent();
             

        }




        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("Delete FROM operation where urunAdi=@p1", conn);
            delete.Parameters.AddWithValue("@p1", textBox2.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi");
            conn.Close();


        }





        private void button4_Click(object sender, EventArgs e)
        {
            //buna basıldığında resim seçecek 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        public void button1_Click(object sender, EventArgs e)
        {
            //textBox'lara eklenen ürünleri gösteriyor.          
            conn.Open();
            Goruntu();
            string yol=txtResim.Text;

            if (!string.IsNullOrEmpty(txtResim.Text) && File.Exists(txtResim.Text))
            {
                SqlCommand cmd = new SqlCommand("insert into operation(urunAdi,urunFiyati,urunTipi,urunadedi,resim) values(@p1,@p2,@p3,@p4,@p5)", conn);
                cmd.Parameters.AddWithValue("@p1", textBox2.Text);
                cmd.Parameters.AddWithValue("@p2", textBox3.Text);
                cmd.Parameters.AddWithValue("@p3", comboBox1.Text);
                cmd.Parameters.AddWithValue("@p4", textBox1.Text);
                cmd.Parameters.AddWithValue("@p5", yol);

               
               
                
               



                cmd.ExecuteNonQuery();
                //string imagefile = Path.GetFileName(pictureBox1.ImageLocation);
                //string imagepath = Path.Combine(Application.StartupPath + "\\img\\" + imagefile);
                //File.Copy(pictureBox1.ImageLocation,imagepath, true);
            }
            conn.Close();

            MessageBox.Show("Ürün Eklendi");
          
           

            conn.Close();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("Update operation set urunFiyati=@p2,urunTipi=@p3 where urunAdi=@p1 ", conn);
            update.Parameters.AddWithValue("p1", textBox2.Text);
            update.Parameters.AddWithValue("p2", textBox3.Text);
            update.Parameters.AddWithValue("p3", comboBox1.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            conn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.operationTableAdapter.Fill(this.rMDataSet.operation);
            Goruntu();


        }



        private void frmoperation_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rMDataSet14.operation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.operationTableAdapter7.Fill(this.rMDataSet14.operation);
            // TODO: Bu kod satırı 'rMDataSet13.operation' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.operationTableAdapter6.Fill(this.rMDataSet13.operation);

            this.operationTableAdapter.Fill(this.rMDataSet.operation);





        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //bu kısımda iki kez tıklandığında görüntüleme işlemi yapıyoruz.
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();


        }
        
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
     
        
 

