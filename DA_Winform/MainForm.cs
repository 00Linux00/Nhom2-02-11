using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_Winform
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MDIParent2_Load(object sender, EventArgs e)
        {

        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham Fsanpham = new frmSanPham();
            Fsanpham.MdiParent = this;
            Fsanpham.Show();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang FKhachHang = new frmKhachHang();
            FKhachHang.MdiParent = this;
            FKhachHang.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien Fqlnv = new frmQLNhanVien();
            Fqlnv.MdiParent = this;
            Fqlnv.Show();
        }

        private void hoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon FHoaDon = new frmHoaDon();
            FHoaDon.MdiParent = this;
            FHoaDon.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Đảm bảo bạn đã lưu hoặc cập nhật công việc", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
