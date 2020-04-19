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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void Form9_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Günlük Vaka Sayısı");
            con.Open();
            SqlCommand komut = new SqlCommand("Select Gün,GünlükVaka From corona Order By id Asc", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Günlük Vaka Durumu"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            con.Close();
        }
    }
}
