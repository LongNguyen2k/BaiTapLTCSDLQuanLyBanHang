using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NW1
{
    class Dao_NhanVien
    {
        NWDataContext db;
        public Dao_NhanVien()
        {
            db = new NWDataContext();
        }

        // Lay Danh Sach Nhan Vien 

        public IEnumerable<Employee> LayDSNhanVien()
        {
            var ds = db.Employees.Select(s => s);
            return ds;
        }

        public IEnumerable<Employee> SapXepTheoExtension()
        {
            var ds = db.Employees.OrderBy(p => p.Extension).ThenByDescending(p => p.EmployeeID);
            return ds;
        }

        public dynamic DanhSachDonHangNhanVien()
        {
            
            // Join method syntax

            var query = db.Employees.Join(

                db.Orders , 
                
                employee => employee.EmployeeID ,
                    
                order => order.EmployeeID ,
                
                (e, o) => new
                {
                    o.OrderID,
                    e.EmployeeID,
                    o.OrderDate
                    

                }) ;


            return query;
                
        }

        public bool TimKiemNhanVien(String keyWord)
        {
            bool flag = false;

            try
            {
                var e1 = LayDanhSachNhanVienTheoFirstName(keyWord);
                var e2 = LayDanhSachNhanVienTheoLastName(keyWord);
                

                if (e1 != null)
                {
                    flag = true;

                    
                }
                else if (e2 != null)
                {

                    flag = true;
                   
                }


            }
            catch (Exception ex)
            {
                flag = false;
                
                throw;

            }
            return flag;
        }

        public dynamic LayDanhSachNhanVienTheoFirstName(string keyWord)
        {
            var e1 = db.Employees.Where(s => s.FirstName ==  keyWord).ToList();

            return e1;
        }

        public dynamic LayDanhSachNhanVienTheoLastName(string keyWord)
        {
            var e2 = db.Employees.Where(s => s.LastName == keyWord).ToList();
            return e2;
        }
    }
}
