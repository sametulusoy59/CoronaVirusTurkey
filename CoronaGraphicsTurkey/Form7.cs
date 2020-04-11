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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select Top 1 Toplamiyilesensayisi,Gün From corona ORDER BY id Desc", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                chart1.Series["İyileşen Hasta Sayısı"].Points.AddXY(oku[1].ToString(), oku[0].ToString());
                textBox1.Text = oku[0].ToString();
            }


            con.Close();

            con.Open();
            SqlCommand komut2 = new SqlCommand("Select Top 1 Toplamolensayisi,Gün From corona Order By id Desc", con);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                chart1.Series["Ölen Hasta Sayısı"].Points.AddXY(oku2[1].ToString(), oku2[0].ToString());
                textBox2.Text = oku2[0].ToString();
            }
            con.Close();

            int a, b, c,d,f;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();
            d=a * 100 / c;
            f=100-d;

            richTextBox1.Text = "Sağlık Bakanlığı Verilerine Göre Sonuçlanan " + c + " Vakanın yaklaşık %" + d + " kadarı iyileşirken %" + f + " kadarı vefat etmiştir.";
        }
    }
}
