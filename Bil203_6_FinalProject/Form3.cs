using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bil203_6_FinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=hastane;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [hastane].[dbo].[hasta]", connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["Id"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["isim"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["hastalık türü"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["hastalık detay"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["yatış tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Cinsiyet"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Yaş"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Taburcu Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Uygulanan Tedaviler"].ToString());
            }
            connection.Close();
        }

        private void form3_txt_listele_Click(object sender, EventArgs e)
        {
            
        }

        private void form2_txt_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command2 = new SqlCommand("DELETE FROM hastane.dbo.hasta where Id=@Id", connection);
                command2.Parameters.AddWithValue("@Id", Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                connection.Open();
                command2.ExecuteNonQuery();
                connection.Close(); 
            }
             catch
            {
                MessageBox.Show("silincek veri seçiniz");
            }

            //list
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [hastane].[dbo].[hasta]", connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["Id"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["isim"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["hastalık türü"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["hastalık detay"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["yatış tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Cinsiyet"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Yaş"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Taburcu Tarihi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Uygulanan Tedaviler"].ToString());
            }
            connection.Close();
        }

        private void form3_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
