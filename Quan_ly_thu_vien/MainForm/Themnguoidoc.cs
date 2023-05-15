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
    public partial class Themnguoidoc : Form
    {
        private string conStr = @"Data Source=LAPTOP-EGJMCGFG\SQLEXPRESS;Initial Catalog = QuanLyThuVien; Integrated Security = True";
        private SqlConnection MySqlConnection;
        private SqlDataAdapter MySqlDataAdapter;
        private SqlCommand MySqlCommand;
        private DataTable dtQlND;
        public Themnguoidoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection = new SqlConnection(conStr);
            MySqlConnection.Open();
            MySqlCommand = MySqlConnection.CreateCommand();
            string insert = "insert into QlNguoiDoc values(@id,@name,@sdt,@diac,@ndk,@nhh)";
            MySqlCommand.Parameters.AddWithValue("@id", txtidnd.Text);
            MySqlCommand.Parameters.AddWithValue("@name", txttnd.Text);
            MySqlCommand.Parameters.AddWithValue("@sdt", txtsdt.Text);
            MySqlCommand.Parameters.AddWithValue("@diac", txtdc.Text);
            MySqlCommand.Parameters.AddWithValue("@ndk", txtndk.Text);
            MySqlCommand.Parameters.AddWithValue("@nhh", txtnhh.Text);
            MySqlCommand.CommandText = insert;
            MySqlCommand.ExecuteNonQuery();
            MySqlConnection.Close();
            MessageBox.Show("dữ liệu đã được nhập!", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txttnd.Clear();
            txtidnd.Clear();
            txtsdt.Clear();
            txtdc.Clear();
            txtndk.Clear();
            txtnhh.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn chắc có muốn thoát không?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
