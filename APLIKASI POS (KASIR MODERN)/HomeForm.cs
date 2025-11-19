using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APLIKASI_POS_KASIR_MODERN
{
    public partial class HomeForm : Form
    {
        private string _username;

        public HomeForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = _username;
            LoadKasirSummary();
        }

        private void LoadKasirSummary()
        {
            // Ganti connection string sesuai database Anda
            string connStr = "Data Source=.;Initial Catalog=POSDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        COUNT(*) AS TotalProdukTerjual,
                        SUM(TotalHarga) AS TotalPendapatan
                    FROM Penjualan
                    WHERE Kasir = @Kasir";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kasir", _username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalProduk.Text = reader["TotalProdukTerjual"].ToString();
                            lblPendapatan.Text = reader["TotalPendapatan"] != DBNull.Value ? 
                                Convert.ToDecimal(reader["TotalPendapatan"]).ToString("C") : "Rp 0";
                        }
                    }
                }
            }
        }
    }
}