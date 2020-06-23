using System.ComponentModel;

namespace turksatdeneme_6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Form1(IContainer components)
        {
            this.components = components;
        }

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sayfa1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pcbVideo = new System.Windows.Forms.PictureBox();
            this.Sayfa2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Sayfa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideo)).BeginInit();
            this.Sayfa2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sayfa1);
            this.tabControl1.Controls.Add(this.Sayfa2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2059, 1109);
            this.tabControl1.TabIndex = 0;
            // 
            // Sayfa1
            // 
            this.Sayfa1.BackColor = System.Drawing.Color.Navy;
            this.Sayfa1.Controls.Add(this.pictureBox1);
            this.Sayfa1.Controls.Add(this.groupBox1);
            this.Sayfa1.Location = new System.Drawing.Point(4, 25);
            this.Sayfa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sayfa1.Name = "Sayfa1";
            this.Sayfa1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sayfa1.Size = new System.Drawing.Size(2051, 1080);
            this.Sayfa1.TabIndex = 0;
            this.Sayfa1.Text = " Sayfa1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnCek);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pcbVideo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1489, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera";
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.Color.Navy;
            this.btnCek.Location = new System.Drawing.Point(149, 372);
            this.btnCek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(95, 39);
            this.btnCek.TabIndex = 1;
            this.btnCek.Text = "Fotograf cek";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.Cek_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.Color.Navy;
            this.btnStop.Location = new System.Drawing.Point(283, 372);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 39);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Navy;
            this.btnStart.Location = new System.Drawing.Point(20, 372);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Baslat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 327);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // pcbVideo
            // 
            this.pcbVideo.Location = new System.Drawing.Point(5, 21);
            this.pcbVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbVideo.Name = "pcbVideo";
            this.pcbVideo.Size = new System.Drawing.Size(391, 281);
            this.pcbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVideo.TabIndex = 1;
            this.pcbVideo.TabStop = false;
            // 
            // Sayfa2
            // 
            this.Sayfa2.BackColor = System.Drawing.Color.Navy;
            this.Sayfa2.Controls.Add(this.dataGridView1);
            this.Sayfa2.Controls.Add(this.pictureBox2);
            this.Sayfa2.Location = new System.Drawing.Point(4, 25);
            this.Sayfa2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sayfa2.Name = "Sayfa2";
            this.Sayfa2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sayfa2.Size = new System.Drawing.Size(2051, 1080);
            this.Sayfa2.TabIndex = 1;
            this.Sayfa2.Text = "Sayfa2";
            this.Sayfa2.Click += new System.EventHandler(this.Sayfa2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1737, 242);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 400;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1902, 916);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "too";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.Sayfa1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideo)).EndInit();
            this.Sayfa2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sayfa1;
        private System.Windows.Forms.TabPage Sayfa2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbVideo;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}

