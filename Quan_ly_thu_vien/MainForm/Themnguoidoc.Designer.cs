using System.Windows.Forms;

namespace MainForm
{
    partial class Themnguoidoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluuthongtin = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.txtnhh = new System.Windows.Forms.TextBox();
            this.txtndk = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtidnd = new System.Windows.Forms.TextBox();
            this.txttnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm người đọc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 66);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnluuthongtin);
            this.panel2.Controls.Add(this.btnlamlai);
            this.panel2.Controls.Add(this.txtnhh);
            this.panel2.Controls.Add(this.txtndk);
            this.panel2.Controls.Add(this.txtdc);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.txtidnd);
            this.panel2.Controls.Add(this.txttnd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(190, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 227);
            this.panel2.TabIndex = 2;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(312, 176);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(81, 31);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluuthongtin
            // 
            this.btnluuthongtin.Location = new System.Drawing.Point(203, 176);
            this.btnluuthongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnluuthongtin.Name = "btnluuthongtin";
            this.btnluuthongtin.Size = new System.Drawing.Size(81, 31);
            this.btnluuthongtin.TabIndex = 13;
            this.btnluuthongtin.Text = "Lưu thông tin";
            this.btnluuthongtin.UseVisualStyleBackColor = true;
            this.btnluuthongtin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(94, 176);
            this.btnlamlai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(81, 31);
            this.btnlamlai.TabIndex = 12;
            this.btnlamlai.Text = "Làm lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // txtnhh
            // 
            this.txtnhh.Location = new System.Drawing.Point(130, 138);
            this.txtnhh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnhh.Name = "txtnhh";
            this.txtnhh.Size = new System.Drawing.Size(264, 20);
            this.txtnhh.TabIndex = 11;
            // 
            // txtndk
            // 
            this.txtndk.Location = new System.Drawing.Point(130, 112);
            this.txtndk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtndk.Name = "txtndk";
            this.txtndk.Size = new System.Drawing.Size(264, 20);
            this.txtndk.TabIndex = 10;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(130, 87);
            this.txtdc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(264, 20);
            this.txtdc.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(130, 61);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(264, 20);
            this.txtsdt.TabIndex = 8;
            // 
            // txtidnd
            // 
            this.txtidnd.Location = new System.Drawing.Point(130, 35);
            this.txtidnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidnd.Name = "txtidnd";
            this.txtidnd.Size = new System.Drawing.Size(264, 20);
            this.txtidnd.TabIndex = 7;
            // 
            // txttnd
            // 
            this.txttnd.Location = new System.Drawing.Point(130, 10);
            this.txttnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttnd.Name = "txttnd";
            this.txttnd.Size = new System.Drawing.Size(264, 20);
            this.txttnd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày hết hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID người đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người dùng";
            // 
            // Themnguoidoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 296);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Themnguoidoc";
            this.Text = "Themnguoidoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnthoat;
        private Button btnluuthongtin;
        private Button btnlamlai;
        private TextBox txtnhh;
        private TextBox txtndk;
        private TextBox txtdc;
        private TextBox txtsdt;
        private TextBox txtidnd;
        private TextBox txttnd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}