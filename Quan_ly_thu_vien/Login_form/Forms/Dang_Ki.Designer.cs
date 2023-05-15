namespace Login_form
{
    partial class Dang_Ki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dang_Ki));
            this.gradient_Panel2 = new Login_form.Gradient_Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradient_Panel1 = new Login_form.Gradient_Panel();
            this.gradient_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradient_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient_Panel2
            // 
            this.gradient_Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gradient_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradient_Panel2.ColorButtom = System.Drawing.Color.Empty;
            this.gradient_Panel2.ColorTop = System.Drawing.Color.Empty;
            this.gradient_Panel2.Controls.Add(this.btnThoat);
            this.gradient_Panel2.Location = new System.Drawing.Point(12, 12);
            this.gradient_Panel2.Name = "gradient_Panel2";
            this.gradient_Panel2.Size = new System.Drawing.Size(476, 526);
            this.gradient_Panel2.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(423, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.Location = new System.Drawing.Point(153, 271);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(258, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Location = new System.Drawing.Point(153, 337);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatKhau_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangKi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(310, 443);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(101, 40);
            this.btnDangKi.TabIndex = 7;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienMatKhau.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienMatKhau.ForeColor = System.Drawing.Color.Transparent;
            this.btnHienMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnHienMatKhau.Image")));
            this.btnHienMatKhau.Location = new System.Drawing.Point(415, 334);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(56, 35);
            this.btnHienMatKhau.TabIndex = 9;
            this.btnHienMatKhau.UseVisualStyleBackColor = false;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradient_Panel1.ColorButtom = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.gradient_Panel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.gradient_Panel1.Controls.Add(this.pictureBox1);
            this.gradient_Panel1.Controls.Add(this.btnHienMatKhau);
            this.gradient_Panel1.Controls.Add(this.btnDangKi);
            this.gradient_Panel1.Controls.Add(this.label1);
            this.gradient_Panel1.Controls.Add(this.txtPassword);
            this.gradient_Panel1.Controls.Add(this.label2);
            this.gradient_Panel1.Controls.Add(this.txtUsername);
            this.gradient_Panel1.Controls.Add(this.gradient_Panel2);
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient_Panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 0);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.Size = new System.Drawing.Size(500, 550);
            this.gradient_Panel1.TabIndex = 11;
            // 
            // Dang_Ki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.gradient_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dang_Ki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dang_Ki";
            this.gradient_Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradient_Panel1.ResumeLayout(false);
            this.gradient_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient_Panel gradient_Panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Gradient_Panel gradient_Panel1;
    }
}