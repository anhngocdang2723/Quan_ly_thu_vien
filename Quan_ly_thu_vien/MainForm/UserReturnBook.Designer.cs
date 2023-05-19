namespace MainForm
{
    partial class UserReturnBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtbReturn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReaderID = new System.Windows.Forms.TextBox();
            this.txtBookIDa = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_return = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 204);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtbReturn
            // 
            this.BtbReturn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtbReturn.Location = new System.Drawing.Point(617, 325);
            this.BtbReturn.Name = "BtbReturn";
            this.BtbReturn.Size = new System.Drawing.Size(134, 32);
            this.BtbReturn.TabIndex = 18;
            this.BtbReturn.Text = "Trả sách";
            this.BtbReturn.UseVisualStyleBackColor = true;
            this.BtbReturn.Click += new System.EventHandler(this.BtbReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã độc giả:";
            // 
            // txtReaderID
            // 
            this.txtReaderID.Enabled = false;
            this.txtReaderID.Location = new System.Drawing.Point(204, 32);
            this.txtReaderID.Multiline = true;
            this.txtReaderID.Name = "txtReaderID";
            this.txtReaderID.Size = new System.Drawing.Size(96, 22);
            this.txtReaderID.TabIndex = 19;
            // 
            // txtBookIDa
            // 
            this.txtBookIDa.AutoSize = true;
            this.txtBookIDa.BackColor = System.Drawing.Color.Transparent;
            this.txtBookIDa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookIDa.Location = new System.Drawing.Point(467, 41);
            this.txtBookIDa.Name = "txtBookIDa";
            this.txtBookIDa.Size = new System.Drawing.Size(80, 23);
            this.txtBookIDa.TabIndex = 22;
            this.txtBookIDa.Text = "Mã sách:";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(570, 42);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(96, 22);
            this.txtBookID.TabIndex = 21;
            // 
            // dateReturn
            // 
            this.dateReturn.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Enabled = false;
            this.dateReturn.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReturn.Location = new System.Drawing.Point(184, 72);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(116, 18);
            this.dateReturn.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ngày trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Số lượng:";
            // 
            // quantity_return
            // 
            this.quantity_return.Enabled = false;
            this.quantity_return.Location = new System.Drawing.Point(570, 70);
            this.quantity_return.Multiline = true;
            this.quantity_return.Name = "quantity_return";
            this.quantity_return.Size = new System.Drawing.Size(96, 22);
            this.quantity_return.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã mượn:";
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.Enabled = false;
            this.txtBorrowID.Location = new System.Drawing.Point(570, 16);
            this.txtBorrowID.Multiline = true;
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.Size = new System.Drawing.Size(96, 22);
            this.txtBorrowID.TabIndex = 27;
            // 
            // UserReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBorrowID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity_return);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookIDa);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReaderID);
            this.Controls.Add(this.BtbReturn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserReturnBook";
            this.Text = "UserReturnBook";
            this.Load += new System.EventHandler(this.UserReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtbReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.Label txtBookIDa;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity_return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBorrowID;
    }
}