using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class HealthForm : Form
    {
        public HealthForm(string userRole)
        {
            InitializeComponent();
            cbBoxType.SelectedIndex = 0;
        }

        public string UserRole { get; set; }

        private readonly string queryLoadData = "SELECT B.Ho_lot, B.Ten, T.* " +
                                                "FROM BENH_NHAN AS B " +
                                                "INNER JOIN TT_SUC_KHOE AS T " +
                                                "ON B.ID = T.ID;";
        private readonly string queryLoadID = "SELECT B.ID, B.Ho_lot, B.Ten " +
                                            "FROM BENH_NHAN AS B " +
                                            "LEFT JOIN  TT_SUC_KHOE AS T " +
                                            "ON B.ID = T.ID " +
                                            "WHERE T.ID IS NULL; ";

        private void HealthForm_Load(object sender, EventArgs e)
        {
            gridHealth.DataSource = ConnectionDB.LoadData(queryLoadData);
            gridID.DataSource = ConnectionDB.LoadData(queryLoadID);
        }

        private void ClearField()
        {
            cbBoxType.SelectedIndex = 0;
            boxID.Clear();
            boxHealth.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ClearField();
            gridHealth.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string victimID = boxID.Text;
            if (Controller.IsEmptyField(victimID))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
            } else
            {
                string querySearch = "SELECT B.Ho_lot, B.Ten, T.*  " +
                    "FROM BENH_NHAN AS B " +
                    "INNER JOIN TT_SUC_KHOE AS T " +
                    "ON B.ID = T.ID " +
                    "WHERE B.ID = '"+ victimID +"';";
                gridHealth.DataSource = ConnectionDB.LoadData(querySearch);
            } 
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ID = boxID.Text.Trim();
            string status = boxHealth.Text.Trim();
            if (!Controller.IsEmptyField(ID) && !Controller.IsEmptyField(status))
            {
                string type = cbBoxType.Text;
                if (Controller.CheckExistID("BENH_NHAN", ID))
                {
                   if (!Controller.CheckExistID("TT_SUC_KHOE", ID))
                    {
                        string query = "INSERT TT_SUC_KHOE VALUES(@ID, @status, @type);";
                        InsertOrUpdateHealth(ID, status, type, query);
                        Thread thread = new Thread(ClearField);
                        thread.Start();
                        HealthForm_Load(sender, e);
                    }
                    else { MessageBox.Show("Thông tin bệnh nhân đã tồn tại!"); }
                }
                else { MessageBox.Show("Mã bệnh nhân không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string ID = boxID.Text.Trim();
            string status = boxHealth.Text.Trim();
            if (!Controller.IsEmptyField(ID) && !Controller.IsEmptyField(status))
            {
                string type = cbBoxType.Text;
                if (Controller.CheckExistID("BENH_NHAN", ID))
                {
                    if (Controller.CheckExistID("TT_SUC_KHOE", ID))
                    {
                        string query = "UPDATE TT_SUC_KHOE SET Tinh_trang_SK = @status, " +
                            "Phan_loai_cach_ly = @type " +
                            "WHERE ID = @ID;";
                        InsertOrUpdateHealth(ID, status, type, query);
                        Thread thread = new Thread(ClearField);
                        thread.Start();
                        HealthForm_Load(sender, e);
                    }
                    else { MessageBox.Show("Thông tin bệnh nhân không tồn tại!"); }
                }
                else { MessageBox.Show("Mã bệnh nhân không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void InsertOrUpdateHealth(string ID, string status, string type, string query)
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
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = ID;
                        cmd.Parameters.AddWithValue("@status", DbType.String).Value = status;
                        cmd.Parameters.AddWithValue("@type", DbType.String).Value = type;
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
            string victimID = boxID.Text;
            if (!Controller.IsEmptyField(victimID))
            {
                if (Controller.CheckExistID("BENH_NHAN", victimID))
                {
                    Thread threadClearField = new Thread(ClearField);
                    ConnectionDB.DeleteByID("TT_SUC_KHOE", victimID);
                    threadClearField.Start();
                    HealthForm_Load(sender, e);

                }
                else MessageBox.Show("Mã bệnh nhân không tồn tại!");
            }
            else MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
        }
    }
}
