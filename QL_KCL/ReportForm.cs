using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private string query = "SELECT ID AS 'Mã bệnh nhân', Ho_lot AS 'Họ và tên lót', " +
            "Ten AS 'Tên', FORMAT(Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Gioi_tinh AS 'Giới tính', " +
            "CMND, SDT, Dia_chi_cu_tru AS 'Địa chỉ cư trú', Giuong 'Giường', " +
            "Khu_cach_ly AS 'Khu cách ly', FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào',  " +
            "FORMAT(Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến' " +
            "FROM BENH_NHAN WHERE Ngay_vao = CAST(GETDATE() AS Date);";

        private void ReportForm_Load(object sender, EventArgs e)
        {     
            gridMain.DataSource = ConnectionDB.LoadData(query);
        }

        private void BtnVictimByDay_Click(object sender, EventArgs e)
        {
            query = "SELECT ID AS 'Mã bệnh nhân', Ho_lot AS 'Họ và tên lót', " +
            "Ten AS 'Tên', FORMAT(Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Gioi_tinh AS 'Giới tính', " +
            "CMND, SDT, Dia_chi_cu_tru AS 'Địa chỉ cư trú', Giuong 'Giường', " +
            "Khu_cach_ly AS 'Khu cách ly', FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào',  " +
            "FORMAT(Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến' " +
            "FROM BENH_NHAN WHERE Ngay_vao = CAST(GETDATE() AS Date);";
            ReportForm_Load(sender, e);
        }

        private void BtnVictimByMonth_Click(object sender, EventArgs e)
        {
            string currentMonth = DateTime.Now.ToString("yyyy-MM");
            query = "SELECT ID AS 'Mã bệnh nhân', Ho_lot AS 'Họ và tên lót', Ten AS 'Tên', " +
            "FORMAT(Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Gioi_tinh AS 'Giới tính', CMND, SDT, " +
            "Dia_chi_cu_tru AS 'Địa chỉ cư trú', Giuong 'Giường', Khu_cach_ly AS 'Khu cách ly', " +
            "FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', FORMAT(Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến' " +
            "FROM BENH_NHAN WHERE Ngay_vao  LIKE '" + currentMonth + "%';";
            ReportForm_Load(sender, e);
        }

        private void BtnListF0_Click(object sender, EventArgs e)
        {
            query = "SELECT B.ID AS 'Mã bệnh nhân', B.Ho_lot AS 'Họ và tên lót', " +
                "B.Ten AS 'Tên', FORMAT(B.Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', B.Gioi_tinh AS 'Giới tính', " +
                "B.CMND, B.SDT, B.Dia_chi_cu_tru AS 'Địa chỉ cư trú', B.Giuong 'Giường', " +
                "B.Khu_cach_ly AS 'Khu cách ly', FORMAT(B.Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', " +
                "FORMAT(B.Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến', T.Phan_loai_cach_ly AS 'Phân loại cách ly' " +
                "FROM BENH_NHAN AS B " +
                "INNER JOIN TT_SUC_KHOE AS T " +
                "ON B.ID = T.ID " +
                "WHERE T.Phan_loai_cach_ly = 'F0'; ";
            ReportForm_Load(sender, e);
        }

        private void BtnListF1_Click(object sender, EventArgs e)
        {
            query = "SELECT B.ID AS 'Mã bệnh nhân', B.Ho_lot AS 'Họ và tên lót', " +
               "B.Ten AS 'Tên', FORMAT(B.Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', B.Gioi_tinh AS 'Giới tính', " +
               "B.CMND, B.SDT, B.Dia_chi_cu_tru AS 'Địa chỉ cư trú', B.Giuong 'Giường', " +
               "B.Khu_cach_ly AS 'Khu cách ly', FORMAT(B.Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', " +
               "FORMAT(B.Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến', T.Phan_loai_cach_ly AS 'Phân loại cách ly' " +
               "FROM BENH_NHAN AS B " +
               "INNER JOIN TT_SUC_KHOE AS T " +
               "ON B.ID = T.ID " +
               "WHERE T.Phan_loai_cach_ly = 'F1'; ";
            ReportForm_Load(sender, e);
        }

        private void BtnListVictimCheckOut_Click(object sender, EventArgs e)
        {
            query = "SELECT B.ID AS 'Mã bệnh nhân', B.Ho_lot AS 'Họ và tên lót', " +
                "B.Ten AS 'Tên', FORMAT(B.Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', B.Gioi_tinh AS 'Giới tính', " +
                "B.CMND, B.SDT, B.Dia_chi_cu_tru AS 'Địa chỉ cư trú', B.Giuong 'Giường', " +
                "B.Khu_cach_ly AS 'Khu cách ly', FORMAT(B.Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', " +
                "FORMAT(B.Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến', " +
                "COUNT(K.Ket_qua_XN) AS 'Số lần XN âm tính' " +
                "FROM BENH_NHAN AS B " +
                "INNER JOIN KQ_XET_NGHIEM AS K " +
                "ON B.ID = K.Benh_nhan " +
                "WHERE Ket_qua_XN = 'Âm tính' " +
                "GROUP BY B.ID , B.Ho_lot, " +
                "B.Ten, B.Ngay_sinh, B.Gioi_tinh, " +
                "B.CMND, B.SDT, B.Dia_chi_cu_tru , B.Giuong, " +
                "B.Khu_cach_ly, B.Ngay_vao, B.Ngay_ra_du_kien " +
                "HAVING COUNT(K.Ket_qua_XN) >= 3; ";
            ReportForm_Load(sender, e);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in gridMain.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in gridMain.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            FileDialog fileSaveAsDialog = new SaveFileDialog();
            fileSaveAsDialog.AddExtension = true;
            fileSaveAsDialog.DefaultExt = "xlsx";
            fileSaveAsDialog.Filter = "Excel Workbooks (*.xls, *.xlsx)|*.xls;*.xlsx|Excel Macro-Enabled Workbooks | *.xlsm |All files *.*| *.*";
            try
            {
                fileSaveAsDialog.ShowDialog();
                string folderPath = fileSaveAsDialog.FileName;
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "QL KCL");
                    wb.SaveAs(folderPath);
                }
            } catch (Exception ex)
            {
                
            }     
        }
    }
}
