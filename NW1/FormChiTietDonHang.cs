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
    public partial class FormChiTietDonHang : Form
    {

        //khai bao bien Public
        public int maDH;
        private BUS_DonHang busDH;
        public FormChiTietDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }


        private void CapNhatDG()
        {
            busDH.DSChiTietDonHang(gVChiTietDonHang, maDH);
            gVChiTietDonHang.Columns[0].Width = (int)(0.2 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[1].Width = (int)(0.3 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[2].Width = (int)(0.2 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[3].Width = (int)(0.2 * gVChiTietDonHang.Width);
        }

        private void FormChiTietDonHang_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(maDH.ToString());
            // txtMaDH.Text = maDH.ToString();
            busDH.LayDSSPChiTiet(comboBoxMaSP);
            busDH.DSChiTietDonHang(gVChiTietDonHang,maDH);
            gVChiTietDonHang.Columns[0].Width = (int)(0.2 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[1].Width = (int)(0.3 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[2].Width = (int)(0.2 * gVChiTietDonHang.Width);
            gVChiTietDonHang.Columns[3].Width = (int)(0.2 * gVChiTietDonHang.Width);



        }

        private void btThem_Click(object sender, EventArgs e)
        {
            OrderDetail od = new OrderDetail();
            od.OrderID = int.Parse(txtMaDH.Text);
            od.ProductID = int.Parse(comboBoxMaSP.SelectedValue.ToString());
            od.Quantity = short.Parse(textBoxSoLuong.Text);
            od.UnitPrice = decimal.Parse(textBoxDonGia.Text);
            

            busDH.ThemChiTietDonHang(od);

            // cap nhat
            gVChiTietDonHang.Columns.Clear();
            CapNhatDG();
        }

        private void gVChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gVChiTietDonHang.Rows.Count - 1)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVChiTietDonHang.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                comboBoxMaSP.Text = gVChiTietDonHang.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                textBoxDonGia.Text = gVChiTietDonHang.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                textBoxSoLuong.Text = gVChiTietDonHang.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

            }
        }
    }
}
