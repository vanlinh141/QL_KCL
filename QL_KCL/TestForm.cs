using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class TestForm : Form
    {
        public TestForm(string userID)
        {
            InitializeComponent();
            boxStaffID.Text = userID;
            cbBoxTypeTest.SelectedIndex = 0;
            dateTestPicker.CustomFormat = "dd/MM/yyyy";
            dateResultPicker.CustomFormat = "dd/MM/yyyy";
            dateNextTestPicker.CustomFormat = "dd/MM/yyyy";
        }

        private string queryLoadData = "SELECT ID AS 'Mã xét nghiệm', Can_bo AS 'Mã nhân viên', " +
            "Benh_nhan AS 'Mã bệnh nhân', Loai_XN AS 'Loại xét nghiệm', FORMAT (Ngay_XN, 'dd/MM/yyyy ') AS 'Ngày xét nghiệm', " +
            "FORMAT (Ngay_tra_KQ, 'dd/MM/yyyy ') AS 'Ngày trả kết quả', Chi_so_CT AS 'Chỉ số CT', FORMAT (Ngay_lay_mau_tiep, 'dd/MM/yyyy ') AS 'Ngày lấy mẫu tiếp theo', " +
            "Ket_qua_XN AS 'Kết quả xét nghiệm', Ghi_chu AS 'Ghi chú' FROM KQ_XET_NGHIEM;";

        private void TestForm_Load(object sender, EventArgs e)
        {
            gridTest.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void ClearField()
        {
            boxID.Clear();
            boxVictimID.Clear();
            boxResult.Clear();
            boxNote.Clear();
            boxCT.Clear();
            cbBoxTypeTest.SelectedIndex = 0;
            dateTestPicker.ResetText();
            dateNextTestPicker.ResetText();
            dateResultPicker.ResetText();
        }

        private Test GetTestInfor()
        {
            Test test;
            string testID = boxID.Text;
            string victimID = boxVictimID.Text;
            string indexCT = boxCT.Text;
            string result = boxResult.Text;
            if (string.IsNullOrEmpty(testID) && string.IsNullOrEmpty(victimID)
                && string.IsNullOrEmpty(indexCT) && string.IsNullOrEmpty(result))
            {
                return null;
            }
            string staffID = boxStaffID.Text;
            string typeTest = cbBoxTypeTest.Text;
            string dateTest = dateTestPicker.Value.ToShortDateString();
            string dateResult = dateResultPicker.Value.ToShortDateString();
            string dateNextTest = dateNextTestPicker.Value.ToShortDateString();
            test = new Test(testID, victimID, staffID, typeTest, dateTest,
                dateResult, indexCT, dateNextTest, result);

            return test;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Test test = GetTestInfor();
            if (test != null)
            {
                if (!ConnectionDB.CheckExistField("KQ_XET_NGHIEM", "ID", test.ID))
                {
                    if (ConnectionDB.CheckExistField("BENH_NHAN", "ID", test.VictimID))
                    {
                        string queryInsert = "INSERT KQ_XET_NGHIEM VALUES(@testID, @victimID, @staffID, " +
                            "@typeTest, @dateTest, @dateResult, @indexCT, @dateNextTest, @note, @result);";
                        Thread thread = new Thread(ClearField);
                        thread.Start();
                        InsertOrUpdate(test, queryInsert, boxNote.Text);
                        TestForm_Load(sender, e);
                    }
                    else { MessageBox.Show("Mã bệnh nhân không tồn tại!"); }
                }
                else { MessageBox.Show("Mã xét nghiệm đã tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void InsertOrUpdate(Test test, string query, string note)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@testID", DbType.String).Value = test.ID;
                        cmd.Parameters.AddWithValue("@victimID", DbType.String).Value = test.VictimID;
                        cmd.Parameters.AddWithValue("@staffID", DbType.String).Value = test.StaffID;
                        cmd.Parameters.AddWithValue("@typeTest", DbType.String).Value = test.TypeTest;
                        cmd.Parameters.AddWithValue("@dateTest", DbType.String).Value = test.DateTest;
                        cmd.Parameters.AddWithValue("@dateResult", DbType.String).Value = test.DateResult;
                        cmd.Parameters.AddWithValue("@indexCT", DbType.String).Value = test.IndexCT;
                        cmd.Parameters.AddWithValue("@dateNextTest", DbType.String).Value = test.DateNextTest;
                        cmd.Parameters.AddWithValue("@note", DbType.String).Value = note;
                        cmd.Parameters.AddWithValue("@result", DbType.String).Value = test.Result;
                        cmd.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ConnectionDB.DeleteField("KQ_XET_NGHIEM", "ID", boxID.Text))
            {
                ClearField();
                TestForm_Load(sender, e);
            }
            else { MessageBox.Show("Mã xét nghiệm không tồn tại!"); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Test test = GetTestInfor();
            if (test != null)
            {
                if (ConnectionDB.CheckExistField("KQ_XET_NGHIEM", "ID", test.ID))
                {
                    if (ConnectionDB.CheckExistField("BENH_NHAN", "ID", test.VictimID))
                    {
                        string queryInsert = "UPDATE KQ_XET_NGHIEM SET Benh_nhan = @victimID, Can_bo = @staffID, " +
                            "Loai_XN = @typeTest, Ngay_XN = @dateTest, Ngay_tra_KQ = @dateResult, " +
                            "Chi_so_CT = @indexCT, Ngay_lay_mau_tiep = @dateNextTest, Ghi_chu = @note, " +
                            "Ket_qua_XN = @result WHERE ID = @testID;";
                        Thread thread = new Thread(ClearField);
                        thread.Start();
                        InsertOrUpdate(test, queryInsert, boxNote.Text);
                        TestForm_Load(sender, e);
                    }
                    else { MessageBox.Show("Mã bệnh nhân không tồn tại!"); }
                }
                else { MessageBox.Show("Mã xét nghiệm không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ClearField);
            thread.Start();
            TestForm_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string victimID = boxVictimID.Text;
            if (!string.IsNullOrEmpty(victimID))
            {
                string querySearch = "SELECT ID AS 'Mã xét nghiệm', Can_bo AS 'Mã nhân viên', " +
                    "Benh_nhan AS 'Mã bệnh nhân', Loai_XN AS 'Loại xét nghiệm', FORMAT (Ngay_XN, 'dd/MM/yyyy ') AS 'Ngày xét nghiệm', " +
                    "FORMAT (Ngay_tra_KQ, 'dd/MM/yyyy ') AS 'Ngày trả kết quả', Chi_so_CT AS 'Chỉ số CT', FORMAT (Ngay_lay_mau_tiep, 'dd/MM/yyyy ') AS 'Ngày lấy mẫu tiếp theo', " +
                    "Ket_qua_XN AS 'Kết quả xét nghiệm', Ghi_chu AS 'Ghi chú' FROM KQ_XET_NGHIEM " +
                    "WHERE Benh_nhan = '" + victimID + "';";
                gridTest.DataSource = ConnectionDB.LoadData(querySearch);
            }
            else { MessageBox.Show("Vui lòng nhập mã bệnh nhân!"); }
        }
    }
}
