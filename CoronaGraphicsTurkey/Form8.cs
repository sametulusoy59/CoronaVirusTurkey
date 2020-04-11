using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CoronaGraphicsTurkey
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int toplamvaka, toplamtest, toplamolen, toplamiyilesen,gun,gunlukvaka,gunluktest,gunlukolen,gunlukiyilesen;
            con.Open();
            SqlCommand komut = new SqlCommand("Select Top 1 ToplamVaka,Gün From corona ORDER BY id Desc", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                toplamvaka = Convert.ToInt32(oku[0]);
                textBox1.Text = toplamvaka.ToString();
            }

            
            con.Close();

            con.Open();
            SqlCommand komut2 = new SqlCommand("Select Top 1 Toplamtestsayisi,Gün From corona Order By id Desc", con);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                toplamtest = Convert.ToInt32(oku2[0]);
                textBox6.Text = toplamtest.ToString();
            }
            con.Close();

            con.Open();
            SqlCommand komut3 = new SqlCommand("Select Top 1 Toplamiyilesensayisi,Gün From corona ORDER BY id Desc", con);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {

                toplamiyilesen = Convert.ToInt32(oku3[0]);
                textBox7.Text = toplamiyilesen.ToString();
            }


            con.Close();

            con.Open();
            SqlCommand komut4 = new SqlCommand("Select Top 1 Toplamolensayisi,Gün From corona Order By id Desc", con);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                toplamolen = Convert.ToInt32(oku4[0]);
                textBox8.Text = toplamolen.ToString();
            }
            con.Close();

            con.Open();
            SqlCommand komut5 = new SqlCommand("Select Top 1 Gün From corona Order By id Desc", con);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                gun = Convert.ToInt32(oku5[0]);
                textBox9.Text = gun.ToString();
            }
            con.Close();

            gun = Convert.ToInt32(textBox9.Text) + 1 ;

            toplamolen = Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox4.Text);

            toplamiyilesen = Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox3.Text);

            toplamvaka = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);

            toplamtest = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox5.Text);

            gunlukolen = Convert.ToInt32(textBox4.Text);

            gunlukiyilesen= Convert.ToInt32(textBox3.Text);

            gunlukvaka = Convert.ToInt32(textBox2.Text);

            gunluktest= Convert.ToInt32(textBox5.Text);



            con.Open();
            SqlCommand ekle = new SqlCommand("insert into corona (Gün,GünlükVaka,ToplamVaka,Gunlukiyilesensayisi,Toplamiyilesensayisi,Gunlukolensayisi,Toplamolensayisi,Gunluktestsayisi,Toplamtestsayisi) values ('" + gun.ToString() + "','" + gunlukvaka.ToString() + "','" + toplamvaka.ToString() + "','" + gunlukiyilesen.ToString() + "','" + toplamiyilesen.ToString() + "','" + gunlukolen.ToString() + "','" + toplamolen.ToString() + "','" + gunluktest.ToString() + "','" + toplamtest.ToString() + "' )", con);
            ekle.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kayıt Başarıyla Eklendi.");

            
            this.Close();
        }
    }
}
