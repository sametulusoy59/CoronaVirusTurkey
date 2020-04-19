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
using System.Net;
using HtmlAgilityPack;

namespace CoronaGraphicsTurkey
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public void gunlukdurum()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.UserAgent, "AvoidError");
                htmlCode = client.DownloadString("https://covid19.saglik.gov.tr/");
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(htmlCode);


            List<string> spanText = new List<string>();
            HtmlNodeCollection nodeCollection = doc.DocumentNode.SelectNodes("//div[@class='mtop-bosluk buyuk-bilgi-l']//ul");
            string testsayisi = doc.DocumentNode.SelectSingleNode("//span[@class='buyuk-bilgi-l-sayi']").InnerText;
            string vakasayisi = doc.DocumentNode.SelectSingleNode("//div[@class='mtop-bosluk buyuk-bilgi-l']/ul/li[@class='d-flex justify-content-between baslik-k-2 bg-koyu']/span[@class='']").InnerText;
            string vefatsayisi = doc.DocumentNode.SelectSingleNode("//div[@class='mtop-bosluk buyuk-bilgi-l']/ul/li[@class='d-flex justify-content-between baslik-k-2 bg-acik']/span[@class='']").InnerText;
            string iyilesensayisi = doc.DocumentNode.SelectSingleNode("//div[@class='mtop-bosluk buyuk-bilgi-l']/ul/li[@class='d-flex justify-content-between baslik-k-2 bg-acik']/following::span[@class=''][3]").InnerText;
            string gun = doc.DocumentNode.SelectSingleNode("//div[@class='takvim text-center']/p[@class='p1']").InnerText;
            string ay = doc.DocumentNode.SelectSingleNode("//div[@class='takvim text-center']/p[@class='p2']").InnerText;

            textBox2.Text = vakasayisi;
            textBox3.Text = iyilesensayisi;
            textBox4.Text = vefatsayisi;
            textBox5.Text = testsayisi;
            textBox10.Text = gun;





        }


        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {


           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            gunlukdurum();
            int songun, kayıtlıgun;
            songun = Convert.ToInt32(textBox10.Text);
            con.Open();
            SqlCommand sart = new SqlCommand("Select Top 1 tarihgun From corona ORDER BY id Desc", con);
            SqlDataReader sartıoku = sart.ExecuteReader();
            while (sartıoku.Read())
            {

                kayıtlıgun = Convert.ToInt32(sartıoku[0]);
                textBox1.Text = kayıtlıgun.ToString();
            }

            kayıtlıgun = Convert.ToInt32(textBox1.Text);
            if (songun != kayıtlıgun)
            {




                con.Close();


                int toplamvaka, toplamtest, toplamolen, toplamiyilesen, gun, gunlukvaka, gunluktest, gunlukolen, gunlukiyilesen, tarihgun;
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

                gun = Convert.ToInt32(textBox9.Text.Replace(".", "")) + 1;

                toplamolen = Convert.ToInt32(textBox8.Text.Replace(".","")) + Convert.ToInt32(textBox4.Text.Replace(".", ""));

                toplamiyilesen = Convert.ToInt32(textBox7.Text.Replace(".", "")) + Convert.ToInt32(textBox3.Text.Replace(".", ""));

                toplamvaka = Convert.ToInt32(textBox1.Text.Replace(".", "")) + Convert.ToInt32(textBox2.Text.Replace(".", ""));

                toplamtest = Convert.ToInt32(textBox6.Text.Replace(".", "")) + Convert.ToInt32(textBox5.Text.Replace(".", ""));

                gunlukolen = Convert.ToInt32(textBox4.Text.Replace(".", ""));

                gunlukiyilesen = Convert.ToInt32(textBox3.Text.Replace(".", ""));

                gunlukvaka = Convert.ToInt32(textBox2.Text.Replace(".", ""));

                gunluktest = Convert.ToInt32(textBox5.Text.Replace(".", ""));

                tarihgun = Convert.ToInt32(textBox10.Text.Replace(".", ""));


                con.Open();
                SqlCommand ekle = new SqlCommand("insert into corona (Gün,GünlükVaka,ToplamVaka,Gunlukiyilesensayisi,Toplamiyilesensayisi,Gunlukolensayisi,Toplamolensayisi,Gunluktestsayisi,Toplamtestsayisi,tarihgun) values ('" + gun.ToString() + "','" + gunlukvaka.ToString() + "','" + toplamvaka.ToString() + "','" + gunlukiyilesen.ToString() + "','" + toplamiyilesen.ToString() + "','" + gunlukolen.ToString() + "','" + toplamolen.ToString() + "','" + gunluktest.ToString() + "','" + toplamtest.ToString() + "', '" + tarihgun.ToString() + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarıyla Eklendi.");


                this.Close();
            }
            else
            {
                MessageBox.Show("Veriler Zaten Güncel Durumdadır.");
            }
            this.Close();
        }
    }
}
