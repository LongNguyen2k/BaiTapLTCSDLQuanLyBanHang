using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NW1
{
    
    class BUS_SanPham
    {
        Dao_SanPham Da;

        public BUS_SanPham()
        {
            Da = new Dao_SanPham();
        }
        public void LayDSSP(ComboBox cb)
        {
            cb.DataSource = Da.LayDSSP();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryID";

        }

        public void LayDSNCC(ComboBox cb)
        {
            cb.DataSource = Da.LayDSNCC();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "SupplierID";

        }

        public void LayDSSanPham(DataGridView dg)
        {
            dg.DataSource = Da.LayDSSanPham();

        }
        public void SuaSp(int maSP, string tenSP, double gia, int sl, int maLSP, int maNCC)
        {
            Da.SuaSp(maSP, tenSP, gia, sl, maLSP, maNCC);
        }

        public void ThemSp( string tenSP, double gia, int sl, int maLSP, int maNCC)
        {
            Da.ThemSP( tenSP, gia, sl, maLSP, maNCC);
        }

        public void XoaSP(int maSP)
        {
            Da.XoaSP(maSP);
        }

       
    }
}
