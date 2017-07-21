namespace GaleriOtomasyon
{
    partial class KullaniciImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridImport = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.BtnKayitEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridImport
            // 
            this.dataGridImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImport.Location = new System.Drawing.Point(12, 12);
            this.dataGridImport.Name = "dataGridImport";
            this.dataGridImport.Size = new System.Drawing.Size(707, 261);
            this.dataGridImport.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 279);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(166, 50);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "Excel\'den Al";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // BtnKayitEkle
            // 
            this.BtnKayitEkle.Location = new System.Drawing.Point(184, 279);
            this.BtnKayitEkle.Name = "BtnKayitEkle";
            this.BtnKayitEkle.Size = new System.Drawing.Size(166, 50);
            this.BtnKayitEkle.TabIndex = 9;
            this.BtnKayitEkle.Text = "Kayıt Ekle";
            this.BtnKayitEkle.UseVisualStyleBackColor = true;
            this.BtnKayitEkle.Click += new System.EventHandler(this.BtnKayitEkle_Click);
            // 
            // KullaniciImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 366);
            this.Controls.Add(this.BtnKayitEkle);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dataGridImport);
            this.Name = "KullaniciImport";
            this.Text = "KullaniciImport";
            this.Load += new System.EventHandler(this.KullaniciImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridImport;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button BtnKayitEkle;
    }
}