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
    public partial class Dien_Thong_Tin : Form
    {
        Save.Share_DbServices db = new Save.Share_DbServices();
        public Dien_Thong_Tin()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            Save.Share_DbServices db = new Save.Share_DbServices();

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtStudent_Code.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone_Num.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_DienThongTin", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@scode", txtStudent_Code.Text);
                    cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@pnum", txtPhone_Num.Text);
                                        
                    SqlDataReader rd = cmd.ExecuteReader();
                    Dang_Nhap dn = new Dang_Nhap();
                    //Dang_Ki dk = new Dang_Ki();
                    this.Close();
                    dn.Show();
                    MessageBox.Show("Đăng kí tài khoản thành công! Đăng nhập lại.", "Thông báo");

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 && ex.State == 1)
                {
                    if (ex.Message.Contains("Ho ten da ton tai"))
                    {
                        MessageBox.Show("Họ tên đã tồn tại. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Contains("Ma sinh vien da ton tai"))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Contains("So dien thoai da ton tai"))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm thông tin. Vui lòng thử lại sau.", "Thông báo");
                }
            }
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtStudent_Code.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone_Num.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Thông tin sẽ bị xoá", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    txtName.Clear();
                    txtStudent_Code.Clear();
                    txtAddress.Clear();
                    txtPhone_Num.Clear();
                }
                else return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Save.Button.ButtonServices.CloseForm(this);
            Dang_Nhap dn = new Dang_Nhap();
            dn.Show();

        }
    }
}
