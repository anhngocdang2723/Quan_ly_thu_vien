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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainForm
{
    public partial class UserBorrowBook : Form
    {
        Save.Share_DbServices db = new Save.Share_DbServices();
        public void LoadData()
        {
            //db.con.Open();
            /*
            var query = from Books in db.con.Books
                        select new
                        {
                            Mã_sách = Books.bookID,
                            Tên_sách = Books.bname,
                            Thể_Loại = Books.title,
                            Tác_Giả = Books.author,
                            Năm_Phát_Hành = Books.year_publish,
                            Số_lượng = Books.quantity
                        };
            DataTable dt = query.CopytodataTable();
            dataGridView1.DataSource = dt;
            */
            try
            {
                string sqlSelect = "Select B.bookID as N'Mã sách', B.bname as N'Tên sách', B.title as N'Thể loại', B.author as N'Tác giả',B.year_published as N'Năm phát hành', B.quantity as N'Số lượng'\r\nFrom Books B";
                SqlCommand cmd = new SqlCommand(sqlSelect, db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                // lấy readerID
                string query = "SELECT readerID FROM accounts WHERE username = @Username";
                SqlCommand command = new SqlCommand(query, db.con);
                command.Parameters.AddWithValue("@Username", Save.User_Pass.uname);
                //          db.con.Open();
                int readerID = (int)command.ExecuteScalar();
                //          db.con.Close();
                txtReaderID.Text = readerID.ToString();

                comboBox1.Text = "Tên sách";
            }
            catch
            {
                MessageBox.Show("lỗi dữ liệu");
            }

        }
        public UserBorrowBook()
        {
            InitializeComponent();
        }

        private void UserBorrowBook_Load(object sender, EventArgs e)
        {
            db.con.Open();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtBookID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int readerID = int.Parse(txtReaderID.Text);
                int bookID = int.Parse(txtBookID.Text);
                DateTime borrowDate = DateTime.Now;
                DateTime returnDate = dateReturn.Value;
                int quantity = int.Parse(txtQuantity.Text);

                string insertQuery = "INSERT INTO borrows ( bookID,  readerID, borrow_date, due_date, quantity_borrowed) VALUES ( @bookID,  @readerID,  @borrowDate, @dueDate, @quantity_borrowed)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, db.con);

                insertCommand.Parameters.AddWithValue("@bookID", bookID);
                insertCommand.Parameters.AddWithValue("@readerID", readerID);
                insertCommand.Parameters.AddWithValue("@borrowDate", borrowDate);
                insertCommand.Parameters.AddWithValue("@dueDate", returnDate);
                insertCommand.Parameters.AddWithValue("@quantity_borrowed", quantity);
                insertCommand.ExecuteNonQuery();

                LoadData();

                MessageBox.Show("Mượn sách thành công!");

                txtBookID.Clear();
                dateReturn.Refresh();
                txtQuantity.Clear();
                txtTuKhoa.Clear();
                comboBox1.Refresh();
            }
            catch
            {
                MessageBox.Show("lỗi dữ liệu");
            }
            LoadData();
        }
    }
}
