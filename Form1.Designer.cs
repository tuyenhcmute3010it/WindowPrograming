namespace WindowsFormsApp1
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
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbcmnd = new System.Windows.Forms.Label();
            this.btnthem1 = new System.Windows.Forms.Button();
            this.btnxoa1 = new System.Windows.Forms.Button();
            this.btnsua1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(80, 38);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(40, 16);
            this.lbhoten.TabIndex = 0;
            this.lbhoten.Text = "hoten";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(80, 133);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(43, 16);
            this.lbdiachi.TabIndex = 1;
            this.lbdiachi.Text = "diachi";
            // 
            // lbcmnd
            // 
            this.lbcmnd.AutoSize = true;
            this.lbcmnd.Location = new System.Drawing.Point(80, 247);
            this.lbcmnd.Name = "lbcmnd";
            this.lbcmnd.Size = new System.Drawing.Size(40, 16);
            this.lbcmnd.TabIndex = 2;
            this.lbcmnd.Text = "cmnd";
            // 
            // btnthem1
            // 
            this.btnthem1.Location = new System.Drawing.Point(138, 495);
            this.btnthem1.Name = "btnthem1";
            this.btnthem1.Size = new System.Drawing.Size(75, 23);
            this.btnthem1.TabIndex = 3;
            this.btnthem1.Text = "them";
            this.btnthem1.UseVisualStyleBackColor = true;
            this.btnthem1.Click += new System.EventHandler(this.btnthem1_Click);
            // 
            // btnxoa1
            // 
            this.btnxoa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxoa1.Location = new System.Drawing.Point(382, 495);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(75, 23);
            this.btnxoa1.TabIndex = 4;
            this.btnxoa1.Text = "xoa";
            this.btnxoa1.UseVisualStyleBackColor = true;
            this.btnxoa1.Click += new System.EventHandler(this.btnxoa1_Click);
            // 
            // btnsua1
            // 
            this.btnsua1.Location = new System.Drawing.Point(745, 495);
            this.btnsua1.Name = "btnsua1";
            this.btnsua1.Size = new System.Drawing.Size(75, 23);
            this.btnsua1.TabIndex = 5;
            this.btnsua1.Text = "sua";
            this.btnsua1.UseVisualStyleBackColor = true;
            this.btnsua1.Click += new System.EventHandler(this.btnsua1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 328);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(198, 241);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(100, 22);
            this.txtcmnd.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(198, 127);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 22);
            this.txtdiachi.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(198, 38);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 22);
            this.txthoten.TabIndex = 9;
            // 
            // Form1
            // 
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.congly_vn_lang_que_xu_thanh_dep_ngo_ngang_qua_ong_kinh_nhiep_anh_hinh_anh040351964;
            this.ClientSize = new System.Drawing.Size(1185, 652);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsua1);
            this.Controls.Add(this.btnxoa1);
            this.Controls.Add(this.btnthem1);
            this.Controls.Add(this.lbhoten);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbcmnd);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbcmnd;
        private System.Windows.Forms.DataGridView gvHsinh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnthem1;
        private System.Windows.Forms.Button btnxoa1;
        private System.Windows.Forms.Button btnsua1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
    }
}

