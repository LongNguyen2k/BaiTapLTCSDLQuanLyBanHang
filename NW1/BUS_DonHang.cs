using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static NW1.Dao_SanPham;

namespace NW1
{
    class BUS_DonHang
    {
        Dao_DonHang da;
        Dao_SanPham dSP;
        public BUS_DonHang()
        { 
            // goi doi tuong dao 
            da = new Dao_DonHang();
            dSP = new Dao_SanPham();
        }

        public void LayDSDH(DataGridView dg)
        {
            dg.DataSource = da.LayDSDH3();
        }
        public void LayDSKH(ComboBox cb)
        {
            cb.DataSource = da.LayDSKH();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "CustomerID";
        }
        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = da.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }

       

        public void ThemDonHang(Order d)
        {
            try
            {

                da.ThemDH(d);

            }
            catch (Exception ex)
            { 
                
            }
        
        }

        public void ThemChiTietDonHang(OrderDetail oD)
        {
            try
            {
                da.ThemChiTietDonhang(oD);
                MessageBox.Show("Them thanh Cong Chi Tiet Don Hang Moi !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them THAT BAI  Chi Tiet Don Hang !");
            }


        }

        public void SuaDonHang(Order d)
        {
            if (da.SuaDH(d))
            {
                MessageBox.Show("Sua thanh Cong !");

            }
            else
            {
                MessageBox.Show("Khong thay Don hang !");
            }
        }

        public void XoaDonHang(int maDonhang)
        {
            if (da.XoaDonHang(maDonhang))
            {
                MessageBox.Show("Xoa thanh Cong !");

            }
            else
            {
                MessageBox.Show("Khong thay Don hang !");
            }
        }

        public void DSChiTietDonHang(DataGridView dg,int maDH)
        {
            dg.DataSource = da.LayDanhSachChiTietDonHang(maDH);

        }

        public void LayDSSPChiTiet(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSSanPhamChiTiet();
            cb.DisplayMember = "ProductName";
            cb.ValueMember = "ProductID";
        }

        // Lay thong tin chi tiet san pham 
        public Product LayThongTinSanPham(int maSP)
        {
            Product s = dSP.LayThongTinSanPham(maSP);

            return s;

        }

        // Lay Thong Tin San Pham Theo Product model 

        public ProductModel LayThongTinSanPham2(int maSP)
        {
            ProductModel s = dSP.LayThongTinSanPham2(maSP);

            return s;


        }



    }
}
