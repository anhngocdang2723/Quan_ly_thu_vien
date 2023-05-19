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
    public partial class Personal_Information : Form
    {
        public Personal_Information()
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
                //          db.con.Open();
                int readerID = (int)command.ExecuteScalar();
                //          db.con.Close();
                txtID.Text = readerID.ToString();
            }
            catch
            {
                MessageBox.Show("lỗi dữ liệu");
            }

        }

        private void Personal_Information_Load(object sender, EventArgs e)
        {
            db.con.Open();
            LoadData();
        }

        private void BtbBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string UpdateQuery = "Update Readers Set rname = @hoten, address = @Diachi, student_code = @MSV, phone_num = @SDT where readerID = @ID";
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, db.con);

                UpdateCommand.Parameters.AddWithValue("@ID", txtID.Text);
                UpdateCommand.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                UpdateCommand.Parameters.AddWithValue("@Diachi", txtDiaChi.Text);
                UpdateCommand.Parameters.AddWithValue("@MSV", txtMSV.Text);
                UpdateCommand.Parameters.AddWithValue("@SDT", txtSDT.Text);
                UpdateCommand.ExecuteNonQuery();

                LoadData();

                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            catch
            {
               MessageBox.Show("lỗi dữ liệu");
            }
            LoadData();
        }
    }
}
