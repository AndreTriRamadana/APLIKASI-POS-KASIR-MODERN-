namespace APLIKASI_POS_KASIR_MODERN
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblProduk;
        private System.Windows.Forms.Label lblTotalProduk;
        private System.Windows.Forms.Label lblPendapatanLabel;
        private System.Windows.Forms.Label lblPendapatan;

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblProduk = new System.Windows.Forms.Label();
            this.lblTotalProduk = new System.Windows.Forms.Label();
            this.lblPendapatanLabel = new System.Windows.Forms.Label();
            this.lblPendapatan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 25);
            this.lblWelcome.Text = "Selamat Datang,";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(170, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 25);
            // 
            // lblProduk
            // 
            this.lblProduk.AutoSize = true;
            this.lblProduk.Location = new System.Drawing.Point(30, 70);
            this.lblProduk.Name = "lblProduk";
            this.lblProduk.Size = new System.Drawing.Size(120, 20);
            this.lblProduk.Text = "Total Produk Terjual:";
            // 
            // lblTotalProduk
            // 
            this.lblTotalProduk.AutoSize = true;
            this.lblTotalProduk.Location = new System.Drawing.Point(170, 70);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Size = new System.Drawing.Size(16, 20);
            // 
            // lblPendapatanLabel
            // 
            this.lblPendapatanLabel.AutoSize = true;
            this.lblPendapatanLabel.Location = new System.Drawing.Point(30, 110);
            this.lblPendapatanLabel.Name = "lblPendapatanLabel";
            this.lblPendapatanLabel.Size = new System.Drawing.Size(120, 20);
            this.lblPendapatanLabel.Text = "Total Pendapatan:";
            // 
            // lblPendapatan
            // 
            this.lblPendapatan.AutoSize = true;
            this.lblPendapatan.Location = new System.Drawing.Point(170, 110);
            this.lblPendapatan.Name = "lblPendapatan";
            this.lblPendapatan.Size = new System.Drawing.Size(16, 20);
            // 
            // HomeForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblProduk);
            this.Controls.Add(this.lblTotalProduk);
            this.Controls.Add(this.lblPendapatanLabel);
            this.Controls.Add(this.lblPendapatan);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}