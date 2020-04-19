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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=CoronaTurkeyData;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut4 = new SqlCommand("Select Top 1 kayit From kayit Order By id Desc", con);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                label2.Text = oku4[0].ToString();
            }
            con.Close();

            con.Open();
            string sorgu = "Select * From  corona Order By id Asc";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            label1.Text = "EN SON GÜNCELLENME SAATİ";
            label2.Text = DateTime.Now.ToString();

            con.Open();
            SqlCommand ekle = new SqlCommand("insert into kayit (kayit) values ('"+label2.Text+"')", con);
            ekle.ExecuteNonQuery();
            con.Close();



            con.Open();
            string sorgu = "Select * From  corona Order By id Asc";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
        }
    }
}
