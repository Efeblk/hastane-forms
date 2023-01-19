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
    public partial class form4_txt_hastalik_tur : Form
    {
        public form4_txt_hastalik_tur()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=hastane;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
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
        int idid;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idid = Convert.ToInt32(listView1.SelectedItems[0].Text);

                form4_txt_id.Text = listView1.SelectedItems[0].Text;
                form4_txt_isim.Text = listView1.SelectedItems[0].SubItems[1].Text;
                form4_txt_hastaliktur.Text = listView1.SelectedItems[0].SubItems[2].Text;
                form4_txt_hastalik_detay.Text = listView1.SelectedItems[0].SubItems[3].Text;
                form4_txt_yatis_tarihi.Text = listView1.SelectedItems[0].SubItems[4].Text;
                form4_txt_cinsiyet.Text = listView1.SelectedItems[0].SubItems[5].Text;
                form4_txt_yas.Text = listView1.SelectedItems[0].SubItems[6].Text;
                form4_txt_taburcu_tarihi.Text = listView1.SelectedItems[0].SubItems[7].Text;
                form4_txt_uygulanan_tedavi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            }
            catch
            {
                MessageBox.Show("doğru data giriniz");
            }
           
        }

        private void form3_btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("UPDATE hastane.dbo.hasta SET Id=@Id ,isim=@isim, [hastalık türü]=@hastaliktur , [hastalık detay]=@hastalikdetay , [yatış tarihi]=@yatistarihi, Cinsiyet=@Cinsiyet, Yaş=@yas,  [Taburcu Tarihi]=@taburcutarihi, [Uygulanan Tedaviler]=@uygulanantedaviler WHERE Id=@Id2", connection);
            command3.Parameters.AddWithValue("@Id", Convert.ToInt32(form4_txt_id.Text));
            command3.Parameters.AddWithValue("@isim", form4_txt_isim.Text);
            command3.Parameters.AddWithValue("@hastaliktur", form4_txt_hastaliktur.Text);
            command3.Parameters.AddWithValue("@hastalikdetay", form4_txt_hastalik_detay.Text);
            command3.Parameters.AddWithValue("@yatistarihi", form4_txt_yatis_tarihi.Text);
            command3.Parameters.AddWithValue("@Cinsiyet", form4_txt_cinsiyet.Text);
            command3.Parameters.AddWithValue("@yas", Convert.ToInt32(form4_txt_yas.Text));
            command3.Parameters.AddWithValue("@taburcutarihi", form4_txt_taburcu_tarihi.Text);
            command3.Parameters.AddWithValue("@uygulanantedaviler", form4_txt_uygulanan_tedavi.Text);
            command3.Parameters.AddWithValue("@Id2", idid);
            connection.Open();
            command3.ExecuteNonQuery();
            connection.Close();

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

        private void form4_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
