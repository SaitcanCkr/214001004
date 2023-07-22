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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        #region DepartmanEkle
        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtDepartmanAdi.Text))
            {
                MessageBox.Show("Departman adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtDepartmanBolumu.Text))
            {
                MessageBox.Show("Departman bölümü boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string telefon = tbTelefon.Text.Replace(" ", "");
            if (string.IsNullOrWhiteSpace(telefon) || telefon.Length != 10 || !telefon.All(char.IsDigit))
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Geçerli bir e-mail adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(rtxtAdres.Text))
            {
                MessageBox.Show("Departman adresi boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(@"Server=localhost;Database=personelbilgisistemiveritabani;Uid=root;Pwd=1234;"))
            {
                connection.Open();
                string query = "INSERT INTO departman (DepartmanAdi, DepartmanBolumu, DepartmanTelefonu, DepartmanEmail, DepartmanAdresi) VALUES(@DepartmanAdi, @DepartmanBolumu, @DepartmanTelefonu, @DepartmanEmail, @DepartmanAdresi)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmanAdi", txtDepartmanAdi.Text);
                    command.Parameters.AddWithValue("@DepartmanBolumu", txtDepartmanBolumu.Text);
                    command.Parameters.AddWithValue("@DepartmanTelefonu", telefon);
                    command.Parameters.AddWithValue("@DepartmanEmail", txtEmail.Text);
                    command.Parameters.AddWithValue("@DepartmanAdresi", rtxtAdres.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Departman başarıyla eklendi.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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