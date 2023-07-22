namespace _214001004.Forms
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.dgPersonelListele = new System.Windows.Forms.DataGridView();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelGorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPersonelSil);
            this.panel2.Controls.Add(this.dgPersonelListele);
            this.panel2.Controls.Add(this.btnPersonelGuncelle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtAra);
            this.panel2.Controls.Add(this.btnPersonelEkle);
            this.panel2.Location = new System.Drawing.Point(16, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 348);
            this.panel2.TabIndex = 5;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.Red;
            this.btnPersonelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelSil.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.White;
            this.btnPersonelSil.Location = new System.Drawing.Point(101, 14);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(75, 27);
            this.btnPersonelSil.TabIndex = 6;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // dgPersonelListele
            // 
            this.dgPersonelListele.AllowUserToAddRows = false;
            this.dgPersonelListele.AllowUserToDeleteRows = false;
            this.dgPersonelListele.AllowUserToResizeColumns = false;
            this.dgPersonelListele.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPersonelListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersonelListele.BackgroundColor = System.Drawing.Color.White;
            this.dgPersonelListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonelListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PersonelAdi,
            this.PersonelSoyadi,
            this.PersonelGorevi,
            this.PersonelEmail,
            this.PersonelAdresi,
            this.DepartmanId});
            this.dgPersonelListele.Location = new System.Drawing.Point(20, 71);
            this.dgPersonelListele.Name = "dgPersonelListele";
            this.dgPersonelListele.ReadOnly = true;
            this.dgPersonelListele.RowHeadersVisible = false;
            this.dgPersonelListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersonelListele.Size = new System.Drawing.Size(699, 264);
            this.dgPersonelListele.TabIndex = 5;
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonelGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(182, 14);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(81, 27);
            this.btnPersonelGuncelle.TabIndex = 4;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(579, 14);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(140, 20);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelEkle.Location = new System.Drawing.Point(20, 14);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 27);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 45);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(731, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 46);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personeller";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "PersonelId";
            this.Id.HeaderText = "Personel Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.DataPropertyName = "PersonelAdi";
            this.PersonelAdi.HeaderText = "Personel Adı";
            this.PersonelAdi.Name = "PersonelAdi";
            this.PersonelAdi.ReadOnly = true;
            // 
            // PersonelSoyadi
            // 
            this.PersonelSoyadi.DataPropertyName = "PersonelSoyadi";
            this.PersonelSoyadi.HeaderText = "Personel Soyadı";
            this.PersonelSoyadi.Name = "PersonelSoyadi";
            this.PersonelSoyadi.ReadOnly = true;
            // 
            // PersonelGorevi
            // 
            this.PersonelGorevi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonelGorevi.DataPropertyName = "PersonelGorevi";
            this.PersonelGorevi.HeaderText = "Personel Görevi";
            this.PersonelGorevi.Name = "PersonelGorevi";
            this.PersonelGorevi.ReadOnly = true;
            // 
            // PersonelEmail
            // 
            this.PersonelEmail.DataPropertyName = "PersonelEmail";
            this.PersonelEmail.HeaderText = "Personel E-Mail";
            this.PersonelEmail.Name = "PersonelEmail";
            this.PersonelEmail.ReadOnly = true;
            // 
            // PersonelAdresi
            // 
            this.PersonelAdresi.DataPropertyName = "PersonelAdresi";
            this.PersonelAdresi.HeaderText = "Personel Adresi";
            this.PersonelAdresi.Name = "PersonelAdresi";
            this.PersonelAdresi.ReadOnly = true;
            // 
            // DepartmanId
            // 
            this.DepartmanId.DataPropertyName = "DepartmanId";
            this.DepartmanId.HeaderText = "Departman Id";
            this.DepartmanId.Name = "DepartmanId";
            this.DepartmanId.ReadOnly = true;
            this.DepartmanId.Visible = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPersonelSil;
        public System.Windows.Forms.DataGridView dgPersonelListele;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelGorevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmanId;
    }
}