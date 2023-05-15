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
    public partial class Timnguoidoc : Form
    {
        private string constr = "Data Source=LAPTOP-EGJMCGFG\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        private SqlConnection connec;
        private SqlDataAdapter dataadapter;
        private DataTable dtQLND;
        //khai báo đối tượng truy vấn và cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        //khai báo đối tượng kết nối CSDL
        private SqlConnection mySqlConnection;
        public Timnguoidoc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void display()
        {
            string sSql = "SELECT * FROM QlNguoiDoc";
            dataadapter = new SqlDataAdapter(sSql, connec);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataadapter);
            dtQLND = new DataTable();
            dataadapter.Fill(dtQLND);
            dataGridView1.DataSource = dtQLND;
            // tạo đối tượng mySqlCommand
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timnguoidoc_Load(object sender, EventArgs e)
        {
            connec = new SqlConnection(constr);
            connec.Open();
            display();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn chắc có muốn thoát không?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //1. xác nhận có chắc chắn xóa không
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xóa dòng dữ liệu đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            //2. lấy dòng đang chọn
            int r = dataGridView1.CurrentRow.Index;

            //3. lấy mã id_nguoi_doc của dòng đang chọn
            string id_nguoi_doc = dataGridView1.Rows[r].Cells[0].Value.ToString();

            //4. định nghĩa câu lệnh SQL xóa dữ liệu
            string sSql = "DELETE FROM Categories WHERE CategoryID = " + id_nguoi_doc;

            //5. xóa dữ liệu
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();

            //6. truy vấn lại dữ liệu để hienr thị trên lưới
            display();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txttnd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtidnd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
