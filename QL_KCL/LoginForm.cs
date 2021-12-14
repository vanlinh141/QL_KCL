using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Controller.IsEmptyField(boxEmail.Text) || Controller.IsEmptyField(boxPass.Text))
            {
                MessageBox.Show("Email hoặc mật khẩu không được bỏ trống");
            }
            else
            {
                Login(boxEmail.Text, boxPass.Text);
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void Login(string email, string password)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT Email, Mat_khau, Vai_tro, Ten, ID " +
                                      "FROM TAI_KHOAN " +
                                      "INNER JOIN CAN_BO ON TAI_KHOAN.Nhan_vien = CAN_BO.ID " +
                                      "WHERE Email = @Email AND Mat_khau = @Matkhau";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Matkhau", password);

                    try
                    {
                        connect.Open();
                        using (var records = cmd.ExecuteReader())
                        {
                            if (records.HasRows)
                            {
                                while (records.Read())
                                {
                                    string userID = records["ID"].ToString();
                                    string userName = records["Ten"].ToString();
                                    string userRole = records["Vai_tro"].ToString();
                                    Controller.CheckRole(this, userID, userName, userRole);
                                }
                            }
                            else MessageBox.Show("Email hoặc mật khẩu không đúng");
                        }
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
