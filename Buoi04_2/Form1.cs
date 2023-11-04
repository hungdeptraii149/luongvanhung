﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        String[] listKhoa = { "CNTT", "Kế toán", "Ngoại ngữ", "Điện tử" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int rowindex = -1;


        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (!mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên 10 ký tự");
                }
                if (this.checkMaSV(mtxtMaSV.Text) == false) {
                    throw new Exception("Mã sinh viên đã ton tại");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Ho ten khong được đe trong");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm TB khong phải số");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }
        }
        public bool checkMaSV(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
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
                mtxtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listKhoa.Length && listKhoa[i] != tenkhoa)
                {
                    i++;
                }
                {
                    cbKhoa.SelectedIndex = i;
                }  
                
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can xoa!");
                }
                if (!mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Ma sinh vien 10 ký tự");
                }
                if (this.checkMaSV(mtxtMaSV.Text) == false && mtxtMaSV.Text != dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                    throw new Exception("Ma sinh vien da ton tại");
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Ho ten khong dược đe trong");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điem TB khong phải so");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
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
                    throw new Exception("Chưa chọn sinh viên cần xoá!");
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
    

