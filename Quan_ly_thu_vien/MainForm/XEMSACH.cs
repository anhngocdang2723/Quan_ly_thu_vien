using Menu_Form;
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

namespace MainForm
{
    public partial class XEMSACH : Form
    {
        dbms sql = new dbms();
        //SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public XEMSACH()
        {
            InitializeComponent();
        }

        private void XEMSACH_Load(object sender, EventArgs e)
        {
            try
            {
                sql.cn.Open();
                dataGridView2.DataSource = sql.getData();
                sql.cn.Close();
                MessageBox.Show("khi cập nhật hoặc xóa cần lưu ý như sau:\n" +
                    "+cập nhật cần phải có nhập ID rồi sẽ sửa nội dung \n+xóa chỉ cần ID là đủ", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //xem toàn bộ sách
        void loaddata2()
        {

            try
            {
                /*sql.cmd = sql.cn.CreateCommand();
                sql.cmd.CommandText = "select * from Qlbook";
                sql.adapter.SelectCommand = sql.cmd;

                table.Clear();
                sql.adapter.Fill(table);*/

                dataGridView2.DataSource = sql.getData();

            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //xem sách theo tên
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.cn.Open();
                loaddata1();
                sql.cn.Close();
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        void loaddata1()
        {
            try
            {
                string ten = findb.Text;
                dataGridView2.DataSource = sql.getDatawithvalue(ten);
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //quay lại xem toàn bộ sách
        private void backb_Click_1(object sender, EventArgs e)
        {
            try
            {
                sql.cn.Open();
                dataGridView2.DataSource = sql.getData();
                sql.cn.Close();
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //tắt form
        private void cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //cập nhật
        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idb.Text == "")
                {
                    MessageBox.Show("trước khi cập nhật bạn phải chắc chắn là đã nhập ID cần cập nhật", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    int id = int.Parse(idb.Text);
                    string name = nameb.Text;
                    int count = int.Parse(countb.Text);
                    string tgia = writter.Text;
                    string tl = type.Text;
                    string date = dateTimePicker1.Text;
                    string gia = cost.Text;

                    sql.cn.Open();
                    sql.update(id, name, count, tgia, tl, date, gia);
                    sql.getData();
                    sql.cn.Close();

                    MessageBox.Show("dữ liệu đã được cập nhật", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //xóa
        private void delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idb.Text == "")
                {
                    MessageBox.Show("trước khi xóa bạn phải chắc chắn là đã nhập ID cần xóa", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = int.Parse(idb.Text);
                    sql.cn.Open();
                    sql.delete(id);
                    sql.getData();
                    sql.cn.Close();

                    MessageBox.Show("dữ liệu đã được xóa", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ox)
            {
                MessageBox.Show(ox.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
