namespace Khoa19
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoDau = new System.Windows.Forms.Label();
            this.lbSoCuoi = new System.Windows.Forms.Label();
            this.txtSoDau = new System.Windows.Forms.TextBox();
            this.txtSoCuoi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbTongDay = new System.Windows.Forms.Label();
            this.txtTongDay = new System.Windows.Forms.TextBox();
            this.lbTongNT = new System.Windows.Forms.Label();
            this.txtTongNT = new System.Windows.Forms.TextBox();
            this.lbTongChan = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(468, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng dãy số";
            // 
            // lbSoDau
            // 
            this.lbSoDau.AutoSize = true;
            this.lbSoDau.Location = new System.Drawing.Point(177, 209);
            this.lbSoDau.Name = "lbSoDau";
            this.lbSoDau.Size = new System.Drawing.Size(88, 32);
            this.lbSoDau.TabIndex = 1;
            this.lbSoDau.Text = "Số đầu";
            // 
            // lbSoCuoi
            // 
            this.lbSoCuoi.AutoSize = true;
            this.lbSoCuoi.Location = new System.Drawing.Point(693, 209);
            this.lbSoCuoi.Name = "lbSoCuoi";
            this.lbSoCuoi.Size = new System.Drawing.Size(93, 32);
            this.lbSoCuoi.TabIndex = 2;
            this.lbSoCuoi.Text = "Số cuối";
            // 
            // txtSoDau
            // 
            this.txtSoDau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoDau.Location = new System.Drawing.Point(294, 202);
            this.txtSoDau.Name = "txtSoDau";
            this.txtSoDau.Size = new System.Drawing.Size(234, 61);
            this.txtSoDau.TabIndex = 1;
            // 
            // txtSoCuoi
            // 
            this.txtSoCuoi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoCuoi.Location = new System.Drawing.Point(798, 202);
            this.txtSoCuoi.Name = "txtSoCuoi";
            this.txtSoCuoi.Size = new System.Drawing.Size(234, 61);
            this.txtSoCuoi.TabIndex = 2;
            // 
            // lbTongDay
            // 
            this.lbTongDay.AutoSize = true;
            this.lbTongDay.Location = new System.Drawing.Point(126, 400);
            this.lbTongDay.Name = "lbTongDay";
            this.lbTongDay.Size = new System.Drawing.Size(114, 32);
            this.lbTongDay.TabIndex = 1;
            this.lbTongDay.Text = "Tổng dãy";
            // 
            // txtTongDay
            // 
            this.txtTongDay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongDay.Location = new System.Drawing.Point(294, 400);
            this.txtTongDay.Name = "txtTongDay";
            this.txtTongDay.Size = new System.Drawing.Size(234, 61);
            this.txtTongDay.TabIndex = 4;
            // 
            // lbTongNT
            // 
            this.lbTongNT.AutoSize = true;
            this.lbTongNT.Location = new System.Drawing.Point(126, 550);
            this.lbTongNT.Name = "lbTongNT";
            this.lbTongNT.Size = new System.Drawing.Size(133, 32);
            this.lbTongNT.TabIndex = 1;
            this.lbTongNT.Text = "Tổng ng tố";
            // 
            // txtTongNT
            // 
            this.txtTongNT.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongNT.Location = new System.Drawing.Point(294, 550);
            this.txtTongNT.Name = "txtTongNT";
            this.txtTongNT.Size = new System.Drawing.Size(234, 61);
            this.txtTongNT.TabIndex = 6;
            // 
            // lbTongChan
            // 
            this.lbTongChan.AutoSize = true;
            this.lbTongChan.Location = new System.Drawing.Point(126, 475);
            this.lbTongChan.Name = "lbTongChan";
            this.lbTongChan.Size = new System.Drawing.Size(127, 32);
            this.lbTongChan.TabIndex = 1;
            this.lbTongChan.Text = "Tổng chẵn";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongChan.Location = new System.Drawing.Point(294, 475);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(234, 61);
            this.txtTongChan.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTinh.Location = new System.Drawing.Point(126, 302);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(150, 46);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 770);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoCuoi);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongNT);
            this.Controls.Add(this.lbTongChan);
            this.Controls.Add(this.txtTongDay);
            this.Controls.Add(this.lbTongNT);
            this.Controls.Add(this.txtSoDau);
            this.Controls.Add(this.lbTongDay);
            this.Controls.Add(this.lbSoCuoi);
            this.Controls.Add(this.lbSoDau);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbSoDau;
        private Label lbSoCuoi;
        private TextBox txtSoDau;
        private TextBox txtSoCuoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbTongDay;
        private TextBox txtTongDay;
        private Label lbTongNT;
        private TextBox txtTongNT;
        private Label lbTongChan;
        private TextBox txtTongChan;
        private Button btnTinh;
    }
}