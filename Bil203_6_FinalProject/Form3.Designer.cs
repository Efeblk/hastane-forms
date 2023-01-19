
namespace Bil203_6_FinalProject
{
    partial class Form3
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
            this.form3_txt_listele = new System.Windows.Forms.Button();
            this.form2_txt_sil = new System.Windows.Forms.Button();
            this.form3_back = new System.Windows.Forms.Button();
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
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 302);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "isim";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "hastalık türü";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "hastalık detay";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "yatış tarihi";
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
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "uygulanan tedavi";
            // 
            // form3_txt_listele
            // 
            this.form3_txt_listele.Location = new System.Drawing.Point(501, 70);
            this.form3_txt_listele.Name = "form3_txt_listele";
            this.form3_txt_listele.Size = new System.Drawing.Size(75, 23);
            this.form3_txt_listele.TabIndex = 1;
            this.form3_txt_listele.Text = "Listele";
            this.form3_txt_listele.UseVisualStyleBackColor = true;
            this.form3_txt_listele.Click += new System.EventHandler(this.form3_txt_listele_Click);
            // 
            // form2_txt_sil
            // 
            this.form2_txt_sil.Location = new System.Drawing.Point(501, 144);
            this.form2_txt_sil.Name = "form2_txt_sil";
            this.form2_txt_sil.Size = new System.Drawing.Size(75, 23);
            this.form2_txt_sil.TabIndex = 2;
            this.form2_txt_sil.Text = "Sil";
            this.form2_txt_sil.UseVisualStyleBackColor = true;
            this.form2_txt_sil.Click += new System.EventHandler(this.form2_txt_sil_Click);
            // 
            // form3_back
            // 
            this.form3_back.Location = new System.Drawing.Point(501, 232);
            this.form3_back.Name = "form3_back";
            this.form3_back.Size = new System.Drawing.Size(75, 23);
            this.form3_back.TabIndex = 3;
            this.form3_back.Text = "Geri Dön";
            this.form3_back.UseVisualStyleBackColor = true;
            this.form3_back.Click += new System.EventHandler(this.form3_back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 381);
            this.Controls.Add(this.form3_back);
            this.Controls.Add(this.form2_txt_sil);
            this.Controls.Add(this.form3_txt_listele);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button form3_txt_listele;
        private System.Windows.Forms.Button form2_txt_sil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button form3_back;
    }
}