using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static NW1.Dao_SanPham;

namespace NW1
{
    public partial class FDatHang : Form
    {
        BUS_SanPham busSanPham;
        BUS_DonHang busDonHang;
        public FDatHang()
        {
            InitializeComponent();
            busSanPham = new BUS_SanPham();
            busDonHang = new BUS_DonHang();
        }
        public int maDH;
        bool co = false;
        DataTable dtSanPham;
        private void btThem_Click(object sender, EventArgs e)
        {
            bool kiemTra = true;


            foreach (DataRow item in dtSanPham.Rows)
            {
                if (item[0].ToString() == cbSP.SelectedValue.ToString()) // co ma thi tang them so luong 
                    // ko thi tao dong moi 
                {
                    kiemTra = false;
                    item[2] = int.Parse(item[2].ToString()) + int.Parse(numSoLuong.Value.ToString());
                    break;
                }

            }


            // tạo 1 dòng mới datarow dinh nghia cho 1 dong moi voi kieu du lieu tuong ung
            if (kiemTra)
            {
                DataRow r = dtSanPham.NewRow();

                r[0] = cbSP.SelectedValue.ToString();
                r[1] = txtDonGia.Text.ToString();
                r[2] = numSoLuong.Value.ToString();
                if (txtDiscount.Text == null || txtDiscount.Text == "")
                {
                    r[3] = "";

                }
                else
                {
                    r[3] = txtDiscount.Text.ToString();
                }


                // add vao datatable
                dtSanPham.Rows.Add(r); 
            }



        }

        private void FDatHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            busDonHang.LayDSSPChiTiet(cbSP);
            co = true;

            // dinh nghia 4 cot cho DG // 
            dtSanPham = new DataTable();

            dtSanPham.Columns.Add("ProductID");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dtSanPham.Columns.Add("Discount");

            // add datatable vao datagriview

            dGSP.DataSource = dtSanPham;

            // can chinh Khung hinh 

            dGSP.Columns[0].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[1].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[2].Width = (int)(0.25 * dGSP.Width);
            dGSP.Columns[3].Width = (int)(0.25 * dGSP.Width);


        }
        void HienThiThongTinSanPham(string maSP)
        {
            int m = int.Parse(maSP);
            //Product s = busDonHang.LayThongTinSanPham(m);

            ProductModel s = busDonHang.LayThongTinSanPham2(m);


            txtDonGia.Text = s.UnitPrice.ToString();
            txtLoaiSP.Text = s.CategoryName.ToString();
            txtNhaCC.Text = s.CompanyName.ToString();

        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (co)
            {
                HienThiThongTinSanPham(cbSP.SelectedValue.ToString()); 
            }

        }
    }
}
