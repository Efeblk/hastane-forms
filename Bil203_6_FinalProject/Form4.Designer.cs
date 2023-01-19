
namespace Bil203_6_FinalProject
{
    partial class form4_txt_hastalik_tur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.form4_txt_id = new System.Windows.Forms.TextBox();
            this.form4_txt_isim = new System.Windows.Forms.TextBox();
            this.form4_txt_hastalik_detay = new System.Windows.Forms.TextBox();
            this.form4_txt_yatis_tarihi = new System.Windows.Forms.TextBox();
            this.form4_txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.form4_txt_yas = new System.Windows.Forms.TextBox();
            this.form4_txt_taburcu_tarihi = new System.Windows.Forms.TextBox();
            this.form4_txt_uygulanan_tedavi = new System.Windows.Forms.TextBox();
            this.form3_btn_guncelle = new System.Windows.Forms.Button();
            this.form4_txt_hastaliktur = new System.Windows.Forms.TextBox();
            this.form4_btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 302);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "isim";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "hastalık türü";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "hastalık detay";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "yatış tarihi";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "cinsiyet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "yaş";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "taburcu tarihi";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "uygulanan tedavi";
            this.columnHeader9.Width = 120;
            // 
            // form4_txt_id
            // 
            this.form4_txt_id.Location = new System.Drawing.Point(752, 35);
            this.form4_txt_id.Name = "form4_txt_id";
            this.form4_txt_id.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_id.TabIndex = 2;
            // 
            // form4_txt_isim
            // 
            this.form4_txt_isim.Location = new System.Drawing.Point(752, 64);
            this.form4_txt_isim.Name = "form4_txt_isim";
            this.form4_txt_isim.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_isim.TabIndex = 3;
            // 
            // form4_txt_hastalik_detay
            // 
            this.form4_txt_hastalik_detay.Location = new System.Drawing.Point(752, 122);
            this.form4_txt_hastalik_detay.Name = "form4_txt_hastalik_detay";
            this.form4_txt_hastalik_detay.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_hastalik_detay.TabIndex = 4;
            // 
            // form4_txt_yatis_tarihi
            // 
            this.form4_txt_yatis_tarihi.Location = new System.Drawing.Point(752, 151);
            this.form4_txt_yatis_tarihi.Name = "form4_txt_yatis_tarihi";
            this.form4_txt_yatis_tarihi.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_yatis_tarihi.TabIndex = 5;
            // 
            // form4_txt_cinsiyet
            // 
            this.form4_txt_cinsiyet.Location = new System.Drawing.Point(752, 180);
            this.form4_txt_cinsiyet.Name = "form4_txt_cinsiyet";
            this.form4_txt_cinsiyet.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_cinsiyet.TabIndex = 6;
            // 
            // form4_txt_yas
            // 
            this.form4_txt_yas.Location = new System.Drawing.Point(752, 209);
            this.form4_txt_yas.Name = "form4_txt_yas";
            this.form4_txt_yas.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_yas.TabIndex = 7;
            // 
            // form4_txt_taburcu_tarihi
            // 
            this.form4_txt_taburcu_tarihi.Location = new System.Drawing.Point(752, 238);
            this.form4_txt_taburcu_tarihi.Name = "form4_txt_taburcu_tarihi";
            this.form4_txt_taburcu_tarihi.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_taburcu_tarihi.TabIndex = 8;
            // 
            // form4_txt_uygulanan_tedavi
            // 
            this.form4_txt_uygulanan_tedavi.Location = new System.Drawing.Point(752, 267);
            this.form4_txt_uygulanan_tedavi.Name = "form4_txt_uygulanan_tedavi";
            this.form4_txt_uygulanan_tedavi.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_uygulanan_tedavi.TabIndex = 9;
            // 
            // form3_btn_guncelle
            // 
            this.form3_btn_guncelle.Location = new System.Drawing.Point(752, 313);
            this.form3_btn_guncelle.Name = "form3_btn_guncelle";
            this.form3_btn_guncelle.Size = new System.Drawing.Size(100, 23);
            this.form3_btn_guncelle.TabIndex = 11;
            this.form3_btn_guncelle.Text = "Güncelle";
            this.form3_btn_guncelle.UseVisualStyleBackColor = true;
            this.form3_btn_guncelle.Click += new System.EventHandler(this.form3_btn_guncelle_Click);
            // 
            // form4_txt_hastaliktur
            // 
            this.form4_txt_hastaliktur.Location = new System.Drawing.Point(752, 93);
            this.form4_txt_hastaliktur.Name = "form4_txt_hastaliktur";
            this.form4_txt_hastaliktur.Size = new System.Drawing.Size(100, 23);
            this.form4_txt_hastaliktur.TabIndex = 12;
            // 
            // form4_btn_back
            // 
            this.form4_btn_back.Location = new System.Drawing.Point(882, 314);
            this.form4_btn_back.Name = "form4_btn_back";
            this.form4_btn_back.Size = new System.Drawing.Size(75, 23);
            this.form4_btn_back.TabIndex = 13;
            this.form4_btn_back.Text = "Geri Dön";
            this.form4_btn_back.UseVisualStyleBackColor = true;
            this.form4_btn_back.Click += new System.EventHandler(this.form4_btn_back_Click);
            // 
            // form4_txt_hastalik_tur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 359);
            this.Controls.Add(this.form4_btn_back);
            this.Controls.Add(this.form4_txt_hastaliktur);
            this.Controls.Add(this.form3_btn_guncelle);
            this.Controls.Add(this.form4_txt_uygulanan_tedavi);
            this.Controls.Add(this.form4_txt_taburcu_tarihi);
            this.Controls.Add(this.form4_txt_yas);
            this.Controls.Add(this.form4_txt_cinsiyet);
            this.Controls.Add(this.form4_txt_yatis_tarihi);
            this.Controls.Add(this.form4_txt_hastalik_detay);
            this.Controls.Add(this.form4_txt_isim);
            this.Controls.Add(this.form4_txt_id);
            this.Controls.Add(this.listView1);
            this.Name = "form4_txt_hastalik_tur";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox form4_txt_id;
        private System.Windows.Forms.TextBox form4_txt_isim;
        private System.Windows.Forms.TextBox form4_txt_hastalik_detay;
        private System.Windows.Forms.TextBox form4_txt_yatis_tarihi;
        private System.Windows.Forms.TextBox form4_txt_cinsiyet;
        private System.Windows.Forms.TextBox form4_txt_yas;
        private System.Windows.Forms.TextBox form4_txt_taburcu_tarihi;
        private System.Windows.Forms.TextBox form4_txt_uygulanan_tedavi;
        private System.Windows.Forms.Button form3_btn_guncelle;
        private System.Windows.Forms.TextBox form4_txt_hastaliktur;
        private System.Windows.Forms.Button form4_btn_back;
    }
}