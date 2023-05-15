using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Dang_Nhap : Form
    {
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Save.Share_DbServices db = new Save.Share_DbServices();

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_DangNhap", db.con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@upass", txtPassword.Text);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        Save.User_Pass.uname = rd["username"].ToString();
                        Save.User_Pass.upass = rd["password"].ToString();

                        //string tk = rd["TaiKhoan"].ToString();
                        //string mk = rd["MatKhau"].ToString();

                        if (Save.User_Pass.upass == txtPassword.Text)
                        {
                            if (rd[3].ToString() .Equals("admin"))
                            {
                                Save.Share_DbServices.type = "Admin";                                                               
                            }
                            else if (rd[3].ToString() .Equals("user")) 
                            {
                                Save.Share_DbServices.type = "User";
                            }                             
                            MessageBox.Show("Đăng nhập thành công");
                            this.Hide();
                            var menu = new MainForm.Main();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dien_Thong_Tin dtt = new Dien_Thong_Tin();
            dtt.Show();
            
            this.Hide();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Save.Button.ButtonServices.CloseForm(this);
            Application.Exit();
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
    }
}
