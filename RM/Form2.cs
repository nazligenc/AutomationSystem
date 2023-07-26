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
using Microsoft.IdentityModel.Logging;
using Microsoft.Identity.Client;

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


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button8.Visible = false;


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
         
            object a = button2.Tag;
            Butonsayac(button2.Tag);
           
           






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private HashSet<string> uniqueProductNames = new HashSet<string>(); //Hashset sınıfı elemanın sadece bir kez saklanmasına izin vermek için kullanıldı.
        private Dictionary<Button, int> buttonClickCounts = new Dictionary<Button, int>();

        

        public class UrunBilgisi
        {
            public string Ad { get; set; }
            public int Miktar { get; set; }
            public string Fiyat { get; set; }
            public decimal yenitoplam;
        }
        private List<UrunBilgisi> urunBilgileri = new List<UrunBilgisi>();

        private decimal toplam;
        public void Butonsayac(object y)
        {
           

            Button buttons = y as Button;

            SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");
            conn.Open();
            string qry = ($"SELECT urunadi,urunfiyati FROM operation WHERE urunID={y}");
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@ProductId", y);
            SqlDataReader reader = cmd.ExecuteReader();
            



            if (reader.Read())
            {
               
                string urunfiyati = reader["urunfiyati"].ToString();
                string urunAdi = reader["urunadi"].ToString();
              
                UrunBilgisi urunBilgi = new UrunBilgisi { Ad = urunAdi, Miktar = 1, Fiyat = urunfiyati }; 
                var Urun = urunBilgileri.Find(u => u.Ad == urunAdi);
                if (Urun != null) //listede ürün adı var mı diye kontrol ediyorum.
                {
                     
                    Urun.Miktar++;
                  
                   


                }
                else
                {
                   
                    urunBilgileri.Add(urunBilgi); 
                }
                listBox1.Items.Clear();   //fazladan yazmayı kaldırmak için gerekli olan method.
                foreach (var urun in urunBilgileri)
                {
                    
                    listBox1.Items.Add(urun.Ad + "                " + urun.Miktar+ "        " +urun.Fiyat+ "TL");

                   

                }
                //toplama hesabı yapılırken kullandık.
                toplam += Convert.ToInt32(urunBilgi.Fiyat) * urunBilgi.Miktar;
                label1.Text = toplam.ToString();




                //toplama hesabı yaptıramadım önceki veriyi tutan değişkeni tanımalamak zor olduğu için değişken kullanamadım.Buna çalışıyorum. 
                //foreach (var urun in urunBilgileri)
                //{
                //    toplam = 0;
                //    decimal urunFiyati = Convert.ToDecimal(reader["urunfiyati"]);
                //    toplam=toplam+ urun.Miktar * urunFiyati;

                //    label1.Text = toplam.ToString()+"TL";






                //}
                reader.Close();
                conn.Close();

               
                
                

                             

              

























            }
        }

       
    

    


         

                    
                
                    
                
        
        


           

        
      
            


        



        private void button3_Click(object sender, EventArgs e)
        {
            
            object c = button3.Tag;
            
            Butonsayac(button3.Tag);
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(button4, null);
            
            object c = button4.Tag;
            Butonsayac(button4.Tag);
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        //listbox'tan verileri seçili veya tamamı şeklinde silme işlemi.
        private void button5_Click(object sender, EventArgs e)
        {
            
              
            listBox1.Items.Remove(listBox1.SelectedItem);
           Console.WriteLine( urunBilgileri.RemoveAll(urunBilgileri.Contains));//ürünleri silip başka ürün eklediğimde önceki silinen ürünler listbox'ta görünüyordu 
                                                                               //bu yüzden bunu kullandım.


           


        }
       
        private void button7_Click(object sender, EventArgs e)
        {

                listBox1.Items.Clear();
            Console.WriteLine(urunBilgileri.RemoveAll(urunBilgileri.Contains));



        }
        //burda parametreyle button'ları fonksiyonla alıyoruz.
        private void parametre(Button button)
        {
            SqlConnection conn = new SqlConnection("Data Source=NAZLI\\MSSQLSERVER01;Initial Catalog=RM;Integrated Security=True");
            conn.Open();


            string a3 = button.Tag.ToString();
            string qry = ($"SELECT uruntipi FROM operation WHERE urunID={a3}");
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine(a3);
            reader.Read();

            Console.WriteLine(reader["uruntipi"]);
            int a4 = "Yiyecek" == reader["uruntipi"].ToString() ? 0 : 1;

            if (comboBox1.SelectedIndex == a4)
            {

                button.Visible = true;

            }
            else
            {

                button.Visible = false;
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            parametre(button4);
            parametre(button2);
            parametre(button3);
            parametre(button8);





           
        }

        private void button8_Click(object sender, EventArgs e)
        {

            object c = button8.Tag;
            Butonsayac(button8.Tag);
            
           
            

        }
        

        private void button9_Click(object z, EventArgs e)
        {
         
            
            
            
           


























        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
 


