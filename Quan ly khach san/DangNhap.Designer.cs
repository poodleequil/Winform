﻿
namespace Quan_ly_khach_san
{
    partial class fDangNhap
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
            this.txMatKhau = new System.Windows.Forms.TextBox();
            this.txTaiKhoan = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txMatKhau
            // 
            this.txMatKhau.Location = new System.Drawing.Point(132, 148);
            this.txMatKhau.Name = "txMatKhau";
            this.txMatKhau.Size = new System.Drawing.Size(140, 20);
            this.txMatKhau.TabIndex = 0;
            // 
            // txTaiKhoan
            // 
            this.txTaiKhoan.Location = new System.Drawing.Point(132, 106);
            this.txTaiKhoan.Name = "txTaiKhoan";
            this.txTaiKhoan.Size = new System.Drawing.Size(140, 20);
            this.txTaiKhoan.TabIndex = 1;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(12, 214);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(100, 30);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(12, 106);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(84, 19);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(13, 146);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(78, 19);
            this.lbMatKhau.TabIndex = 5;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txTaiKhoan);
            this.Controls.Add(this.txMatKhau);
            this.Name = "fDangNhap";
            this.Text = "Dang nhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMatKhau;
        private System.Windows.Forms.TextBox txTaiKhoan;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
    }
}

