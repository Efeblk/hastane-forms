using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bil203_6_FinalProject
{
   

    public partial class Form1 : Form
    {
        //BindingSource hastaBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=hastane;Integrated Security=True");

        private void btn_ara_Click(object sender, EventArgs e)
        {
            connection.Open();
        
            SqlCommand command = new SqlCommand("SELECT * FROM [hastane].[dbo].[hasta]", connection);
            //SqlCommand querry = new SqlCommand("SELECT * From [hastane].[dbo].[hasta] WHERE Id = '" + txt_id.Text + "' AND isim = '" + txt_isim.Text + "' AND [hastalık türü] = '" + txt_hastalik_tur.Text + "' AND [hastalık detay] = '" + txt_hastalik_detay.Text + "' AND [yatış tarihi] = '" + txt_yatis_tarihi.Text + "' AND Cinsiyet = '" + txt_cinsiyet.Text + "' AND Yaş = '" + txt_yas.Text + "' AND [Taburcu Tarihi] = '" + txt_taburcu_tarihi.Text + "' AND [Uygulanan Tedaviler] = '" + txt_uygulanan_tedavi.Text + "'");
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);

            dataGridView1.DataSource = tablo;
            connection.Close();

        }
        public void clearALL()
        {
            txt_isim.Clear();
            txt_id.Clear();
            txt_yas.Clear();
            txt_uygulanan_tedavi.Clear();
            txt_yatis_tarihi.Clear();
            txt_taburcu_tarihi.Clear();
            txt_hastalik_detay.Clear();
            txt_hastalik_tur.Clear();
            txt_cinsiyet.Clear();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            
        }

        private void txt_sil_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            form4_txt_hastalik_tur form4 = new form4_txt_hastalik_tur();
            this.Hide();
            form4.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_hastalik_tur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_hastalik_detay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_yatis_tarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_cinsiyet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_yas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_taburcu_tarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_uygulanan_tedavi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
