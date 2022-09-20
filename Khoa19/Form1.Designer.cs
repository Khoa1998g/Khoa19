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
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.phepTinh = new System.Windows.Forms.Label();
            this.lbSoThuNhat = new System.Windows.Forms.Label();
            this.lbSoThuHai = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(165, 150);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(517, 39);
            this.txtSoThuNhat.TabIndex = 0;
            this.txtSoThuNhat.TextChanged += new System.EventHandler(this.txtSoThuNhat_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(165, 339);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(517, 39);
            this.txtKetQua.TabIndex = 2;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(165, 244);
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
            this.phepTinh.Location = new System.Drawing.Point(266, 39);
            this.phepTinh.Name = "phepTinh";
            this.phepTinh.Size = new System.Drawing.Size(416, 72);
            this.phepTinh.TabIndex = 6;
            this.phepTinh.Text = "Máy tính cơ bản";
            // 
            // lbSoThuNhat
            // 
            this.lbSoThuNhat.AutoSize = true;
            this.lbSoThuNhat.Location = new System.Drawing.Point(29, 157);
            this.lbSoThuNhat.Name = "lbSoThuNhat";
            this.lbSoThuNhat.Size = new System.Drawing.Size(139, 32);
            this.lbSoThuNhat.TabIndex = 7;
            this.lbSoThuNhat.Text = "Số thứ nhất";
            // 
            // lbSoThuHai
            // 
            this.lbSoThuHai.AutoSize = true;
            this.lbSoThuHai.Location = new System.Drawing.Point(29, 251);
            this.lbSoThuHai.Name = "lbSoThuHai";
            this.lbSoThuHai.Size = new System.Drawing.Size(123, 32);
            this.lbSoThuHai.TabIndex = 8;
            this.lbSoThuHai.Text = "Số thứ hai";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(29, 346);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(96, 32);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "Kết quả";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cong",
            "Tru",
            "Nhan",
            "Chia"});
            this.comboBox1.Location = new System.Drawing.Point(771, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 40);
            this.comboBox1.TabIndex = 10;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(771, 237);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(150, 46);
            this.btnTinh.TabIndex = 11;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 572);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbSoThuHai);
            this.Controls.Add(this.lbSoThuNhat);
            this.Controls.Add(this.phepTinh);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoThuNhat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSoThuNhat;
        private TextBox txtKetQua;
        private TextBox txtSoThuHai;
        private Label phepTinh;
        private Label lbSoThuNhat;
        private Label lbSoThuHai;
        private Label lbKetQua;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button btnTinh;
        private ComboBox comboBox1;
    }
}