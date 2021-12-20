using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class VictimForm : Form
    {
        public VictimForm(string userRole)
        {
            InitializeComponent();
            birthdayPicker.CustomFormat = "dd-MM-yyyy";
            dateinPicker.CustomFormat = "dd-MM-yyyy";
            dateoutPicker.CustomFormat = "dd-MM-yyyy";
            if (userRole == "Điều dưỡng")
            {
                BtnDelete.Hide();
            }
        }   

        private readonly string queryLoadData = "SELECT ID AS 'Mã bệnh nhân', Ho_lot AS 'Họ và tên lót', Ten AS 'Tên', " +
                        "FORMAT (Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Gioi_tinh AS 'Giới tính', CMND, SDT, " +
                        "Dia_chi_cu_tru AS 'Địa chỉ cư trú', Giuong 'Giường', Khu_cach_ly AS 'Khu cách ly', " +
                        "FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', " +
                        "FORMAT (Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến' FROM BENH_NHAN;";

        private void VictimForm_Load(object sender, EventArgs e)
        {
            bedSelected.RefreshData();
            boxID.Clear();
            boxFirstName.Clear();
            boxName.Clear();
            rdbMale.Checked = true;
            boxCMND.Clear();
            boxPhone.Clear();
            boxAddress.Clear();
            cBoxBed.Checked = false;
            birthdayPicker.ResetText();
            dateinPicker.ResetText();
            dateoutPicker.ResetText();
            gridVictim.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private Victim GetVictim()
        {
            Victim victim = null;
            List<string> fields = new List<string>()
            {
                boxID.Text, boxFirstName.Text, boxName.Text, boxAddress.Text
            };
            if (fields.All(field => !string.IsNullOrEmpty(field)))
            {
                string cmnd = boxCMND.Text;
                string phone = boxPhone.Text;
                if ((string.IsNullOrEmpty(cmnd) && string.IsNullOrEmpty(phone))
                    || (Controller.IsValidNumberField(cmnd) && Controller.IsValidNumberField(cmnd)))
                {
                    string ID = boxID.Text;
                    string firstName = boxFirstName.Text;
                    string name = boxName.Text;
                    string address = boxAddress.Text;
                    string gender = rdbMale.Checked ? "Nam" : "Nữ";
                    string birthday = birthdayPicker.Value.ToShortDateString();
                    string dateIn = dateinPicker.Value.ToShortDateString();
                    string dateOut = dateoutPicker.Value.ToShortDateString();
                    string bed = bedSelected.SelectedBed.ID;
                    string kcl = kclSelected.SelectedKCL.ID;
                    victim = new Victim(ID, firstName, name, gender, birthday, address,
                                        cmnd, phone, kcl, bed, dateIn, dateOut);
                } else { MessageBox.Show("Số CMND hoặc số điện thoại không hợp lệ!"); }            
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
            return victim;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (bedSelected.RefreshData())
            {
            
                Victim victim = GetVictim();
                if (victim != null)
                {
                    if (!ConnectionDB.CheckExistField("BENH_NHAN", "ID", victim.ID))
                    {
                        string queryInsert = "INSERT BENH_NHAN VALUES(@ID, @firstname, @name, @gender, @birthday, " +
                                "@cmnd, @phone, @address, @bed, @kcl, @dateIn, @dateOut);";                                   
                        InsertOrUpdate(victim, queryInsert);
                        VictimForm_Load(sender, e);
                    }
                    else { MessageBox.Show("Bệnh nhân đã tồn tại!"); }
                }
            } else MessageBox.Show("Giường trống đã hết, vui lòng nhập thêm giường mới!");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Victim victim = GetVictim();
            if (victim != null)
            {
                bool keepBed = cBoxBed.Checked;
                string keepBedQuery = keepBed ? "" : "Giuong = @bed, ";
                string queryUpdate = "UPDATE BENH_NHAN SET Ho_lot = @firstname, Ten = @name, " +
                    "Gioi_tinh = @gender, Ngay_sinh = @birthday, CMND = @cmnd, SDT = @phone, " +
                    "Dia_chi_cu_tru = @address, " + keepBedQuery +
                    "Khu_cach_ly = @kcl, Ngay_vao = @dateIn, " +
                    "Ngay_ra_du_kien = @dateOut WHERE ID = @ID";
                if (InsertOrUpdate(victim, queryUpdate, keepBed))
                {                  
                    VictimForm_Load(sender, e);
                }
                else { MessageBox.Show("Bệnh nhân không tồn tại!"); }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string victimID = boxID.Text;
            if (string.IsNullOrEmpty(victimID))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân");
            }
            else
            {
                string querySearch = "SELECT ID AS 'Mã bệnh nhân', Ho_lot AS 'Họ và tên lót', Ten AS 'Tên', " +
                        "FORMAT (Ngay_sinh, 'dd/MM/yyyy ') AS 'Ngày sinh', Gioi_tinh AS 'Giới tính', CMND, SDT, " +
                        "Dia_chi_cu_tru AS 'Địa chỉ cư trú', Giuong 'Giường', Khu_cach_ly AS 'Khu cách ly', " +
                        "FORMAT(Ngay_vao, 'dd/MM/yyyy ') AS 'Ngày vào', " +
                        "FORMAT (Ngay_ra_du_kien, 'dd/MM/yyyy ') AS 'Ngày ra dự kiến' FROM BENH_NHAN WHERE ID = '" + victimID + "';";
                gridVictim.DataSource = ConnectionDB.LoadData(querySearch);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            VictimForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {      
            string victimID = boxID.Text;
            if (!string.IsNullOrEmpty(victimID))
            {
                string message = "Xóa bệnh nhân này sẽ khiến các dữ liệu liên quan cũng bị xóa?";
                string title = "Cảnh báo";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    ConnectionDB.DeleteField("KQ_XET_NGHIEM", "Benh_nhan", victimID);
                    ConnectionDB.DeleteField("TT_SUC_KHOE", "ID", victimID);
                    if (ConnectionDB.DeleteField("BENH_NHAN", "ID", victimID))
                    {
                        VictimForm_Load(sender, e);
                    }
                    else MessageBox.Show("Mã bệnh nhân không tồn tại!");
                }
                else
                {
                    return;
                }
            }
            else MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
        }

        private bool InsertOrUpdate(Victim victim, string query, bool keepBed = false)
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
                        if (!keepBed)
                        {
                            cmd.Parameters.AddWithValue("@bed", DbType.String).Value = victim.Bed;
                        }
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = victim.Kcl;
                        cmd.Parameters.AddWithValue("@dateIn", DbType.String).Value = victim.Datein;
                        cmd.Parameters.AddWithValue("@dateOut", DbType.String).Value = victim.Dateout;
                        var i = cmd.ExecuteNonQuery();                     
                        if (i != 0) { return true; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                    return false;
                }
            }
        }
    }
}
