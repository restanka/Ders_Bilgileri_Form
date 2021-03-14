
namespace DersBilgileri
{
    partial class Form1
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
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.cbKategorisi = new System.Windows.Forms.ComboBox();
            this.lbAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbIcerik = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.tbKredi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDersler.Location = new System.Drawing.Point(13, 13);
            this.dgvDersler.MultiSelect = false;
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(921, 221);
            this.dgvDersler.TabIndex = 0;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(254, 317);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 31);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(23, 263);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(159, 20);
            this.tbAdi.TabIndex = 2;
            // 
            // cbKategorisi
            // 
            this.cbKategorisi.FormattingEnabled = true;
            this.cbKategorisi.Location = new System.Drawing.Point(198, 262);
            this.cbKategorisi.Name = "cbKategorisi";
            this.cbKategorisi.Size = new System.Drawing.Size(135, 21);
            this.cbKategorisi.TabIndex = 3;
            // 
            // lbAdi
            // 
            this.lbAdi.AutoSize = true;
            this.lbAdi.Location = new System.Drawing.Point(23, 246);
            this.lbAdi.Name = "lbAdi";
            this.lbAdi.Size = new System.Drawing.Size(50, 13);
            this.lbAdi.TabIndex = 4;
            this.lbAdi.Text = "Ders Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İçeriği:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kredisi:";
            // 
            // rtbIcerik
            // 
            this.rtbIcerik.Location = new System.Drawing.Point(361, 262);
            this.rtbIcerik.Name = "rtbIcerik";
            this.rtbIcerik.Size = new System.Drawing.Size(554, 86);
            this.rtbIcerik.TabIndex = 5;
            this.rtbIcerik.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(173, 317);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 31);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.Location = new System.Drawing.Point(92, 317);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(75, 31);
            this.btnDetay.TabIndex = 1;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // tbKredi
            // 
            this.tbKredi.Location = new System.Drawing.Point(25, 328);
            this.tbKredi.Name = "tbKredi";
            this.tbKredi.Size = new System.Drawing.Size(44, 20);
            this.tbKredi.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 362);
            this.Controls.Add(this.tbKredi);
            this.Controls.Add(this.rtbIcerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAdi);
            this.Controls.Add(this.cbKategorisi);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.dgvDersler);
            this.Name = "Form1";
            this.Text = "Ders Bilgisi Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.ComboBox cbKategorisi;
        private System.Windows.Forms.Label lbAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbIcerik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.TextBox tbKredi;
    }
}

