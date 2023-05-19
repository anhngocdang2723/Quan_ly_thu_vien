using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class UserReturnBook : Form
    {
        public UserReturnBook()
        {
            InitializeComponent();
        }
        Save.Share_DbServices db = new Save.Share_DbServices();
        public void LoadData()
        {
            try
            {
                // lấy readerID
                string query = "SELECT readerID FROM accounts WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, db.con);
                command.Parameters.AddWithValue("@Username", Save.User_Pass.uname);
                int readerID = (int)command.ExecuteScalar();
                txtReaderID.Text = readerID.ToString();

                // hiển thị
                string sqlSelect = "Select Br.borrowID as N'Mã phiếu', R.readerID as N'Mã độc giả', R.rname as N'Tên độc giả', B.bookID as N'Mã sách', B.bname as N'Tên sách', Br.borrow_date as N'Ngày mượn', Br.due_date as N'Ngày đến hạn', Br.quantity_borrowed as N'Số lượng'\r\nFrom Borrows Br\r\nJoin Books B on B.bookID = Br.bookID\r\nJoin Readers R On R.ReaderID = Br.readerID\r\nWhere Br.readerID = @readerID";
                SqlCommand cmd = new SqlCommand(sqlSelect, db.con);
                cmd.Parameters.AddWithValue("@readerID", txtReaderID.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("lỗi dữ liệu");
            }

        }
        private void UserReturnBook_Load(object sender, EventArgs e)
        {
            db.con.Open();
            LoadData();
        }

        private void BtbReturn_Click(object sender, EventArgs e)
        {
            //delete
            string sqlDelete = "Delete from Borrows where readerID = @readerID and bookID = @bookID";
            SqlCommand cmdDel = new SqlCommand(sqlDelete, db.con);
            cmdDel.Parameters.AddWithValue("@bookID", txtBookID.Text);
            cmdDel.Parameters.AddWithValue("@readerID", txtReaderID.Text);
            SqlDataReader reader = cmdDel.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;      

           //select
            string sqlSelect = "Select Br.borrowID as N'Mã phiếu', R.readerID as N'Mã độc giả', R.rname as N'Tên độc giả', B.bookID as N'Mã sách', B.bname as N'Tên sách', Br.borrow_date as N'Ngày mượn', Br.due_date as N'Ngày đến hạn', Br.quantity_borrowed as N'Số lượng'\r\nFrom Borrows Br\r\nJoin Books B on B.bookID = Br.bookID\r\nJoin Readers R On R.ReaderID = Br.readerID\r\nWhere Br.readerID = @readerID";
            SqlCommand cmd = new SqlCommand(sqlSelect, db.con);
            cmd.Parameters.AddWithValue("@bookID", txtBookID.Text);
            cmd.Parameters.AddWithValue("@readerID", txtReaderID.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            /*
            //insert vào return
            string sqlInsert = "Insert into returns values borowID = @borrowID, return_date = @return, quantity_return = @quantity, late_fee = '0'";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, db.con);
            cmdInsert.Parameters.AddWithValue("@borrowID", txtBorrowID.Text);
            DateTime returnDate = DateTime.Now;
            cmdInsert.Parameters.AddWithValue("@return", returnDate);
            cmdInsert.Parameters.AddWithValue("@quantity", quantity_return.Text);
            SqlDataReader readerInsert = cmdInsert.ExecuteReader();
            DataTable dataTableInsert = new DataTable();
            dataTable.Load(readerInsert);
            dataGridView1.DataSource = dataTableInsert;
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtBookID.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            quantity_return.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtBorrowID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }
    }
}
