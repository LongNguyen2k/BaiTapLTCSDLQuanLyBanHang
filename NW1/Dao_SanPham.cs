using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace NW1
{
    class Dao_SanPham
    {
        SqlConnection conn;
        String chuoiKetNoi;
        SqlDataAdapter da;

        public NWDataContext db;

        public Dao_SanPham()
        {
            chuoiKetNoi = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            conn = new SqlConnection(chuoiKetNoi);
            db = new NWDataContext();
        }

        public DataTable LayDSSP()
        {
            DataSet ds = new DataSet();
            string query = "select CategoryID,CategoryName from Categories";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable LayDSNCC()
        {
            DataSet ds = new DataSet();
            string query = "select SupplierID , CompanyName from Suppliers";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable LayDSSanPham()
        {
            DataSet ds = new DataSet();
            string query = "select ProductID ,ProductName, UnitPrice , UnitsInStock , CategoryName , CompanyName from Products p , Suppliers s , Categories c where p.CategoryID = c.CategoryID and s.SupplierID = p .SupplierID";
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void SuaSp(int maSP, string tenSP, double gia, int sl, int maLSP, int maNCC )
        {
            SqlCommand cmd;
            string query = string.Format("update Products set ProductName = '{0}',UnitPrice = '{1}' , UnitsInStock = '{2}' , CategoryID = '{3}' , SupplierID = '{4}' Where  ProductID = '{5}'"
                , tenSP, gia, sl, maLSP, maNCC, maSP);

            // them sua xoa 

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ThemSP( string tenSP, double gia, int sl, int maLSP, int maNCC)
        {
            SqlCommand cmd;
            string query = string.Format("insert into  Products(ProductName , UnitPrice ,UnitsInStock , CategoryID , SupplierID ) values( '{0}', '{1}' ,  '{2}' ,'{3}' ,'{4}' )"
                , tenSP, gia, sl, maLSP, maNCC);

            // them sua xoa 

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void XoaSP(int maSP)
        {
            SqlCommand cmd;
            string query = string.Format("delete from Products Where  ProductID = {0}", maSP);

            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // GUI 
        // BUS
        // DAO

        public dynamic LayDSSanPhamChiTiet()
        {
            var ds = db.Products.Select(s => new { s.ProductID, s.ProductName });
            return ds;   
        }


        // Lay Thong Tin San Pham 
        public dynamic LayThongTinSanPham(int maSP)
        {
            var ds = db.Products.FirstOrDefault(s => s.ProductID == maSP);


            return ds;

        }



        // Class Tự Định Nghĩa ProductModel 
        public class ProductModel
        {
            private int productID;
            private string productName;
            private System.Nullable<decimal> unitPrice;
            private string categoryName;
            private string companyName;
            // pt khởi tạo 
            public int ProductID
            {
                get { return productID; }
                set { productID = value; }

            }
            public string ProductName
            {
                get { return productName; }
                set { productName = value; }

            }

            public decimal? UnitPrice
            {
                get { return unitPrice; }
                set { unitPrice = value; }
            }


            public string CategoryName
            {
                get { return categoryName; }
                set { categoryName = value; }

            }

            public string CompanyName
            {
                get { return companyName; }
                set { companyName = value; }

            }



        }

        // Lay Thong Tin San Pham Theo ClassTu Dinh Nghia 

        public ProductModel LayThongTinSanPham2(int maSp)
        {


           dynamic  sp1  = db.Products
                               .Where(s => s.ProductID == maSp)
                               .Select(s => new

                               {
                                   s.ProductID,
                                   s.ProductName,
                                   s.UnitPrice,
                                   s.Category.CategoryName,
                                   s.Supplier.CompanyName
                               }).FirstOrDefault();



            ProductModel sp = db.Products
                                .Where(s => s.ProductID == maSp)
                                .Select(s => new ProductModel()

                                {
                                    ProductID = s.ProductID,
                                    ProductName = s.ProductName,
                                    UnitPrice = s.UnitPrice,
                                    CategoryName = s.Category.CategoryName,
                                    CompanyName = s.Supplier.CompanyName
                                }).FirstOrDefault();


            return sp;

        }


    }

    
}
