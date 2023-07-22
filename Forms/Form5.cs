using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _214001004.Forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        #region KullaniciEkle
        public void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(@"Server=localhost;Database=personelbilgisistemiveritabani;Uid=root;Pwd=1234;"))
            {
                connection.Open();
                string query = "INSERT INTO kullanici (KullaniciAdi, KullaniciSifre, KullaniciYetki) VALUES (@KullaniciAdi, @KullaniciSifre, @KullaniciYetki)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", tbKulad.Text);
                    command.Parameters.AddWithValue("@KullaniciSifre", tbSifre.Text);
                    command.Parameters.AddWithValue("@KullaniciYetki", cbYetki.SelectedItem);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
