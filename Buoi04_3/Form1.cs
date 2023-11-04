using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_3
{
    public partial class Form1 : Form
    {
        String[] listSP = { "CNTT", "Kế toán" };
        private object listLoai;
        private int rowindex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoai.DataSource = listSP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double dongia;
            try
            {
                if (!mtxtMaSP.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên 10 ký tự");
                }
                if (this.checkMaSP(mtxtMaSP.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã ton tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Ho ten khong được đe trong");
                }
                if (!double.TryParse(txtGia.Text, out dongia))
                {
                    throw new Exception("Điểm TB khong phải số");
                }
                string masp = mtxtMaSP.Text;
                string sanpham = txtTenSP.Text;
                string loai = cbLoai.Text;
                string donvi = cbLoai.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["SanPham"].Value = sanpham;
                dgvDanhSach.Rows[row].Cells["Dongia"].Value = dongia;
                dgvDanhSach.Rows[row].Cells["Loai"].Value = loai;
                dgvDanhSach.Rows[row].Cells["Donvi"].Value = donvi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }
        }
        public bool checkMaSP(string masp)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masp)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                mtxtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["SanPham"].Value.ToString();
                txtSoluong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                string dongia = dgvDanhSach.Rows[rowindex].Cells["DonGia"].Value.ToString();
                int i = 0;
                while (i < listSP.Length && listSP[i] != dongia)
                {
                    i++;
                }
                {
                    cbLoai.SelectedIndex = i;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double dongia;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can xoa!");
                }
                if (!mtxtMaSP.Text.Length.Equals(10))
                {
                    throw new Exception("Ma sinh vien 10 ký tự");
                }
                if (this.checkMaSP(mtxtMaSP.Text) == false && mtxtMaSP.Text != dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                    throw new Exception("Ma sinh vien da ton tại");
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Ho ten khong dược đe trong");
                }
                if (!double.TryParse(txtGia.Text, out dongia))
                {
                    throw new Exception("Điem TB khong phải so");
                }
                string masp = mtxtMaSP.Text;
                string tensp = txtTenSP.Text;
                string khoa = cbLoai.Text;
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = dongia;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm cần xóa!");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Bạn có muốn thoát không",
           "Thông báo",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
    
    

