namespace Khoa19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnNhan = new System.Windows.Forms.Button();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.phepTinh = new System.Windows.Forms.Label();
            this.lbSoThuNhat = new System.Windows.Forms.Label();
            this.lbSoThuHai = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(611, 148);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(517, 39);
            this.txtSoThuNhat.TabIndex = 0;
            this.txtSoThuNhat.TextChanged += new System.EventHandler(this.txtSoThuNhat_TextChanged);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(611, 429);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(150, 46);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTru_MouseClick);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(985, 429);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(158, 46);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChia_MouseClick);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(611, 337);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(517, 39);
            this.txtKetQua.TabIndex = 2;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(796, 429);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(150, 46);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Nhân ";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNhan_MouseClick);
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(611, 242);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(517, 39);
            this.txtSoThuHai.TabIndex = 4;
            this.txtSoThuHai.TextChanged += new System.EventHandler(this.txtSoThuHai_TextChanged);
            // 
            // phepTinh
            // 
            this.phepTinh.AutoSize = true;
            this.phepTinh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.phepTinh.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phepTinh.Location = new System.Drawing.Point(712, 37);
            this.phepTinh.Name = "phepTinh";
            this.phepTinh.Size = new System.Drawing.Size(416, 72);
            this.phepTinh.TabIndex = 6;
            this.phepTinh.Text = "Máy tính cơ bản";
            // 
            // lbSoThuNhat
            // 
            this.lbSoThuNhat.AutoSize = true;
            this.lbSoThuNhat.Location = new System.Drawing.Point(475, 155);
            this.lbSoThuNhat.Name = "lbSoThuNhat";
            this.lbSoThuNhat.Size = new System.Drawing.Size(139, 32);
            this.lbSoThuNhat.TabIndex = 7;
            this.lbSoThuNhat.Text = "Số thứ nhất";
            // 
            // lbSoThuHai
            // 
            this.lbSoThuHai.AutoSize = true;
            this.lbSoThuHai.Location = new System.Drawing.Point(475, 249);
            this.lbSoThuHai.Name = "lbSoThuHai";
            this.lbSoThuHai.Size = new System.Drawing.Size(123, 32);
            this.lbSoThuHai.TabIndex = 8;
            this.lbSoThuHai.Text = "Số thứ hai";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(475, 344);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(96, 32);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "Kết quả";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(428, 429);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(150, 46);
            this.btnTong.TabIndex = 10;
            this.btnTong.Text = "Cộng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 802);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbSoThuHai);
            this.Controls.Add(this.lbSoThuNhat);
            this.Controls.Add(this.phepTinh);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.txtSoThuNhat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTong;
        private TextBox txtSoThuNhat;
        private Button btnTru;
        private Button btnChia;
        private TextBox txtKetQua;
        private Button btnNhan;
        private TextBox txtSoThuHai;
        private Label phepTinh;
        private Label lbSoThuNhat;
        private Label lbSoThuHai;
        private Label lbKetQua;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}