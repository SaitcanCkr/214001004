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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }



        private void Form8_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            int veriSayaci = 0;
            dgPersonelListele.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPersonelListele.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
            {
                conn.Open();
                string sorgu = "SELECT * FROM personel";
                using (MySqlCommand command = new MySqlCommand(sorgu, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        veriSayaci = dt.Rows.Count;
                        dgPersonelListele.DataSource = dt;
                        dgPersonelListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
                if (veriSayaci == 0)
                {
                    string alterTable = "ALTER TABLE personel AUTO_INCREMENT = 1";
                    using (MySqlCommand command = new MySqlCommand(alterTable, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();

        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int veriSayaci = 0;
            DialogResult cevap = MessageBox.Show("Seçili personel silinsin mi?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cevap == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
                {
                    connection.Open();
                    string sorgu = "DELETE FROM personel WHERE PersonelId=@PersonelId";
                    using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                    {
                        int selectedIndex = dgPersonelListele.SelectedRows[0].Index;
                        int id = int.Parse(dgPersonelListele[0, selectedIndex].Value.ToString());
                        command.Parameters.AddWithValue("@PersonelId", id);
                        command.ExecuteNonQuery();
                    }
                    if (veriSayaci == 0)
                    {
                        string alterTable = "ALTER TABLE personel AUTO_INCREMENT = 1";
                        using (MySqlCommand command = new MySqlCommand(alterTable, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                Form8_Load(sender, e);
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            Form8_Load(sender, e);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            (dgPersonelListele.DataSource as DataTable).DefaultView.RowFilter
                = string.Format("PersonelAdi LIKE '{0}%'", txtAra.Text);
        }
    }
}
