using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class StaffForm : Form
    {
        private string _userID;
        private bool isReset = false;
        public delegate void UserInfor(string value);
        public UserInfor reloadUserInfor;
        public StaffForm(UserInfor sender, string userID)
        {
            InitializeComponent();
            birthdayPicker.CustomFormat = "dd-MM-yyyy";
            dateInPicker.CustomFormat = "dd-MM-yyyy";
            cbBoxRole.SelectedIndex = 0;
            _userID = userID;
            reloadUserInfor = sender;
        }

        private readonly string queryLoadData = "SELECT ID AS 'Mã nhân viên', Ho_lot AS 'Họ và tên lót', " +
            "Ten AS 'Tên', Gioi_tinh AS 'Giới tính', " +
            "FORMAT(Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Vai_tro AS 'Vai trò', Bo_phan AS 'Bộ phận', " +
            "FORMAT (Ngay_lam, 'dd/MM/yyyy ') AS 'Ngày vào làm', Khu_cach_ly AS 'Khu cách ly', CMND, SDT, " +
            "Dia_chi_cu_tru AS 'Địa chỉ cư trú' FROM CAN_BO WHERE Vai_tro != 'Admin';";

        private void StaffForm_Load(object sender, EventArgs e)
        {
            boxID.Clear();
            boxFirstname.Clear();
            boxName.Clear();
            rdbMale.Checked = true;
            boxCMND.Clear();
            boxPhone.Clear();
            boxAddress.Clear();
            boxPartial.Clear();
            cbBoxRole.SelectedIndex = 0;
            dateInPicker.ResetText();
            birthdayPicker.ResetText();
            kclSelected.ResetText();
            gridStaff.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private Staff GetStaff()
        {
            Staff staff = null;
            List<string> fields = new List<string>()
            {
                boxID.Text, boxFirstname.Text, boxName.Text,
                boxCMND.Text, boxPhone.Text, boxAddress.Text, boxPartial.Text
            };
            if (fields.All(field => !string.IsNullOrEmpty(field)))
            {
                string cmnd = boxCMND.Text;
                string phone = boxPhone.Text;
                if (Controller.IsValidNumberField(cmnd) && Controller.IsValidNumberField(phone))
                {
                    string ID = boxID.Text;
                    string firstname = boxFirstname.Text;
                    string name = boxName.Text;
                    string gender = rdbMale.Checked ? "Nam" : "Nữ";
                    string birthday = birthdayPicker.Value.ToShortDateString();
                    string address = boxAddress.Text;
                    string kcl = kclSelected.SelectedKCL.ID;
                    string datein = dateInPicker.Value.ToShortDateString();
                    string role = cbBoxRole.Text;
                    string partial = boxPartial.Text;
                    staff = new Staff(ID, firstname, name, gender, birthday, address,
                                        cmnd, phone, kcl, datein, role, partial);
                }
                else { MessageBox.Show("Số CMND hoặc số điện thoại không hợp lệ!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
            return staff;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Staff staff = GetStaff();
            if (staff != null)
            {
                if (!ConnectionDB.CheckExistField("CAN_BO", "ID", staff.ID))
                {
                    string queryInsert = "INSERT CAN_BO VALUES(@ID, @firstname, @name, @gender, @birthday, " +
                            "@role, @partial, @datein, @kcl, @cmnd, @phone, @address)";
                    InsertOrUpdate(staff, queryInsert);
                    StaffForm_Load(sender, e);
                }
                else { MessageBox.Show("Nhân viên đã tồn tại!"); }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            StaffForm_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string staffID = boxID.Text;
            if (!string.IsNullOrEmpty(staffID))
            {
                string querySearch = "SELECT ID, Ho_lot, Ten, Gioi_tinh, " +
                    "FORMAT(Ngay_sinh, 'dd/MM/yyyy ') AS Ngay_sinh, Vai_tro, Bo_phan, " +
                    "FORMAT (Ngay_lam, 'dd/MM/yyyy ') AS Ngay_vao_lam, Khu_cach_ly, CMND, SDT, " +
                    "Dia_chi_cu_tru FROM CAN_BO WHERE Vai_tro != 'Admin' AND ID = '" + staffID + "';";
                gridStaff.DataSource = ConnectionDB.LoadData(querySearch);
            }
            else { MessageBox.Show("Vui lòng nhập mã nhân viên!"); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Staff staff = GetStaff();
            if (staff != null)
            {
                string queryUpdate = "UPDATE CAN_BO SET Ho_lot = @firstname, Ten = @name, Gioi_tinh = @gender, " +
                        "Ngay_sinh = @birthday, Vai_tro = @role, Bo_phan = @partial, " +
                        "Ngay_lam = @datein, Khu_cach_ly = @kcl, CMND = @cmnd, SDT = @phone, " +
                        "Dia_chi_cu_tru = @address WHERE ID = @ID";
                if (InsertOrUpdate(staff, queryUpdate))
                {
                    if (_userID == staff.ID)
                    {
                        reloadUserInfor(GetUserName(staff.ID));
                        if (isReset) { Application.Restart(); }
                    }
                    StaffForm_Load(sender, e);
                }
                else { MessageBox.Show("Nhân viên không tồn tại!"); }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string staffID = boxID.Text;
            if (!string.IsNullOrEmpty(staffID))
            {
                if (ConnectionDB.DeleteField("TAI_KHOAN", "Nhan_vien", staffID) 
                    && ConnectionDB.DeleteField("CAN_BO", "ID", staffID))
                {   
                    StaffForm_Load(sender, e);
                }
                else { MessageBox.Show("Mã nhân viên không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập mã nhân viên!"); }
        }

        private bool InsertOrUpdate(Staff staff, string query)
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
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = staff.ID;
                        cmd.Parameters.AddWithValue("@firstname", DbType.String).Value = staff.Firstname;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = staff.Name;
                        cmd.Parameters.AddWithValue("@gender", DbType.String).Value = staff.Gender;
                        cmd.Parameters.AddWithValue("@birthday", DbType.String).Value = staff.Birthday;
                        cmd.Parameters.AddWithValue("@cmnd", DbType.String).Value = staff.Cmnd;
                        cmd.Parameters.AddWithValue("@phone", DbType.String).Value = staff.Phone;
                        cmd.Parameters.AddWithValue("@address", DbType.String).Value = staff.Address;
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = staff.Kcl;
                        cmd.Parameters.AddWithValue("@datein", DbType.String).Value = staff.Datein;
                        cmd.Parameters.AddWithValue("@role", DbType.String).Value = staff.Role;
                        cmd.Parameters.AddWithValue("@partial", DbType.String).Value = staff.Partial;
                        var i = cmd.ExecuteNonQuery();
                        connect.Close();
                        if (i != 0) { return true; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return false;
                }
            }
        }

        private string GetUserName(string staffID)
        {
            string userName = "Username";
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "SELECT Ten, Vai_tro FROM CAN_BO WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@ID", staffID);
                        using (var records = cmd.ExecuteReader())
                        {
                            while (records.Read())
                            {
                                userName = records["Ten"].ToString();
                                string userRole = records["Vai_tro"].ToString();
                                if (userRole != "Giám đốc")
                                {
                                    isReset = true;
                                }
                            }
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return userName;
        }
    }
}
