namespace GaleriOtomasyon
{
    partial class ServisBolumu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAracSec = new System.Windows.Forms.Button();
            this.cbPlaka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbMaliyet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbIsler = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbServisTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridServis = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTumServis = new System.Windows.Forms.DataGridView();
            this.btnTumRapor = new System.Windows.Forms.Button();
            this.btnTekServis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServis)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumServis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAracSec);
            this.groupBox1.Controls.Add(this.cbPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servis İşlemleri";
            // 
            // btnAracSec
            // 
            this.btnAracSec.Location = new System.Drawing.Point(74, 55);
            this.btnAracSec.Name = "btnAracSec";
            this.btnAracSec.Size = new System.Drawing.Size(142, 23);
            this.btnAracSec.TabIndex = 3;
            this.btnAracSec.Text = "Araç Seçin";
            this.btnAracSec.UseVisualStyleBackColor = true;
            this.btnAracSec.Click += new System.EventHandler(this.btnAracSec_Click);
            // 
            // cbPlaka
            // 
            this.cbPlaka.FormattingEnabled = true;
            this.cbPlaka.Location = new System.Drawing.Point(74, 28);
            this.cbPlaka.Name = "cbPlaka";
            this.cbPlaka.Size = new System.Drawing.Size(142, 21);
            this.cbPlaka.TabIndex = 2;
            this.cbPlaka.SelectedIndexChanged += new System.EventHandler(this.cbPlaka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Plaka:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlaka);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbMaliyet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtbIsler);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbServisTipi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakım İşlemleri";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(49, 28);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(13, 13);
            this.lblPlaka.TabIndex = 9;
            this.lblPlaka.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plaka:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(113, 322);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbMaliyet
            // 
            this.tbMaliyet.Location = new System.Drawing.Point(9, 296);
            this.tbMaliyet.Name = "tbMaliyet";
            this.tbMaliyet.Size = new System.Drawing.Size(207, 20);
            this.tbMaliyet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maliyet:";
            // 
            // rtbIsler
            // 
            this.rtbIsler.Location = new System.Drawing.Point(9, 112);
            this.rtbIsler.Name = "rtbIsler";
            this.rtbIsler.Size = new System.Drawing.Size(207, 163);
            this.rtbIsler.TabIndex = 3;
            this.rtbIsler.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yapılan İş:";
            // 
            // cbServisTipi
            // 
            this.cbServisTipi.FormattingEnabled = true;
            this.cbServisTipi.Location = new System.Drawing.Point(9, 67);
            this.cbServisTipi.Name = "cbServisTipi";
            this.cbServisTipi.Size = new System.Drawing.Size(207, 21);
            this.cbServisTipi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servis Tipi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(247, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 352);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Günlük Servis İşlemleri";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridServis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Günlük İşlemler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridServis
            // 
            this.dataGridServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServis.Location = new System.Drawing.Point(7, 7);
            this.dataGridServis.Name = "dataGridServis";
            this.dataGridServis.ReadOnly = true;
            this.dataGridServis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServis.Size = new System.Drawing.Size(672, 280);
            this.dataGridServis.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridTumServis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tüm İşlemler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTumServis
            // 
            this.dataGridTumServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTumServis.Location = new System.Drawing.Point(6, 6);
            this.dataGridTumServis.Name = "dataGridTumServis";
            this.dataGridTumServis.ReadOnly = true;
            this.dataGridTumServis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTumServis.Size = new System.Drawing.Size(672, 280);
            this.dataGridTumServis.TabIndex = 1;
            // 
            // btnTumRapor
            // 
            this.btnTumRapor.Location = new System.Drawing.Point(399, 370);
            this.btnTumRapor.Name = "btnTumRapor";
            this.btnTumRapor.Size = new System.Drawing.Size(140, 42);
            this.btnTumRapor.TabIndex = 3;
            this.btnTumRapor.Text = "Tümünü Raporla";
            this.btnTumRapor.UseVisualStyleBackColor = true;
            this.btnTumRapor.Click += new System.EventHandler(this.btnTumRapor_Click);
            // 
            // btnTekServis
            // 
            this.btnTekServis.Location = new System.Drawing.Point(253, 370);
            this.btnTekServis.Name = "btnTekServis";
            this.btnTekServis.Size = new System.Drawing.Size(140, 42);
            this.btnTekServis.TabIndex = 4;
            this.btnTekServis.Text = "Tek Raporla";
            this.btnTekServis.UseVisualStyleBackColor = true;
            this.btnTekServis.Click += new System.EventHandler(this.btnTekServis_Click);
            // 
            // ServisBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 546);
            this.Controls.Add(this.btnTekServis);
            this.Controls.Add(this.btnTumRapor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServisBolumu";
            this.Text = "Galeri Otomasyon - Servis Bölümü";
            this.Load += new System.EventHandler(this.ServisBolumu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServis)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumServis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAracSec;
        private System.Windows.Forms.ComboBox cbPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbMaliyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbIsler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbServisTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridServis;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTumRapor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridTumServis;
        private System.Windows.Forms.Button btnTekServis;
    }
}