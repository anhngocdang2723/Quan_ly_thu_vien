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
                //btn_MuonSach.Visible = true;
                //btn_QuanLyMuon.Visible = true;
                btnChangePass.Visible = true;
                button4.Visible = true;
                MN_QLSach.Visible = true;
                MN_QLNguoiDoc.Visible = true;
                MN_QLTK.Visible = true;
                MN_QLTK_DoiMK.Visible = true;
                MN_QLTK_DSTK.Visible = true;
                MN_QLTK_ThayDoiTT.Visible = true;
                MN_QLMuon.Visible=true;
                groupQuanly.Visible = true;

            }
            else if (Save.Share_DbServices.type == "User")
            {
                //btn_MuonSach.Visible = true;
               // btn_QuanLyMuon.Visible = false;
                btnChangePass.Visible = true;
                button4.Visible = true;
                MN_QLSach.Visible = false;
                MN_QLNguoiDoc.Visible = false;
                MN_QLTK.Visible = true;
                MN_QLTK_DoiMK.Visible = true;
                MN_QLTK_ThayDoiTT.Visible = true;
                MN_QLTK_DSTK.Visible = false;
                MN_QLMuon.Visible=false;
                MN_QLMuon.Visible=false;
                groupQuanly.Visible = false;
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

            qlm.Location = new Point(125, 100);
            qlm.Size = new Size(1000,520);
            
            qlm.Show();

            groupBox4.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.UserBorrowBook ubrb = new MainForm.UserBorrowBook();
            ubrb.ShowDialog();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.UserReturnBook userReturnBook = new MainForm.UserReturnBook();
            userReturnBook.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            MainForm.DoiMatKhau dmk = new MainForm.DoiMatKhau();
            dmk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm.Personal_Information personal_Information = new MainForm.Personal_Information();
            personal_Information.ShowDialog();
        }

        private void MN_QLTK_ThayDoiTT_Click(object sender, EventArgs e)
        {
            MainForm.Personal_Information personal_Information = new MainForm.Personal_Information();
            personal_Information.ShowDialog();
        }
    }
}
