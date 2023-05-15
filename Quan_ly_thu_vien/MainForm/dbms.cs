using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Menu_Form
{
    internal class dbms
    {
        public string str = @"Data Source=MAYTINH\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public dbms()
        {
            cn = new SqlConnection(str);
        }
        public DataTable getData()
        {
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "select * from Qlbook";
                adapter.SelectCommand = cmd;

                table.Clear();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable getDatawithvalue(string value)
        {
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "select * from Qlbook where ten_sach=@ten";
                cmd.Parameters.AddWithValue("@ten", value);

                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void insert(string ten, int soluong, string tgia, string tl, string ngayph, string gia)
        {
            try
            {
                cmd = cn.CreateCommand();
                //parameter
                string insert = "exec nhap2 @name,@count,@writer,@type,@date,@cost";
                cmd.Parameters.AddWithValue("@name", ten);
                cmd.Parameters.AddWithValue("@count", soluong);
                cmd.Parameters.AddWithValue("@writer", tgia);
                cmd.Parameters.AddWithValue("@type", tl);
                cmd.Parameters.AddWithValue("@date", ngayph);
                cmd.Parameters.AddWithValue("@cost", gia);
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public void update(int id, string ten, int soluong, string tgia, string tl, string ngayph, string gia)
        {
            try
            {
                string update = "update Qlbook set ten_sach=@name,so_luong=@count,tac_gia=@writer,the_loai=@type,ngay_phat_hanh=@date,gia=@cost where ID_sach=@id";
                cmd = new SqlCommand(update, cn);
                //parameter
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", ten);
                cmd.Parameters.AddWithValue("@count", soluong);
                cmd.Parameters.AddWithValue("@writer", tgia);
                cmd.Parameters.AddWithValue("@type", tl);
                cmd.Parameters.AddWithValue("@date", ngayph);
                cmd.Parameters.AddWithValue("@cost", gia);
                //thực thi
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public void delete(int id)
        {
            try
            {
                cmd = new SqlCommand("delete Qlbook where ID_sach=@id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
