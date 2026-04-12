using KutuphaneYonetimSistemi.Class;
using KutuphaneYonetimSistemi.Class;
using Microsoft.Data.SqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;
using SqlTransaction = Microsoft.Data.SqlClient.SqlTransaction;

namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        string selectedId;
        public Form1()
        {
            InitializeComponent();
            RefreshPage1();
            RefreshPage2();
            RefreshPage3();
            KitapIstatistikler();
            Uyeİstatistikler();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kitap işlemleri
            cmbKategori.Items.AddRange(new string[] {
        "Roman", "Bilim", "Tarih", "Felsefe", "Çocuk", "Diğer"
    });
            cmbDurum.Items.AddRange(new string[] {
        "Mevcut", "Ödünçte"
    });

            RefreshPage1();

            // Üye işlemleri
            RefreshPage2();
            Uyeİstatistikler();

            // Ödünç işlemleri 
            UyeleriComboyaDoldur();
            KitaplarıComboyaDoldur();
            OduncKitaplariListele();

         
            dtpOduncTarihi.Value = DateTime.Now;
        }
        public void RefreshPage1()
        {
            SqlCommand cmd = new SqlCommand("Select * from Kitaplar", SqlVariable.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitaplar.DataSource = dt;


        }
        public void RefreshPage2()
        {
            SqlCommand cmd = new SqlCommand("Select * from Uyeler", SqlVariable.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUyeler.DataSource = dt;


        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into Kitaplar(ISBN,KitapAdi,Yazar,Yayinevi,SayfaSayisi,Kategori,Durum) values(@pisbn,@pkitapadi,@pyazar,@pyayinevi,@psayfasayisi,@pkategori,@pdurum)", SqlVariable.baglanti);
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            commandAdd.Parameters.AddWithValue("@pisbn",txtISBN.Text);
            commandAdd.Parameters.AddWithValue("@pkitapadi",txtKitapAdi.Text);
            commandAdd.Parameters.AddWithValue("@pyazar",txtYazar.Text);
            commandAdd.Parameters.AddWithValue("@pyayinevi",txtYayinevi.Text);
            commandAdd.Parameters.AddWithValue("@psayfasayisi",txtSayfaSayisi.Text);
            commandAdd.Parameters.AddWithValue("@pkategori",cmbKategori.Text);
            commandAdd.Parameters.AddWithValue("@pdurum",cmbDurum.Text);
            commandAdd.ExecuteNonQuery();
            RefreshPage1();
            KitapIstatistikler();



        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update Kitaplar set ISBN=@pisbn,KitapAdi=@pkitapadi,Yazar=@pyazar, Yayinevi= @pyayinevi, SayfaSayisi=@psayfasayisi, Kategori = @pkategori, Durum=@pdurum where KitapId=@pid", SqlVariable.baglanti);
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            commandEdit.Parameters.AddWithValue("@pisbn", txtISBN.Text);
            commandEdit.Parameters.AddWithValue("@pkitapadi", txtKitapAdi.Text);
            commandEdit.Parameters.AddWithValue("@pyazar", txtYazar.Text);
            commandEdit.Parameters.AddWithValue("@pyayinevi", txtYayinevi.Text);
            commandEdit.Parameters.AddWithValue("@psayfasayisi", txtSayfaSayisi.Text);
            commandEdit.Parameters.AddWithValue("@pkategori", cmbKategori.Text);
            commandEdit.Parameters.AddWithValue("@pdurum", cmbDurum.Text);
            commandEdit.Parameters.AddWithValue("@pid",txtKitapId.Text);
            commandEdit.ExecuteNonQuery();
            RefreshPage1();
            KitapIstatistikler();
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            selectedId = dgvKitaplar.CurrentRow.Cells["KitapId"].Value.ToString();
            txtISBN.Text = dgvKitaplar.CurrentRow.Cells["ISBN"].Value.ToString();
            txtKitapAdi.Text = dgvKitaplar.CurrentRow.Cells["KitapAdi"].Value.ToString();
            txtSayfaSayisi.Text = dgvKitaplar.CurrentRow.Cells["SayfaSayisi"].Value.ToString();
            txtYayinevi.Text=dgvKitaplar.CurrentRow.Cells["Yayinevi"].Value.ToString() ;
            txtYazar.Text=dgvKitaplar.CurrentRow.Cells["Yazar"].Value.ToString() ;
            txtKitapId.Text = dgvKitaplar.CurrentRow.Cells["KitapId"].Value.ToString();
            cmbDurum.SelectedItem = dgvKitaplar.CurrentRow.Cells["Durum"].Value.ToString();
            cmbKategori.SelectedItem = dgvKitaplar.CurrentRow.Cells["Kategori"].Value.ToString();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            string kitapAdi = dgvKitaplar.CurrentRow.Cells["KitapAdi"].Value.ToString();
            SqlCommand commandSil = new SqlCommand("Delete from Kitaplar where KitapId = @pid", SqlVariable.baglanti);
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            DialogResult onay = MessageBox.Show(
                $"{kitapAdi} isimli kitabı silmek istediğinize emin misiniz!", "Onay", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                commandSil.Parameters.AddWithValue("@pid",Convert.ToInt32(selectedId));
                commandSil.ExecuteNonQuery();
                MessageBox.Show("Kitap başarıyla silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            RefreshPage1();
            KitapIstatistikler();
        }

        private void btnKitapTemizle_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtKitapAdi.Text = "";
            txtKitapAra.Text = "";
            txtKitapId.Text = "";
            txtSayfaSayisi.Text = "";
            txtYayinevi.Text = "";
            txtYazar.Text = "";
            cmbDurum.SelectedItem= null;
            cmbKategori.SelectedItem= null;
        }

        private void lblToplamKitap_Click(object sender, EventArgs e)
        {

        }
        private void KitapIstatistikler()
        {
            lblMevcutKitap.Text = "Mevcut Kitap Sayısı: " +
     dgvKitaplar.Rows.Cast<DataGridViewRow>()
     .Count(r => r.Cells["Durum"].Value?.ToString() == "Mevcut");
            lblToplamKitap.Text = "Toplam Kitap Sayısı: " + dgvKitaplar.Rows.Count.ToString();
            lblOduncteKitap.Text = "Ödünç Kitap Sayısı: " +
    dgvKitaplar.Rows.Cast<DataGridViewRow>()
    .Count(r => r.Cells["Durum"].Value?.ToString() == "Ödünç");
            RefreshPage1();

        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            string aranacakKitap= txtKitapAra.Text.Trim();
            if (string.IsNullOrWhiteSpace(aranacakKitap))
            {
                RefreshPage1();
                return;
            }
            try
            {
                SqlVariable.CheckConnection(SqlVariable.baglanti);
                // Kitap adı, yazar veya ISBN'de arama yap
                string query = @"SELECT * FROM Kitaplar 
                        WHERE KitapAdi LIKE @parama 
                        OR Yazar LIKE @parama 
                        OR ISBN LIKE @parama";
                using (SqlCommand cmd = new SqlCommand(query, SqlVariable.baglanti))
                {
                    cmd.Parameters.AddWithValue("@parama", "%" + aranacakKitap + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKitaplar.DataSource = dt;

                    // Kaç sonuç bulundu göster
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız kriterlere uygun kitap bulunamadı!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{dt.Rows.Count} kitap bulundu!", "Sonuç",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtKitapAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter tuşuna basıldıysa ara
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnKitapAra_Click(sender, e);
                e.Handled = true; 
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txtKitapAra.Text.Trim();

            // Eğer boşsa tüm kitapları göster
            if (string.IsNullOrWhiteSpace(aramaKelimesi))
            {
                RefreshPage1();
                return;
            }

            try
            {
                SqlVariable.CheckConnection(SqlVariable.baglanti);

                string query = @"SELECT * FROM Kitaplar 
                        WHERE KitapAdi LIKE @Arama 
                        OR Yazar LIKE @Arama 
                        OR ISBN LIKE @Arama";

                using (SqlCommand cmd = new SqlCommand(query, SqlVariable.baglanti))
                {
                    cmd.Parameters.AddWithValue("@Arama", "%" + aramaKelimesi + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKitaplar.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTCNo.Text))
            {
                MessageBox.Show("TC No boş olamaz!", "Uyarı");
                txtTCNo.Focus();
                return;
            }

            if (txtTCNo.Text.Length != 11)
            {
                MessageBox.Show("TC No 11 haneli olmalıdır!", "Uyarı");
                txtTCNo.Focus();
                return;
            }
            bool tcVarMi = false;

            foreach (DataGridViewRow row in dgvUyeler.Rows)
            {
                if (row.Cells["TCNo"].Value != null &&
                    row.Cells["TCNo"].Value.ToString() == txtTCNo.Text)
                {
                    tcVarMi = true;
                    break;
                }
            }

            if (tcVarMi)
            {
                MessageBox.Show("Bu TC No zaten kayıtlı!", "Uyar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (string.IsNullOrWhiteSpace(txtUyeAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad boş olamaz!", "Uyarı");
                txtUyeAdSoyad.Focus();
                return;
            }

            SqlCommand commandUyeEkle = new SqlCommand("INSERT INTO Uyeler (TCNo, AdSoyad, Telefon, Eposta) VALUES (@pUyeTc,@pUyeAdSoyad,@pUyeTelefon,@pUyeEposta)",SqlVariable.baglanti);
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            commandUyeEkle.Parameters.AddWithValue("@pUyeTc", txtTCNo.Text.ToString());
            commandUyeEkle.Parameters.AddWithValue("@pUyeAdSoyad", txtUyeAdSoyad.Text.ToString());
            commandUyeEkle.Parameters.AddWithValue("@pUyeTelefon", txtTelefon.Text.ToString());
            commandUyeEkle.Parameters.AddWithValue("@pUyeEposta", txtEposta.Text.ToString());
            commandUyeEkle.ExecuteNonQuery();


            RefreshPage2();
            Uyeİstatistikler();


            
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            string UyeAdi = dgvUyeler.CurrentRow.Cells["AdSoyad"].Value.ToString();
            SqlCommand commandUyeSil = new SqlCommand("Delete from Uyeler where UyeID = @pUyeId", SqlVariable.baglanti);
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            DialogResult onay = MessageBox.Show(
                $"{UyeAdi} isimli üyeyi silmek istediğinize emin misiniz!", "Onay", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                commandUyeSil.Parameters.AddWithValue("@pUyeId", Convert.ToInt32(selectedId));
                commandUyeSil.ExecuteNonQuery();
                MessageBox.Show("Uye başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            RefreshPage2();
            Uyeİstatistikler();
        }

        private void dgvUyeler_SelectionChanged(object sender, EventArgs e)
        {
            selectedId = dgvUyeler.CurrentRow.Cells["UyeID"].Value.ToString();
            txtTCNo.Text = dgvUyeler.CurrentRow.Cells["TCNo"].Value.ToString();
            txtUyeAdSoyad.Text = dgvUyeler.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dgvUyeler.CurrentRow.Cells["Telefon"].Value.ToString();
            txtEposta.Text = dgvUyeler.CurrentRow.Cells["Eposta"].Value.ToString();

        }

        private void btnUyeTemizle_Click(object sender, EventArgs e)
        {
            txtTCNo.Text = "";
            txtUyeAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtEposta.Text = "";
            txtUyeId.Text = "";
        }

        private void btnUyeAra_Click(object sender, EventArgs e)
        {
            string aranacakUye = txtUyeAra.Text.Trim();
            SqlVariable.CheckConnection(SqlVariable.baglanti);
            SqlCommand commandUyeAra = new SqlCommand("Select * From Uyeler Where AdSoyad LIKE @puyearama", SqlVariable.baglanti);
            commandUyeAra.Parameters.AddWithValue("@puyearama", "%" + aranacakUye + "%");
            SqlDataAdapter da = new SqlDataAdapter(commandUyeAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığınız kriterlere uygun kitap bulunamadı!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{dt.Rows.Count} kitap bulundu!", "Sonuç",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            string aranacakUye = txtUyeAra.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(aranacakUye))
            {
                RefreshPage1();
                return;
            }
            SqlCommand commandUyeAra = new SqlCommand("Select * from Uyeler WHERE AdSoyad LIKE @puyearama",SqlVariable.baglanti);
            commandUyeAra.Parameters.AddWithValue("@puyearama","%" + aranacakUye + "%");
            SqlDataAdapter da = new SqlDataAdapter(commandUyeAra);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUyeler.DataSource = dt;
        }
        private void Uyeİstatistikler()
        {
            lblToplamUye.Text ="Toplam Uye:" + dgvUyeler.RowCount.ToString();
        }
        private void RefreshPage3()
        {
            SqlCommand cmd = new SqlCommand("Select * from OduncKitaplar", SqlVariable.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOduncKitaplar.DataSource = dt;
        }
        private void UyeleriComboyaDoldur()
        {
            try
            {
                SqlVariable.CheckConnection(SqlVariable.baglanti);

                string query = "SELECT UyeID, AdSoyad, TCNo FROM Uyeler ORDER BY AdSoyad";

                using (SqlCommand cmd = new SqlCommand(query, SqlVariable.baglanti))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbUyeSecim.Items.Clear();
                    cmbUyeSecim.Items.Add("-- Üye Seçiniz --");

                    while (reader.Read())
                    {
                        
                        string item = $"{reader["AdSoyad"]} ({reader["TCNo"]}) - ID:{reader["UyeID"]}";
                        cmbUyeSecim.Items.Add(item);
                    }

                    reader.Close();
                }

                cmbUyeSecim.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata");
            }

        }
        private void KitaplarıComboyaDoldur()
        {
            try
            {
                SqlVariable.CheckConnection(SqlVariable.baglanti);

               
                string query = "SELECT KitapID, KitapAdi, Yazar, ISBN FROM Kitaplar WHERE Durum='Mevcut' ORDER BY KitapAdi";

                using (SqlCommand cmd = new SqlCommand(query, SqlVariable.baglanti))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbKitapSecim.Items.Clear();
                    cmbKitapSecim.Items.Add("-- Kitap Seçiniz --");

                    while (reader.Read())
                    {
                        
                        string item = $"{reader["KitapAdi"]} - {reader["Yazar"]} (ISBN: {reader["ISBN"]}) - ID:{reader["KitapID"]}";
                        cmbKitapSecim.Items.Add(item);
                    }

                    reader.Close();
                }

                cmbKitapSecim.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata");
            }
        }

        private void btnUyeYenile_Click(object sender, EventArgs e)
        {
            UyeleriComboyaDoldur();
        }

        private void btnKitapYenile_Click(object sender, EventArgs e)
        {
            KitaplarıComboyaDoldur ();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (cmbUyeSecim.SelectedIndex <= 0)
            {
                MessageBox.Show("Lütfen bir üye seçin!", "Uyarı");
                return;
            }

            if (cmbKitapSecim.SelectedIndex <= 0)
            {
                MessageBox.Show("Lütfen bir kitap seçin!", "Uyarı");
                return;
            }

            try
            {
                
                string uyeItem = cmbUyeSecim.SelectedItem.ToString();
                string kitapItem = cmbKitapSecim.SelectedItem.ToString();

                
                int uyeID = Convert.ToInt32(uyeItem.Substring(uyeItem.LastIndexOf("ID:") + 3));
                int kitapID = Convert.ToInt32(kitapItem.Substring(kitapItem.LastIndexOf("ID:") + 3));

                SqlVariable.CheckConnection(SqlVariable.baglanti);

                
                SqlTransaction transaction = SqlVariable.baglanti.BeginTransaction();

                try
                {
                    
                    string queryOdunc = @"INSERT INTO OduncKitaplar (KitapID, UyeID, OduncTarihi) 
                                 VALUES (@KitapID, @UyeID, @OduncTarihi)";

                    using (SqlCommand cmd = new SqlCommand(queryOdunc, SqlVariable.baglanti, transaction))
                    {
                        cmd.Parameters.AddWithValue("@KitapID", kitapID);
                        cmd.Parameters.AddWithValue("@UyeID", uyeID);
                        cmd.Parameters.AddWithValue("@OduncTarihi", dtpOduncTarihi.Value);
                        cmd.ExecuteNonQuery();
                    }

                   
                    string queryUpdate = "UPDATE Kitaplar SET Durum='Ödünçte' WHERE KitapID=@KitapID";

                    using (SqlCommand cmd = new SqlCommand(queryUpdate, SqlVariable.baglanti, transaction))
                    {
                        cmd.Parameters.AddWithValue("@KitapID", kitapID);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Kitap başarıyla ödünç verildi!", "Başarılı");

                   
                    OduncKitaplariListele();
                    KitaplarıComboyaDoldur();
                    RefreshPage1(); 

                  
                    cmbUyeSecim.SelectedIndex = 0;
                    cmbKitapSecim.SelectedIndex = 0;
                }
                catch
                {
                   
                    transaction.Rollback();
                    throw;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata");
            }
        }
        private void OduncKitaplariListele()
        {
            try
            {
                SqlVariable.CheckConnection(SqlVariable.baglanti);

               
                string query = @"
            SELECT 
                o.IslemID,
                u.AdSoyad AS 'Üye Adı',
                u.TCNo AS 'TC No',
                k.KitapAdi AS 'Kitap Adı',
                k.Yazar,
                o.OduncTarihi AS 'Ödünç Tarihi',
                o.TeslimTarihi AS 'Teslim Tarihi',
                CASE 
                    WHEN o.TeslimTarihi IS NULL THEN 'Ödünçte'
                    ELSE 'İade Edildi'
                END AS 'Durum'
            FROM OduncKitaplar o
            INNER JOIN Uyeler u ON o.UyeID = u.UyeID
            INNER JOIN Kitaplar k ON o.KitapID = k.KitapID
            ORDER BY o.IslemID DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, SqlVariable.baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOduncKitaplar.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata");
            }
        }

        private void dgvOduncKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOduncKitaplar.Rows[e.RowIndex];

               
                string durum = row.Cells["Durum"].Value.ToString();

                if (durum == "Ödünçte")
                {
                    txtIslemID.Text = row.Cells["IslemID"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Bu kitap zaten iade edilmiş!", "Bilgi");
                    txtIslemID.Clear();
                }
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIslemID.Text))
            {
                MessageBox.Show("Lütfen iade alınacak kitabı listeden seçin!", "Uyarı");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Kitap iade alınacak, emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    int islemID = Convert.ToInt32(txtIslemID.Text);

                    SqlVariable.CheckConnection(SqlVariable.baglanti);

                    
                    string queryGetKitapID = "SELECT KitapID FROM OduncKitaplar WHERE IslemID=@IslemID";
                    int kitapID = 0;

                    using (SqlCommand cmd = new SqlCommand(queryGetKitapID, SqlVariable.baglanti))
                    {
                        cmd.Parameters.AddWithValue("@IslemID", islemID);
                        kitapID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    SqlTransaction transaction = SqlVariable.baglanti.BeginTransaction();

                    try
                    {
                        
                        string queryIade = "UPDATE OduncKitaplar SET TeslimTarihi=@TeslimTarihi WHERE IslemID=@IslemID";

                        using (SqlCommand cmd = new SqlCommand(queryIade, SqlVariable.baglanti, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IslemID", islemID);
                            cmd.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                       
                        string queryUpdate = "UPDATE Kitaplar SET Durum='Mevcut' WHERE KitapID=@KitapID";

                        using (SqlCommand cmd = new SqlCommand(queryUpdate, SqlVariable.baglanti, transaction))
                        {
                            cmd.Parameters.AddWithValue("@KitapID", kitapID);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Kitap başarıyla iade alındı!", "Başarılı");

                       
                        OduncKitaplariListele();
                        KitaplarıComboyaDoldur();
                        RefreshPage1(); 

                        txtIslemID.Clear();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata");
                }
            }
        }
    }
}
