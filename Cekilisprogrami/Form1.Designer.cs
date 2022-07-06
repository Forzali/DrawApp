namespace Cekilisprogrami
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtAdaylar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.nMiktar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCekilisSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇEKİLİŞ PROGRAMI";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // rtxtAdaylar
            // 
            this.rtxtAdaylar.Location = new System.Drawing.Point(20, 115);
            this.rtxtAdaylar.Name = "rtxtAdaylar";
            this.rtxtAdaylar.Size = new System.Drawing.Size(238, 260);
            this.rtxtAdaylar.TabIndex = 1;
            this.rtxtAdaylar.Text = "";
            this.rtxtAdaylar.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(89, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çekiliş Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Her Satıra Bir İsim Gelecek Şekilde Doldurun";
            // 
            // dtgList
            // 
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Location = new System.Drawing.Point(264, 204);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(223, 171);
            this.dtgList.TabIndex = 4;
            this.dtgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgList_CellContentClick);
            // 
            // btnCekilis
            // 
            this.btnCekilis.Location = new System.Drawing.Point(266, 115);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(87, 23);
            this.btnCekilis.TabIndex = 5;
            this.btnCekilis.Text = "Çekilişi Başlat";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.BtnCekilis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(400, 115);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 23);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Yeni Çekiliş";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // nMiktar
            // 
            this.nMiktar.Location = new System.Drawing.Point(264, 168);
            this.nMiktar.Name = "nMiktar";
            this.nMiktar.Size = new System.Drawing.Size(87, 20);
            this.nMiktar.TabIndex = 7;
            this.nMiktar.ValueChanged += new System.EventHandler(this.NMiktar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(397, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Katılan Sayısı";
            // 
            // lblCekilisSayi
            // 
            this.lblCekilisSayi.AutoSize = true;
            this.lblCekilisSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilisSayi.Location = new System.Drawing.Point(429, 168);
            this.lblCekilisSayi.Name = "lblCekilisSayi";
            this.lblCekilisSayi.Size = new System.Drawing.Size(21, 24);
            this.lblCekilisSayi.TabIndex = 9;
            this.lblCekilisSayi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 387);
            this.Controls.Add(this.lblCekilisSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nMiktar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtAdaylar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Çekiliş Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtAdaylar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.NumericUpDown nMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCekilisSayi;
    }
}

