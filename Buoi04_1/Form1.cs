﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        string[] danhsachkhoa = { "CNTT", "QTKD", "Kế toán", "Ngoại ngữ" };
        private int rowchoose;

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadKhoa();
        }

        private void loadKhoa()
        {
            cbKhoa.DataSource = danhsachkhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã SV phải đúng 10 kí tự");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Họ tên sinh viên ít nhất 2 kí tự");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                rowchoose = e.RowIndex;
                txtMaSV.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchoose].Cells["Ngaysinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien phải đung 10 ký tự");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Ho ten sinh vien ít nhất 2 ký tự");
                }

                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value = khoa;
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can cap nhật");
                }
                dgvDanhSach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
