using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _214001004.Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }      
        private void Form4_Load(object sender, EventArgs e)
        {
            int veriSayaci = 0;
            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
            {
                connection.Open();
                string sorgu = "SELECT * FROM kullanici";
                using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        veriSayaci = dt.Rows.Count;
                        dgKullaniciListele.DataSource = dt;
                        dgKullaniciListele.AutoResizeColumns();
                        dgKullaniciListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgKullaniciListele.AutoGenerateColumns = true;
                    }
                }
                if (veriSayaci == 0)
                {
                    string alterTable = "ALTER TABLE kullanici AUTO_INCREMENT = 1";
                    using (MySqlCommand command = new MySqlCommand(alterTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        #region btnKullaniciEkle
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
        #endregion

        #region btnGuncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Form4_Load(sender, e);
        }
        #endregion

        #region btnSil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int veriSayaci = 0;
            DialogResult cevap = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap==DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
                {
                    connection.Open();
                    string sorgu = "DELETE FROM kullanici WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                    {
                        int selectedIndex = dgKullaniciListele.SelectedRows[0].Index;
                        int id = int.Parse(dgKullaniciListele[0, selectedIndex].Value.ToString());
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    if (veriSayaci == 0)
                    {
                        string alterTable = "ALTER TABLE kullanici AUTO_INCREMENT = 1";
                        using (MySqlCommand command = new MySqlCommand(alterTable, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                Form4_Load(sender, e);
            }
            
        }
        #endregion

        #region txtAra
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            (dgKullaniciListele.DataSource as DataTable).DefaultView.RowFilter
                = string.Format("KullaniciAdi LIKE '{0}%'", txtAra.Text);
        }
        #endregion

        #region geriGit
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Close();
            frm.Show();
        }
        #endregion
    }
}
