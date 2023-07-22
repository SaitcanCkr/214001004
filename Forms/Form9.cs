using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _214001004.Forms
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load_1(object sender, EventArgs e)
        {
            DepartmanlariGetir();
        }

        private void DepartmanlariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=1234;database=personelbilgisistemiveritabani"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DepartmanID, DepartmanAdi FROM departman";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int departmanID = reader.GetInt32("DepartmanID");
                        string departmanAdi = reader.GetString("DepartmanAdi");
                        cbDepartman.Items.Add(new Departman(departmanID, departmanAdi)); // Departman sınıfını kullanarak departmanID ve departmanAdi'ni birlikte sakladım
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Departmanlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string ad = txtPersonelAdi.Text;
            string soyad = txtPersonelSoyadi.Text;
            string gorev = txtPersonelGorevi.Text;
            string telefon = tbTelefon.Text;
            string email = txtPersonelEmail.Text;
            string adres = rtbPersonelAdresi.Text;
            Departman departman = (Departman)cbDepartman.SelectedItem; // ComboBox'tan seçilen departmanı Departman sınıfına dönüştürdüm

            
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(gorev) ||
                string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(adres) ||
                departman == null)
            {
                MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (telefon.Length != 10 || !sadeceSayi(telefon))
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=1234;database=personelbilgisistemiveritabani"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO personel (PersonelAdi, PersonelSoyadi, PersonelGorevi, PersonelTelefonu, PersonelEmail, PersonelAdresi, DepartmanID) VALUES (@Ad, @Soyad, @Gorev, @Telefon, @Email, @Adres, @DepartmanID)";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Gorev", gorev);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@DepartmanID", departman.DepartmanID);
                    

                    command.ExecuteNonQuery();

                    MessageBox.Show("Personel başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private bool sadeceSayi(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }

    // Departman sınıfını tanımladım
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string DepartmanAdi { get; set; }

        public Departman(int departmanID, string departmanAdi)
        {
            DepartmanID = departmanID;
            DepartmanAdi = departmanAdi;
        }

        public override string ToString()
        {
            return DepartmanAdi;
        }
    }
}