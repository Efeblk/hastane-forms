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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=hastane;Integrated Security=True");
        public void clearALL()
        {
            form2_txt_isim.Clear();
            form2_txt_id.Clear();
            form2_txt_yas.Clear();
            form2_txt_uygulanan_tedavi.Clear();
            form2_txt_yatis_tarihi.Clear();
            form2_taburcu_tarihi.Clear();
            form2_txt_hastalik_detay.Clear();
            form2_txt_hastalik_tur.Clear();
            form2_txt_cinsiyet.Clear();
        }

        private void form2_btn_ekle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            try
            {
                hasta.Id = Convert.ToInt32(form2_txt_id.Text);
                hasta.isim = form2_txt_isim.Text;
                hasta.yas = Convert.ToInt32(form2_txt_yas.Text);
                hasta.cinsiyet = form2_txt_cinsiyet.Text;
                hasta.uygulanan_tedavi = form2_txt_uygulanan_tedavi.Text;
                hasta.yatıs_tarihi = form2_txt_yatis_tarihi.Text;
                hasta.taburcu_tarihi = form2_taburcu_tarihi.Text;
                hasta.hastalık_tur = form2_txt_hastalik_tur.Text;
                hasta.hastalık_detay = form2_txt_hastalik_detay.Text;
                MessageBox.Show("başarıyla eklendi");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch
            {
                MessageBox.Show("lütfen doğru giriş yapınız");
            }

            SqlCommand ekle = new SqlCommand("INSERT INTO [hastane].[dbo].[hasta](Id, isim,[hastalık türü],[hastalık detay],[yatış tarihi],Cinsiyet,Yaş,[Taburcu Tarihi],[Uygulanan Tedaviler]) Values ( '" + hasta.Id + "', '" + hasta.isim + "', '" + hasta.hastalık_tur + "','" + hasta.hastalık_detay + "','" + hasta.yatıs_tarihi + "','" + hasta.cinsiyet + "','" + hasta.yas + "','" + hasta.taburcu_tarihi + "','" + hasta.uygulanan_tedavi + "' )", connection);
            connection.Open();
            ekle.ExecuteNonQuery();
            connection.Close();
            clearALL();
        }

        private void form2_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
