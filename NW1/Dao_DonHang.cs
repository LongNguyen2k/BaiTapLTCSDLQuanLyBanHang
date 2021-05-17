using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NW1
{
    
    class Dao_DonHang
    {   
        NWDataContext db;
        public Dao_DonHang()
        {
            // tao ket noi den DB
             db = new NWDataContext();
        }

        // lay danh sach Don Hang
        public IEnumerable<Order> LayDSDH()
        {   // var ds = from i in db.Orders select i ;
            var ds = db.Orders.Select(s => s);
            return ds;
        }

        public dynamic LayDSDH3()
        {
            return db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                s.Customer.CompanyName,
                s.Employee.LastName

            }).ToList();
        }
        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(s => new { s.CustomerID, s.CompanyName });
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(s => new { s.EmployeeID, s.LastName });
            return ds;
        }

        public void ThemDH(Order oD)
        {
            db.Orders.InsertOnSubmit(oD);
            db.SubmitChanges();
        }

        public void ThemChiTietDonhang(OrderDetail oD)
        {
            //OrderDetail d = db.OrderDetails.First(s => s.OrderID == oD.OrderID);

            //d.OrderID = oD.OrderID;
            //d.ProductID = oD.ProductID;
            //d.Quantity = oD.Quantity;
            //d.UnitPrice = oD.UnitPrice;


            db.OrderDetails.InsertOnSubmit(oD);
            db.SubmitChanges();
        }


        public bool SuaDH(Order donHang)
        {
            bool tinhTrang = false;

            // Tim Kiem Don Hang 
            try
            {
                Order d = db.Orders.First(s => s.OrderID == donHang.OrderID);

                // Sua DOnhang

                d.OrderDate = donHang.OrderDate;
                d.CustomerID = donHang.CustomerID;
                d.EmployeeID = donHang.EmployeeID;

                db.SubmitChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
                throw;
            }

            return tinhTrang;

        }

        public bool SuaChiTietDonHang(OrderDetail ctDonHangCu , OrderDetail ctDonHangMoi)
        {
            bool tinhTrang = false;
            try
            {
                OrderDetail d = db.OrderDetails.First( s =>
                ( s.OrderID == ctDonHangCu.OrderID ) 
                && (s.ProductID == ctDonHangCu.ProductID)
                && (s.UnitPrice == ctDonHangCu.UnitPrice)
                && (s.Quantity == ctDonHangCu.Quantity)
                 
                
                );
                // Sua Don Hang // Xoa Don Hang Cu Tao 1 Don Hang Moi 

                db.OrderDetails.DeleteOnSubmit(d);

                db.OrderDetails.InsertOnSubmit(ctDonHangMoi);

                db.SubmitChanges();
                tinhTrang = true;

            }
            catch (Exception)
            {
                tinhTrang = false;
                throw;
            }

            return tinhTrang;

        }


        public bool XoaDonHang(int maDonHang)
        {

            bool tinhTrang = false;
            // Tim Kiem Don Hang 
            try
            {

                Order d = db.Orders.First(s => s.OrderID == maDonHang);

                // Xoa DOnhang

                db.Orders.DeleteOnSubmit(d);

                db.SubmitChanges();
                tinhTrang = true;
            }
            catch (Exception)
            {
                tinhTrang = false;
                throw;
            }

            return tinhTrang;

        }

        public dynamic LayDanhSachChiTietDonHang(int maDH)
        {
            // method syntax
            var ds = db.OrderDetails.Where(s => s.OrderID == maDH)
                .Select(s => new { s.OrderID, s.Product.ProductName, s.UnitPrice, s.Quantity });
            return ds;
        }

      


    }
   
}
