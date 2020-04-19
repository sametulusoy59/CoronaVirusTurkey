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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void Form10_Load(object sender, EventArgs e)
        {
            double sonuc,ilkdeger, sondeger;
            
            this.chart1.Titles.Add("Vaka Artış Hızı");
            con.Open();
            SqlCommand komut = new SqlCommand("Select Gün,GünlükVaka,ToplamVaka From corona Order By id Asc", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ilkdeger = Convert.ToInt32(oku[1]);
                sondeger = Convert.ToInt32(oku[2]);

                sonuc=(ilkdeger/sondeger)*100;
                sonuc = Math.Round(sonuc, 0);
                chart1.Series["Vaka Artış Hızı"].Points.AddXY(oku[0].ToString(), sonuc.ToString());
            }
            con.Close();
        }

       
        
    }
}
