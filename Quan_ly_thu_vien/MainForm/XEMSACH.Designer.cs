using System.Drawing;
using System;
using System.Windows.Forms;

namespace MainForm
{
    partial class XEMSACH
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            findb = new TextBox();
            button1 = new Button();
            backb = new Button();
            nameb = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            idb = new TextBox();
            label9 = new Label();
            cancel = new Button();
            delete = new Button();
            update = new Button();
            dateTimePicker1 = new DateTimePicker();
            cost = new TextBox();
            label8 = new Label();
            label7 = new Label();
            type = new TextBox();
            label6 = new Label();
            writter = new TextBox();
            label5 = new Label();
            countb = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 93);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 35);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 2;
            label1.Text = "xem sách";
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.view_book_gif1;
            pictureBox1.Location = new Point(266, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(175, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "tên sách";
            // 
            // findb
            // 
            findb.Location = new Point(278, 100);
            findb.Name = "findb";
            findb.Size = new Size(194, 27);
            findb.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(478, 98);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "REFESH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backb
            // 
            backb.Location = new Point(587, 98);
            backb.Name = "backb";
            backb.Size = new Size(94, 29);
            backb.TabIndex = 7;
            backb.Text = "BACK";
            backb.UseVisualStyleBackColor = true;
            backb.Click += backb_Click_1;
            // 
            // nameb
            // 
            nameb.Location = new Point(266, 20);
            nameb.Name = "nameb";
            nameb.Size = new Size(156, 27);
            nameb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(179, 22);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 0;
            label3.Text = "Tên sách:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(idb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cancel);
            panel2.Controls.Add(delete);
            panel2.Controls.Add(update);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(cost);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(type);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(writter);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(countb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(nameb);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 257);
            panel2.TabIndex = 8;
            // 
            // idb
            // 
            idb.Location = new Point(22, 81);
            idb.Name = "idb";
            idb.Size = new Size(126, 27);
            idb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(69, 43);
            label9.Name = "label9";
            label9.Size = new Size(30, 25);
            label9.TabIndex = 20;
            label9.Text = "ID";
            // 
            // cancel
            // 
            cancel.BackColor = Color.LightCoral;
            cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cancel.Location = new Point(656, 193);
            cancel.Name = "cancel";
            cancel.Size = new Size(105, 41);
            cancel.TabIndex = 19;
            cancel.Text = "thoát";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click_1;
            // 
            // delete
            // 
            delete.BackColor = Color.Yellow;
            delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(532, 193);
            delete.Name = "delete";
            delete.Size = new Size(97, 41);
            delete.TabIndex = 18;
            delete.Text = "xóa";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click_1;
            // 
            // update
            // 
            update.BackColor = Color.Chocolate;
            update.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(406, 193);
            update.Name = "update";
            update.Size = new Size(101, 41);
            update.TabIndex = 17;
            update.Text = "cập nhật";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(605, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 27);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.Value = new DateTime(2023, 3, 29, 14, 52, 9, 0);
            // 
            // cost
            // 
            cost.Location = new Point(605, 141);
            cost.Name = "cost";
            cost.Size = new Size(156, 27);
            cost.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(453, 143);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(81, 25);
            label8.TabIndex = 10;
            label8.Text = "Gíá tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(453, 81);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 8;
            label7.Text = "Ngày phát hành:";
            // 
            // type
            // 
            type.Location = new Point(605, 20);
            type.Name = "type";
            type.Size = new Size(156, 27);
            type.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(453, 19);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 6;
            label6.Text = "thể loại:";
            // 
            // writter
            // 
            writter.Location = new Point(266, 144);
            writter.Name = "writter";
            writter.Size = new Size(156, 27);
            writter.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(179, 146);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 4;
            label5.Text = "tác giả:";
            // 
            // countb
            // 
            countb.Location = new Point(266, 82);
            countb.Name = "countb";
            countb.Size = new Size(156, 27);
            countb.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(179, 84);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 2;
            label4.Text = "số lượng:";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ImeMode = ImeMode.NoControl;
            dataGridView2.Location = new Point(12, 133);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(773, 247);
            dataGridView2.TabIndex = 22;
            // 
            // XEMSACH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(789, 655);
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Controls.Add(backb);
            Controls.Add(button1);
            Controls.Add(findb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "XEMSACH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XEMSACH";
            Load += XEMSACH_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox findb;
        private Button button1;
        private Button backb;
        private TextBox nameb;
        private Label label3;
        private Panel panel2;
        private TextBox idb;
        private Label label9;
        private Button cancel;
        private Button delete;
        private Button update;
        private DateTimePicker dateTimePicker1;
        private TextBox cost;
        private Label label8;
        private Label label7;
        private TextBox type;
        private Label label6;
        private TextBox writter;
        private Label label5;
        private TextBox countb;
        private Label label4;
        private DataGridView dataGridView2;
    }
}