using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class AccountForm : Form
    {
        private string _userID;
        public AccountForm(string userID)
        {
            InitializeComponent();
            _userID = userID;
            txtStatusPassword.Text = "";
        }

        private bool isValidEmail = false;
        private bool isValidPassword = false;
        private bool togglePassword = false;
        private bool isMatchPassword = false;
        
        private readonly string queryLoadData = "SELECT T.Nhan_vien AS 'Mã nhân viên', T.Email, " +
                        "C.Ho_lot AS 'Họ và tên lót', C.Ten AS 'Tên', C.Vai_tro AS 'Vai trò', " +
                        "FORMAT (T.Ngay_tao, 'dd/MM/yyyy ') AS 'Ngày tạo' " +
                        "FROM TAI_KHOAN AS T INNER JOIN CAN_BO AS C ON T.Nhan_vien = C.ID;";
        private readonly string queryLoadStaff = "SELECT C.ID AS 'Mã nhân viên', C.Ho_lot AS 'Họ và tên lót', " +
                          "C.Ten AS 'Tên', C.Vai_tro AS 'Vai trò' " +
                          "FROM TAI_KHOAN AS T " +
                          "RIGHT JOIN CAN_BO AS C " +
                          "ON T.Nhan_vien = C.ID " +
                          "WHERE T.Nhan_vien IS NULL;";

        private void AccountForm_Load(object sender, EventArgs e)
        {
            boxID.Clear();
            boxEmail.Clear();
            boxPassword.Clear();
            boxConfirm.Clear();
            gridAccount.DataSource = ConnectionDB.LoadData(queryLoadData);
            gridStaff.DataSource = ConnectionDB.LoadData(queryLoadStaff);
        }

        private List<string> GetField()
        {
            List<string> fields = new List<string>()
            {
                boxID.Text, boxEmail.Text, boxPassword.Text, boxConfirm.Text
            };

            if (fields.Any(field => string.IsNullOrEmpty(field)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return new List<string>();
            }
            return fields;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        { 
            List<string> staffInfor = GetField();
            if (staffInfor.Count() != 0) 
            {
                if (isValidEmail && isValidPassword && isMatchPassword)
                {
                    string staffID = boxID.Text;
                    string email = boxEmail.Text;
                    if (!ConnectionDB.CheckExistField("TAI_KHOAN", "Nhan_vien", staffID))
                    {
                        if (!ConnectionDB.CheckExistField("TAI_KHOAN", "Email", email))
                        {
                            string password = Controller.GetMD5(email, boxPassword.Text);
                            string query = "INSERT TAI_KHOAN VALUES(@staffID, @email, @password, @date);";
                            InsertOrUpdate(staffID, email, password, query);
                            AccountForm_Load(sender, e);
                        }
                        else { MessageBox.Show("Tài khoản đã được sử dụng!"); }
                    }
                    else { MessageBox.Show("Nhân viên này đã có tài khoản!"); }
                }
                else { MessageBox.Show("Email hoặc mật khẩu chưa hợp lệ!"); }
            }      
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            List<string> staffInfor = GetField();
            if (staffInfor.Count() != 0)
            {
                if (isValidEmail && isValidPassword && isMatchPassword)
                {
                    string staffID = boxID.Text;
                    string email = boxEmail.Text;
                    if (ConnectionDB.CheckNewEmail(staffID, email))
                    {
                        string password = Controller.GetMD5(email, boxPassword.Text);
                        string query = "UPDATE TAI_KHOAN SET Email = @email, Mat_khau = @password WHERE Nhan_vien = @staffID;";                         
                        if (InsertOrUpdate(staffID, email, password, query, true))
                        {
                            if (staffID == _userID)
                            {
                                Application.Restart();
                            }
                            gridAccount.DataSource = ConnectionDB.LoadData(queryLoadData);
                        }
                        else { MessageBox.Show("Nhân viên này chưa có tài khoản!"); }                              
                    }
                    else { MessageBox.Show("Tài khoản đã được sử dụng!"); }    
                }
                else { MessageBox.Show("Email hoặc mật khẩu chưa hợp lệ!"); }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string staffID = boxID.Text;
            if (!string.IsNullOrEmpty(staffID))
            {
                if (ConnectionDB.DeleteField("TAI_KHOAN", "Nhan_vien", staffID))
                {
                    AccountForm_Load(sender, e);
                } else { MessageBox.Show("Mã nhân viên không hợp lệ!"); }
            }
            else { MessageBox.Show("Vui lòng nhập mã nhân viên!"); }
        }

        private void boxEmail_TextChanged(object sender, EventArgs e)
        {
            if (boxEmail.Text.Length == 0)
            {
                txtStatusEmail.Text = "";
                isValidEmail = false;
            }
            else if (boxEmail.Text.Contains("@") && boxEmail.Text.Contains(".com"))
            {
                txtStatusEmail.Text = "";
                isValidEmail = true;
            }
            else
            {
                txtStatusEmail.Text = "Không hợp lệ";
                txtStatusEmail.ForeColor = Color.Red;
                isValidEmail = false;
            }
        }

        private void boxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = boxPassword.Text;
            boxConfirm_TextChanged(sender, e);
            if (password.Length == 0)
            {
                txtStatusPassword.Text = "";
                isValidPassword = false;
            }
            else if (Controller.IsValidPassword(password))
            {
                txtStatusPassword.Text = "Mạnh";
                txtStatusPassword.ForeColor = Color.Green;
                isValidPassword = true;
            }
            else
            {
                txtStatusPassword.Text = "Yếu";
                txtStatusPassword.ForeColor = Color.Red;
                isValidPassword = false;
            }
        }

        private void BtnTogglePassword_Click(object sender, EventArgs e)
        {
            boxPassword.Focus();
            togglePassword = !togglePassword;
            BtnTogglePassword.Text = togglePassword ? "Ẩn" : "Hiện";
            boxPassword.PasswordChar = togglePassword ? '\0' : '*';
        }

        private void boxConfirm_TextChanged(object sender, EventArgs e)
        {
            if (boxConfirm.Text.Length == 0)
            {
                txtConfirm.Text = "";
                isMatchPassword = false;
            }
            else if (boxPassword.Text == boxConfirm.Text)
            {
                txtConfirm.Text = "Khớp";
                txtConfirm.ForeColor = Color.Green;
                isMatchPassword = true;
            }
            else
            {
                txtConfirm.Text = "Không khớp";
                txtConfirm.ForeColor = Color.Red;
                isMatchPassword= false;
            }
        }

        private bool InsertOrUpdate(string staffID, string email, string password, string query, bool isUpdate = false)
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
                        cmd.Parameters.AddWithValue("@staffID", DbType.String).Value = staffID;
                        cmd.Parameters.AddWithValue("@email", DbType.String).Value = email;
                        cmd.Parameters.AddWithValue("@password", DbType.String).Value = password;
                        if (!isUpdate)
                        {
                            cmd.Parameters.AddWithValue("@date", DbType.String).Value = DateTime.UtcNow.Date.ToString("d");
                        }
                        var i = cmd.ExecuteNonQuery();
                        connect.Close();
                        if (i != 0) return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return false;
                }
            }
        }
    }
}
