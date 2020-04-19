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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");
        private void Form11_Load(object sender, EventArgs e)
        {
            int ToplamVaka, ToplamOlen, Toplamiyilesen,AktifVaka;
            con.Open();
            SqlCommand komut = new SqlCommand("Select  ToplamVaka,Toplamolensayisi,Toplamiyilesensayisi,Gün From corona ORDER BY id Asc", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ToplamVaka = Convert.ToInt32(oku[0]);
                ToplamOlen = Convert.ToInt32(oku[1]);
                Toplamiyilesen = Convert.ToInt32(oku[2]);
                AktifVaka = ToplamVaka - (ToplamOlen + Toplamiyilesen);
                chart1.Series["Aktif Vaka Sayısı"].Points.AddXY(oku[3].ToString(), AktifVaka.ToString());

            }

            con.Close();

        }
    }
}
