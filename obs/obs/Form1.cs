
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace obs
{
    public partial class AnaForm : Form
    {
        
        private string connectionString = "Data Source=MÜZISYENN;Initial Catalog=OgrenciDersSecim;Integrated Security=True;Encrypt=False";

        public AnaForm()
        {
            InitializeComponent();
        }

        
        private void ListeleOgrenciler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Ogrenciler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewOgrenciler.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void ListeleDersler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Dersler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewDersler.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void EkleDers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Dersler (DersAdi, Kredi, Kontenjan) VALUES (@DersAdi, @Kredi, @Kontenjan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DersAdi", textBoxDersAdi.Text);
                        command.Parameters.AddWithValue("@Kredi", int.Parse(textBoxKredi.Text));
                        command.Parameters.AddWithValue("@Kontenjan", int.Parse(textBoxKontenjan.Text));

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ders başarıyla eklendi.");
                            ListeleDersler(); // Listeyi güncelle
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void SecDers(int ogrenciID, int dersID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    string kontenjanQuery = "SELECT Kontenjan, KayıtlıSayısı FROM Dersler WHERE DersID = @DersID";
                    SqlCommand kontenjanCommand = new SqlCommand(kontenjanQuery, connection);
                    kontenjanCommand.Parameters.AddWithValue("@DersID", dersID);

                    using (SqlDataReader reader = kontenjanCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int kontenjan = reader.GetInt32(0);
                            int kayitliSayisi = reader.GetInt32(1);

                            if (kayitliSayisi >= kontenjan)
                            {
                                MessageBox.Show("Ders kontenjanı dolu.");
                                return;
                            }
                        }
                    }

                    
                    string insertQuery = "INSERT INTO DersSecimleri (OgrenciID, DersID) VALUES (@OgrenciID, @DersID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        command.Parameters.AddWithValue("@DersID", dersID);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ders başarıyla seçildi.");
                        }
                    }

                    
                    string updateQuery = "UPDATE Dersler SET KayıtlıSayısı = KayıtlıSayısı + 1 WHERE DersID = @DersID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@DersID", dersID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void OnaylaDers(int dersSecimID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE DersSecimleri SET OnayDurumu = 'Onaylandı' WHERE DersSecimID = @DersSecimID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DersSecimID", dersSecimID);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ders seçimi onaylandı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        
        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            this.dersSecimleriTableAdapter.Fill(this.ogrenciDersSecimDataSet.DersSecimleri);
            
            this.ogrencilerTableAdapter.Fill(this.ogrenciDersSecimDataSet.Ogrenciler);
            
            this.danismanlarTableAdapter.Fill(this.ogrenciDersSecimDataSet.Danismanlar);
            
            this.ogrenciDanismanTableAdapter.Fill(this.ogrenciDersSecimDataSet.OgrenciDanisman);
           
            this.derslerTableAdapter.Fill(this.ogrenciDersSecimDataSet.Dersler);
            ListeleOgrenciler();
            ListeleDersler();
        }

        
        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            EkleDers();
        }

        
        private void buttonDersSec_Click(object sender, EventArgs e)
        {
            int ogrenciID = int.Parse(textBoxOgrenciID.Text);
            int dersID = int.Parse(textBoxDersID.Text);
            SecDers(ogrenciID, dersID);
        }

        
        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            int dersSecimID = int.Parse(textBoxDersSecimID.Text);
            OnaylaDers(dersSecimID);
        }
    }
}
