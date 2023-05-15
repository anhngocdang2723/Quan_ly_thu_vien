using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace MainForm
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Save.Share_DbServices db = new Save.Share_DbServices();

            if (string.IsNullOrEmpty(txtOldPass.Text) || string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ");
                return;
            }

            try
            {
                using (db.con)
                {
                    string OldPass = txtOldPass.Text;

                    if (OldPass == Save.User_Pass.upass)
                    {
                        SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", db.con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        db.con.Open();
                        //string matkhaucu = txtMatKhauCu.Text;
                        cmd.Parameters.AddWithValue("@newpass", txtNewPass.Text);
                        cmd.Parameters.AddWithValue("@uname", Save.User_Pass.uname.Trim());

                        SqlDataReader rd = cmd.ExecuteReader();
                        //MessageBox.Show("Đăng kí thành công");
                        rd.Close();                        
                        MessageBox.Show("Đổi mật khẩu thành công. Đăng nhập lại.");     
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ sai! Vui lòng nhập lại");
                        txtOldPass.Clear();
                    }
                    //this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi không xác định, thực hiện lại sau.");
            }
            /*
            Save.Share_DbServices db = new Save.Share_DbServices();
            try
            {
                using (db.con) 
                {
                    string query = "UPDATE QuanLyTaiKhoan SET MatKhau = @matkhaumoi WHERE TaiKhoan = Save.User_Pass.taikhoan";

                    SqlCommand cmd = new SqlCommand(query,db.con);
                    string matkhaucu = txtMatKhauCu.Text;
                    string matkhaumoi = txtMatKhauMoi.Text;
                    //SqlDataReader rd = cmd.ExecuteReader();

                    if (matkhaucu == Save.User_Pass.matkhau)
                    {
                        //rd.Close();
                        query = "UPDATE QuanLyTaiKhoan SET MatKhau = @matkhaumoi WHERE TaiKhoan = Save.User_Pass.taikhoan";
                        cmd.Parameters.AddWithValue("@matkhaumoi", txtMatKhauMoi.Text);
                        MessageBox.Show("thanhcong");
                    }
                    else
                    {
                        MessageBox.Show("matkhaucu sai");
                    }
                }
            
            }
            catch (Exception )
            {
                MessageBox.Show("Loi");
            }
            */
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Save.Button.ButtonServices.CloseForm(this);
            var main = new MainForm.Main();
            main.Show();
        }
    }
}
