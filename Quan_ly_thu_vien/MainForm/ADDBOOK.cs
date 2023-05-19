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
    public partial class ADDBOOK : Form
    {
        dbms sql = new dbms();
        public ADDBOOK()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (LinqDataContext dt = new LinqDataContext())
            {
                try
                {
                    Book qlbook = new Book();

                    qlbook.bookID = int.Parse(idb.Text);
                    qlbook.name = tenb.Text;
                    qlbook.title = titleb.Text;
                    qlbook.author = tacgiab.Text;
                    qlbook.year_published = int.Parse(namb.Text);
                    qlbook.quantity = int.Parse(slb.Text);

                    dt.Books.InsertOnSubmit(qlbook);

                    dt.SubmitChanges();
                    MessageBox.Show("dữ liệu đã được nhập", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                /*string bname = nameb.Text;
            int bcount = int.Parse(countb.Text);
            string bwriter = writerb.Text;
            string btype = typeb.Text;
            string bdate = dateTimePicker1.Text;
            float bcost = float.Parse(costb.Text);
            try
            {
                if (sql.cn == null)
                {
                    sql.cn = new SqlConnection(sql.str);
                }
                if (sql.cn.State == ConnectionState.Closed)
                {

                    string name = nameb.Text;
                    int count = int.Parse(countb.Text);
                    string tgia = writerb.Text;
                    string tl = typeb.Text;
                    string date = dateTimePicker1.Text;
                    string gia = costb.Text;
                    sql.cn.Open();
                    sql.insert(name, count, tgia, tl, date, gia);
                    sql.cn.Close();
                }


                MessageBox.Show("dữ liệu đã được nhập", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
