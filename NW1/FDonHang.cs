using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NW1
{
    public partial class FDonHang : Form
    {
        BUS_DonHang bus_DonHang; 
        public FDonHang()
        {
            InitializeComponent();
            // goi doi tuong BUS
            bus_DonHang = new BUS_DonHang();

        }

        private void CapNhatDG()
        {
            bus_DonHang.LayDSDH(gVDH);
            gVDH.Columns[0].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.25 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.25 * gVDH.Width);
        }


        private void FDonHang_Load(object sender, EventArgs e)
        {
            bus_DonHang.LayDSDH(gVDH);
            bus_DonHang.LayDSKH(comboBoxKH);
            bus_DonHang.LayDSNV(comboBoxNV);
            gVDH.Columns[0].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.25 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.25 * gVDH.Width);


        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gVDH.Rows.Count - 1)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxNV.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxKH.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString();

              
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // 1 don hang moi 
            Order oD = new Order();
            // 2 . Cap nhat gia tri cho don hang moi 
            oD.OrderDate = dtpNgayDH.Value;
            oD.CustomerID = comboBoxKH.SelectedValue.ToString();
            oD.EmployeeID = int.Parse(comboBoxNV.SelectedValue.ToString());

            // goi phuong thuc them o Bus
            bus_DonHang.ThemDonHang(oD);

            // Cap Nhat DG
            gVDH.Columns.Clear();
            CapNhatDG();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // 1 don hang can sua 
            Order oD = new Order();
            // 2 . Cap nhat gia tri cho don hang moi 
            oD.OrderID = int.Parse(txtMaDH.Text.ToString());
            oD.OrderDate = dtpNgayDH.Value;
            oD.CustomerID = comboBoxKH.SelectedValue.ToString();
            oD.EmployeeID = int.Parse(comboBoxNV.SelectedValue.ToString());

            // goi phuong thuc them o Bus
            bus_DonHang.SuaDonHang(oD);

            // Cap Nhat DG
            gVDH.Columns.Clear();
            CapNhatDG();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maDonHang;

            // lay ra ma Don Hang
            maDonHang = int.Parse(txtMaDH.Text.ToString());

            // goi pthuc o Bus

            bus_DonHang.XoaDonHang(maDonHang);

            // cap nhat DG
            gVDH.Columns.Clear();
            CapNhatDG();

        }

        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
          //  MessageBox.Show(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            FormChiTietDonHang f = new FormChiTietDonHang();
            f.maDH = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            f.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSanPham f = new FSanPham();
            f.ShowDialog();
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            f.ShowDialog();
        }

        private void btnThemCTDH_Click(object sender, EventArgs e)
        {
            // Goi form Dat Hang 
            FDatHang f = new FDatHang();
            f.maDH = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            // gọi neu mà chọn cancel thì ko cho tắt form
            if(MessageBox.Show("Are you sure you want to exit the program ? " , "Warning " , MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
