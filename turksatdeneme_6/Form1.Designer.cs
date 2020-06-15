namespace turksatdeneme_6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sayfa1 = new System.Windows.Forms.TabPage();
            this.Sayfa2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbVideo = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cek = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Sayfa1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sayfa1);
            this.tabControl1.Controls.Add(this.Sayfa2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2059, 1109);
            this.tabControl1.TabIndex = 0;
            // 
            // Sayfa1
            // 
            this.Sayfa1.BackColor = System.Drawing.Color.Navy;
            this.Sayfa1.Controls.Add(this.groupBox1);
            this.Sayfa1.Location = new System.Drawing.Point(4, 25);
            this.Sayfa1.Name = "Sayfa1";
            this.Sayfa1.Padding = new System.Windows.Forms.Padding(3);
            this.Sayfa1.Size = new System.Drawing.Size(2051, 1080);
            this.Sayfa1.TabIndex = 0;
            this.Sayfa1.Text = "Sayfa1";
            this.Sayfa1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Sayfa2
            // 
            this.Sayfa2.BackColor = System.Drawing.Color.MidnightBlue;
            this.Sayfa2.Location = new System.Drawing.Point(4, 25);
            this.Sayfa2.Name = "Sayfa2";
            this.Sayfa2.Padding = new System.Windows.Forms.Padding(3);
            this.Sayfa2.Size = new System.Drawing.Size(2051, 1080);
            this.Sayfa2.TabIndex = 1;
            this.Sayfa2.Text = "Sayfa2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.Cek);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pcbVideo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1489, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera";
            // 
            // pcbVideo
            // 
            this.pcbVideo.Location = new System.Drawing.Point(6, 21);
            this.pcbVideo.Name = "pcbVideo";
            this.pcbVideo.Size = new System.Drawing.Size(391, 280);
            this.pcbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVideo.TabIndex = 1;
            this.pcbVideo.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(20, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Baslat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(283, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cek
            // 
            this.Cek.BackColor = System.Drawing.Color.Navy;
            this.Cek.Location = new System.Drawing.Point(149, 372);
            this.Cek.Name = "Cek";
            this.Cek.Size = new System.Drawing.Size(95, 40);
            this.Cek.TabIndex = 1;
            this.Cek.Text = "Fotograf cek";
            this.Cek.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 935);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Sayfa1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sayfa1;
        private System.Windows.Forms.TabPage Sayfa2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbVideo;
        private System.Windows.Forms.Button Cek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

