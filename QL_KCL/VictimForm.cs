using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class VictimForm : Form
    {
        public VictimForm(string userRole)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            birthdayPicker.CustomFormat = "dd-MM-yyyy";
            checkinPicker.CustomFormat = "dd-MM-yyyy";
            checkoutPicker.CustomFormat = "dd-MM-yyyy";
            if (userRole == "Điều dưỡng")
            {
                BtnDelete.Hide();
            }
        }

        private readonly string queryLoadData = "SELECT ID, Ho_lot, Ten, FORMAT (Ngay_sinh, 'dd/MM/yyyy ') AS Ngay_sinh," +
                    "Gioi_tinh, CMND, SDT, Dia_chi_cu_tru, Giuong, Khu_cach_ly, " +
                    "FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS Ngay_vao, FORMAT (Ngay_ra_du_kien, 'dd/MM/yyyy ') AS Ngay_ra_du_kien " +
                    "FROM BENH_NHAN; ";

        

        private void ClearField()
        {
            Thread thread = new Thread(
                delegate()
                { bedSelected.RefreshData(); });
            thread.Start();
            boxID.Clear();
            boxFirstName.Clear();
            boxName.Clear();
            rdbMale.Checked = true;
            boxCMND.Clear();
            boxPhone.Clear();
            boxAddress.Clear();
            cBoxBed.Checked = false;
        }

        private void VictimForm_Load(object sender, EventArgs e)
        {
            gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private Victim GetVictim()
        {
            Victim victim = null;
            string ID = boxID.Text;
            string firstName = boxFirstName.Text;
            string name = boxName.Text;
            string address = boxAddress.Text;
            if (!Controller.IsEmptyField(ID) && !Controller.IsEmptyField(firstName)
                && !Controller.IsEmptyField(name) && !Controller.IsEmptyField(address))
            {
                string cmnd = boxCMND.Text;
                string phone = boxPhone.Text;
                string gender = rdbMale.Checked ? "Nam" : "Nữ";
                string birthday = birthdayPicker.Value.ToShortDateString();
                string dateIn = checkinPicker.Value.ToShortDateString();
                string dateOut = checkoutPicker.Value.ToShortDateString();
                string bed = bedSelected.SelectedBed.ID;
                string kcl = kclSelected.SelectedKCL.ID;
                victim = new Victim(ID, firstName, name, gender, birthday, address, cmnd, phone, kcl, bed, dateIn, dateOut);
            }
            return victim;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Victim victim = GetVictim();
            if (victim != null)
            {
                if (!Controller.CheckExistID("BENH_NHAN", victim.ID))
                {
                    string query = "INSERT BENH_NHAN VALUES(@ID, @firstname, @name, @gender, @birthday, " +
                            "@cmnd, @phone, @address, @bed, @kcl, @dateIn, @dateOut);";
                    InsertOrUpdateVictim(victim, query);
                    Thread thread = new Thread(ClearField);
                    thread.Start();
                    gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
                }
                else { MessageBox.Show("Bệnh nhân đã tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Victim victim = GetVictim();
            if (victim != null)
            {
                if (Controller.CheckExistID("BENH_NHAN", victim.ID))
                {
                    bool keepBed = cBoxBed.Checked;
                    string keepBedQuery = cBoxBed.Checked ? "" : "Giuong = @bed, ";
                    string query = "UPDATE BENH_NHAN SET Ho_lot = @firstname, Ten = @name, " +
                        "Gioi_tinh = @gender, Ngay_sinh = @birthday, CMND = @cmnd, SDT = @phone, " +
                        "Dia_chi_cu_tru = @address, " + keepBedQuery +
                        "Khu_cach_ly = @kcl, Ngay_vao = @dateIn, " +
                        "Ngay_ra_du_kien = @dateOut WHERE ID = @ID";
                    InsertOrUpdateVictim(victim, query);
                    Thread thread = new Thread(ClearField);
                    thread.Start();
                    gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
                }
                else { MessageBox.Show("Bệnh nhân không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string victimID = boxID.Text;
            if (Controller.IsEmptyField(victimID))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân");
            }
            else
            {
                string querySearch = "SELECT ID, Ho_lot, Ten, FORMAT (Ngay_sinh, 'dd/MM/yyyy ') AS Ngay_sinh," +
                        "Gioi_tinh, CMND, SDT, Dia_chi_cu_tru, Giuong, Khu_cach_ly, " +
                        "FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS Ngay_vao, FORMAT (Ngay_ra_du_kien, 'dd/MM/yyyy ') AS Ngay_ra_du_kien " +
                        "FROM BENH_NHAN " +
                        "WHERE ID = '" + victimID + "';";
                gridVictim.DataSource = ConnectionDB.LoadData(querySearch);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Thread threadClearField = new Thread(ClearField);
            threadClearField.Start();
            gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string victimID = boxID.Text;
            if (!Controller.IsEmptyField(victimID))
            {
                if (Controller.CheckExistID("BENH_NHAN", victimID))
                {
                    Thread threadClearField = new Thread(ClearField);
                    ConnectionDB.DeleteByID("BENH_NHAN", victimID);                   
                    threadClearField.Start();
                    gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
                    
                }
                else MessageBox.Show("Mã bệnh nhân không tồn tại!");
            }
            else MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
        }

        private void InsertOrUpdateVictim(Victim victim, string query, bool keepBedQuery = false)
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
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = victim.ID;
                        cmd.Parameters.AddWithValue("@firstname", DbType.String).Value = victim.Firstname;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = victim.Name;
                        cmd.Parameters.AddWithValue("@gender", DbType.String).Value = victim.Gender;
                        cmd.Parameters.AddWithValue("@birthday", DbType.String).Value = victim.Birthday;
                        cmd.Parameters.AddWithValue("@cmnd", DbType.String).Value = victim.Cmnd;
                        cmd.Parameters.AddWithValue("@phone", DbType.String).Value = victim.Phone;
                        cmd.Parameters.AddWithValue("@address", DbType.String).Value = victim.Address;
                        if (!keepBedQuery)
                        {
                            cmd.Parameters.AddWithValue("@bed", DbType.String).Value = victim.Bed;
                        }
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = victim.Kcl;
                        cmd.Parameters.AddWithValue("@dateIn", DbType.String).Value = victim.Datein;
                        cmd.Parameters.AddWithValue("@dateOut", DbType.String).Value = victim.Dateout;
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
    }
}
