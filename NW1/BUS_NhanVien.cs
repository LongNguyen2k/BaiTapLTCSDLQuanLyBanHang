using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NW1
{
    class BUS_NhanVien
    {
        Dao_NhanVien daoNhanVien;
        public BUS_NhanVien()
        {
            daoNhanVien = new Dao_NhanVien();
        }
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = daoNhanVien.LayDSNhanVien();

        }
        public void SapXepDanhSachNhanVien(DataGridView dg)
        {
            dg.DataSource = daoNhanVien.SapXepTheoExtension();
        }

        public void LayDanhSachDonHangNhanVien(DataGridView dg)
        {
            dg.DataSource = daoNhanVien.DanhSachDonHangNhanVien();

        }

        public void TimKiemNhanVienTheoTen(string TenNhanVien , DataGridView dg)
        {
            if (daoNhanVien.TimKiemNhanVien(TenNhanVien))
            {
                MessageBox.Show("Tim Kiem duoc Nhan Vien ");
                if (daoNhanVien.LayDanhSachNhanVienTheoFirstName(TenNhanVien) != null )
                {
                    dg.DataSource = daoNhanVien.LayDanhSachNhanVienTheoFirstName(TenNhanVien);
                }
                else if (daoNhanVien.LayDanhSachNhanVienTheoLastName(TenNhanVien) != null)
                {
                    dg.DataSource = daoNhanVien.LayDanhSachNhanVienTheoLastName(TenNhanVien);
                }
                
            }
            else
                MessageBox.Show("Khong tim thay Nhan Vien ");

        }
    }
}
