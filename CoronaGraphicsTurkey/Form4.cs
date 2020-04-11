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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Toplam İyileşen ve Ölen İnsan Sayısı");
            con.Open();
            SqlCommand komut = new SqlCommand("Select Gün,Toplamiyilesensayisi From corona", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                chart1.Series["Toplam İyileşen Sayısı"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            con.Close();

            con.Open();
            SqlCommand komut2 = new SqlCommand("Select Gün,Toplamolensayisi From corona", con);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                chart1.Series["Toplam Ölen Sayısı"].Points.AddXY(oku2[0].ToString(), oku2[1].ToString());
            }
            con.Close();
        }
    }
}
