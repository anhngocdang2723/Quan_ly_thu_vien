using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Main : Form
    {
        private QuanLyMuon qlm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //comboBox1.Text = "Tên Sách";
            if(Save.Share_DbServices.type == "Admin")
            {
                btn_MuonSach.Visible = true;
                btn_QuanLyMuon.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                MN_QLSach.Visible = true;
                MN_QLNguoiDoc.Visible = true;
                MN_QLTK.Visible = true;
                MN_QLTK_DoiMK.Visible = true;
                MN_QLTK_DSTK.Visible = true;
                MN_QLTK_ThayDoiTT.Visible = true;
                MN_QLMuon.Visible=true;
            }
            else if (Save.Share_DbServices.type == "User")
            {
                btn_MuonSach.Visible = true;
                btn_QuanLyMuon.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                MN_QLSach.Visible = false;
                MN_QLNguoiDoc.Visible = false;
                MN_QLTK.Visible = true;
                MN_QLTK_DoiMK.Visible = true;
                MN_QLTK_ThayDoiTT.Visible = true;
                MN_QLTK_DSTK.Visible = false;
                MN_QLMuon.Visible=false;
                MN_QLMuon.Visible=false;
            }    
            
        }        
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MN_QLTK_DoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.DoiMatKhau dmk = new MainForm.DoiMatKhau();
            dmk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {

        }

        private void MN_QLTK_DSTK_Click(object sender, EventArgs e)
        {
            MainForm.DanhSachTK dstk = new DanhSachTK();
            dstk.ShowDialog();            
        }

        private void MN_QLMuon_Click(object sender, EventArgs e)
        {
            qlm = new QuanLyMuon();
            qlm.TopLevel = false;
            qlm.Parent = this;

            qlm.Location = new Point(200,100);
            qlm.Size = new Size(1000,520);
            
            qlm.Show();
        }

        private void MN_QLSach_Click(object sender, EventArgs e)
        {

        }

        private void thêmSácnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDBOOK aDDBOOK=new ADDBOOK();
            aDDBOOK.Show();
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XEMSACH xEMSACH=new XEMSACH();
            xEMSACH.Show();
        }
    }
}
