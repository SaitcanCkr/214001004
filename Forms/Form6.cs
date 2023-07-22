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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
            int veriSayaci = 0;
            dgDepartmanListele.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgDepartmanListele.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
            {
                conn.Open();
                string sorgu = "SELECT * FROM departman";
                using (MySqlCommand command = new MySqlCommand(sorgu, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        veriSayaci = dt.Rows.Count;
                        dgDepartmanListele.DataSource = dt;
                        dgDepartmanListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
                if (veriSayaci == 0)
                {
                    string alterTable = "ALTER TABLE departman AUTO_INCREMENT = 1";
                    using (MySqlCommand command = new MySqlCommand(alterTable, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        #region DepartmanEkle
        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }
        #endregion

        #region DepartmanSil
        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            int veriSayaci = 0;
            DialogResult cevap = MessageBox.Show("Seçili departman silinsin mi ?","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (cevap==DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;database=personelbilgisistemiveritabani;user=root;password=1234;"))
                {
                    connection.Open();
                    string sorgu = "DELETE FROM departman WHERE DepartmanId=@DepartmanId";
                    using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                    {
                        int selectedIndex = dgDepartmanListele.SelectedRows[0].Index;
                        int id = int.Parse(dgDepartmanListele[0, selectedIndex].Value.ToString());
                        command.Parameters.AddWithValue("@DepartmanId", id);
                        command.ExecuteNonQuery();
                    }
                    if (veriSayaci == 0)
                    {
                        string alterTable = "ALTER TABLE departman AUTO_INCREMENT = 1";
                        using (MySqlCommand command = new MySqlCommand(alterTable, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                Form6_Load(sender, e);
            }            
        }
        #endregion

        #region DepartmanGuncelle
        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            Form6_Load(sender, e);
        }
        #endregion

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            (dgDepartmanListele.DataSource as DataTable).DefaultView.RowFilter
                = string.Format("DepartmanAdi LIKE '{0}%'", txtAra.Text);
        }
    }
}
