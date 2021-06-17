using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NW1
{
    public partial class FormTesting : Form
    {
        BUS_NhanVien busNhanVien;
        SqlConnection conn;
        string connectionString;
        public FormTesting()
        {
            InitializeComponent();

            // goi doi tuong bus
            busNhanVien = new BUS_NhanVien();
        }
        void ketNoi()
        {
            /// *** Quan trong 
            connectionString = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void CapNhatDG()
        {
            busNhanVien.LayDSNhanVien(gVNhanVIen);
            gVNhanVIen.Columns[0].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[1].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[2].Width = (int)(0.25 * gVNhanVIen.Width);
            gVNhanVIen.Columns[3].Width = (int)(0.25 * gVNhanVIen.Width);
        }

        DataTable LayDSNhanVien(int maNhanVien)
        {


    // Store procedure không có tham số 

            SqlCommand cmd = cmd = new SqlCommand();
            //string strSP = "usp_LayDSNhanVien";

            //    cmd = new SqlCommand(strSP, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataAdapter daNhanVien = new SqlDataAdapter(cmd);

            //    DataSet dtNhanVien = new DataSet();

            //    daNhanVien.Fill(dtNhanVien);

            // Store procedure có tham số input 

            // phần đầu giống như trên 

            // phần tiếp theo 

            // thêm tham số vào 

            string strSP2 = "DSDonHangTungNhanVien";

            cmd = new SqlCommand(strSP2, conn);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@MaNhanVienBanHang", SqlDbType.Int);
            cmd.Parameters["@MaNhanVienBanHang"].Value = maNhanVien;

            SqlDataAdapter daOrderNhanVien = new SqlDataAdapter(cmd);

            DataSet dtOrder = new DataSet();

            daOrderNhanVien.Fill(dtOrder);



            return dtOrder.Tables[0];
            
        }


        string LayTenNhanVien(int MaNhanVien)
        {
            SqlCommand cmd = cmd = new SqlCommand();

            // Store Procedure có tham số đầu ra 

            // SqlParameter Direction
            // Sử dụng đối tượng Direction để chỉ rõ tham số out put đầu ra 

            string strSP3 = "usp_TimTenNhanVienTheoMa";

            cmd = new SqlCommand(strSP3, conn);
            cmd.CommandType = CommandType.StoredProcedure;


            // chỉ định đối tượng đầu ra 
            SqlParameter paraTen = new SqlParameter();

            paraTen.Direction = ParameterDirection.Output;

            paraTen.ParameterName = "@tenNhanVien";

            paraTen.SqlDbType = SqlDbType.NVarChar;

            paraTen.Size = 50;


            // add đối tượng output vào câu truy vấn có chứa tham số đầu vào 
            cmd.Parameters.Add(paraTen);

            cmd.Parameters.Add("@maNhanVien", SqlDbType.Int);
            cmd.Parameters["@maNhanVien"].Value = MaNhanVien;


            // xuat đối tượng ra tên 

            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            string ten = cmd.Parameters["@tenNhanVien"].Value.ToString();

            return ten;

        }

        private void btExecuteSP_Click(object sender, EventArgs e)
        {
            int maNhanVienTam;
            maNhanVienTam = int.Parse(txtMaNhanVien.Text);
            txtHoten.Text = LayTenNhanVien(maNhanVienTam);

        }

        private void FormTesting_Load(object sender, EventArgs e)
        {
            ketNoi();
            busNhanVien.LayDSNhanVien(gVNhanVIen);
            gVNhanVIen.Columns[0].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[1].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[2].Width = (int)(0.25 * gVNhanVIen.Width);
            gVNhanVIen.Columns[3].Width = (int)(0.25 * gVNhanVIen.Width);


        }

        private void btSapXep_Click(object sender, EventArgs e)
        {
            busNhanVien.SapXepDanhSachNhanVien(gVNhanVIen);
            gVNhanVIen.Columns[0].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[1].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[2].Width = (int)(0.25 * gVNhanVIen.Width);
            gVNhanVIen.Columns[3].Width = (int)(0.25 * gVNhanVIen.Width);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            CapNhatDG();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            busNhanVien.LayDanhSachDonHangNhanVien(gVNhanVIen);
            gVNhanVIen.Columns[0].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[1].Width = (int)(0.2 * gVNhanVIen.Width);
            gVNhanVIen.Columns[2].Width = (int)(0.25 * gVNhanVIen.Width);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text != null || txtHoten.Text != "")
            {
                busNhanVien.TimKiemNhanVienTheoTen(txtHoten.Text.ToString() ,gVNhanVIen);
                gVNhanVIen.Columns[0].Width = (int)(0.2 * gVNhanVIen.Width);
                gVNhanVIen.Columns[1].Width = (int)(0.2 * gVNhanVIen.Width);
                gVNhanVIen.Columns[2].Width = (int)(0.25 * gVNhanVIen.Width);

            }
        }

        private void btLoc_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
