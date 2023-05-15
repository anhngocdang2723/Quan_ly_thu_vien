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

namespace Login_form
{
    public partial class Dang_Ki : Form
    {
        public Dang_Ki()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Save.Share_DbServices db = new Save.Share_DbServices();

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_ThemTaiKhoan", db.con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@upass", txtPassword.Text);

                    SqlDataReader rd = cmd.ExecuteReader();                    
                    MessageBox.Show("Đăng kí thành công","Thông báo",MessageBoxButtons.OK);

                    this.Hide();
                    Dang_Nhap dn = new Dang_Nhap();
                    dn.Show();

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Save.Button.ButtonServices.CloseForm(this);
            Dang_Nhap dn = new Dang_Nhap();
            dn.Show();
        }
    }
}
