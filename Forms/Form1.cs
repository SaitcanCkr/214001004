using _214001004.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _214001004.Forms;

namespace _214001004
{
    public partial class Form1 : Form
    {
        ApplicationConnectionDb db = new ApplicationConnectionDb();

        public Form1()
        {
            InitializeComponent();
        }

        private int RastgeleSayiÜret()
        {
            Random rnd = new Random();
            return rnd.Next(0, 99999);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbSifre.UseSystemPasswordChar = true;
            tbKod.Text = RastgeleSayiÜret().ToString();
        }

        #region Giriş
        private void btnGiris_Click(object sender, EventArgs e)
        {
            int rsayi = Convert.ToInt32(tbKod.Text);
            string cs = @"server=localhost;userid=root;password=1234;database=personelbilgisistemiveritabani";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string stm = "select Id,KullaniciAdi,KullaniciSifre,KullaniciYetki from kullanici" +
                                " where KullaniciAdi =@KullaniciAdi AND KullaniciSifre =@KullaniciSifre";
                var cmd = new MySqlCommand(stm, con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", tbKulad.Text);
                cmd.Parameters.AddWithValue("@KullaniciSifre", tbSifre.Text);             
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string kullaniciAdi = reader["KullaniciAdi"].ToString();
                            string kullaniciSifre = reader["KullaniciSifre"].ToString();
                            string kullaniciYetki = reader["KullaniciYetki"].ToString();


                            if (txtKod.Text == rsayi.ToString())
                            {
                                if (kullaniciAdi == tbKulad.Text && kullaniciSifre == tbSifre.Text && kullaniciYetki == "Üst Düzey Yetkili")
                                {
                                    Form2 form2 = new Form2();
                                    form2.Show();
                                    this.Hide();
                                    break;
                                }
                                if (kullaniciAdi == tbKulad.Text && kullaniciSifre == tbSifre.Text && kullaniciYetki == "Personel ve Departman Sorumlusu")
                                {
                                    Form3 form3 = new Form3();
                                    form3.Show();
                                    this.Hide();
                                    break;
                                }
                                if (kullaniciAdi == tbKulad.Text && kullaniciSifre == tbSifre.Text && kullaniciYetki == "Personel Sorumlusu")
                                {
                                    Form10 form10 = new Form10();
                                    form10.Show();
                                    this.Hide();
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı,şifre veya kod yanlış. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı,şifre veya kod yanlış. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region ŞifreGöster
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                tbSifre.UseSystemPasswordChar = true;
            }
            else if (checkBox1.Checked == true)
            {
                tbSifre.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Şifreİpucu
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vazgeçtim, ipucu yok.", "İpucu", MessageBoxButtons.OK);
        }

        #endregion

        
    }
}
