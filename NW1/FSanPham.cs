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
    public partial class FSanPham : Form
    {
        BUS_SanPham busSP;
        public FSanPham()
        {
            InitializeComponent();
            busSP = new BUS_SanPham();
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            busSP.LayDSSP(cbLoaiSP);
            busSP.LayDSNCC(cbNCC);
            busSP.LayDSSanPham(dGSP);
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count-1)
            {
                txtTenSP.Text = dGSP.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtSoLuong.Text = dGSP.Rows[e.RowIndex].Cells["UnitsInStock"].Value.ToString();
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                cbLoaiSP.Text = dGSP.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                cbNCC.Text = dGSP.Rows[e.RowIndex].Cells["ComPanyName"].Value.ToString();
            }
        }

       

        private void btSua_Click_1(object sender, EventArgs e)
        {
            int maSP, maLSP, maNCC;
            //cell 0 la2 cot product
            maSP = int.Parse(dGSP.CurrentRow.Cells[0].Value.ToString());
            maLSP = int.Parse(cbLoaiSP.SelectedValue.ToString());
            maNCC = int.Parse(cbNCC.SelectedValue.ToString());

            busSP.SuaSp(maSP, txtTenSP.Text, double.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text)
                , maLSP, maNCC);

            // cap nhat lai DGSP
            dGSP.Columns.Clear();
            busSP.LayDSSanPham(dGSP);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int  maLSP, maNCC;
            //cell 0 la2 cot product
           
            maLSP = int.Parse(cbLoaiSP.SelectedValue.ToString());
            maNCC = int.Parse(cbNCC.SelectedValue.ToString());

            busSP.ThemSp( txtTenSP.Text, double.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text)
                , maLSP, maNCC);

            // cap nhat lai DGSP
            dGSP.Columns.Clear();
            busSP.LayDSSanPham(dGSP);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maSP;
            //cell 0 la2 cot product
            maSP = int.Parse(dGSP.CurrentRow.Cells[0].Value.ToString());
            busSP.XoaSP(maSP);

            // cap nhat lai DGSP
            dGSP.Columns.Clear();
            busSP.LayDSSanPham(dGSP);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            // gọi neu mà chọn cancel thì ko cho tắt form
            if (MessageBox.Show("Are you sure you want to exit the program ? ", "Warning ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
