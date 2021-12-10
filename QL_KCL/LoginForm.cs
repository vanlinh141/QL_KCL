using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = boxEmail.Text;
            string password = boxPass.Text;
            if (Control.isEmptyField(email) || Control.isEmptyField(password))
            {
                MessageBox.Show("Email hoặc mật khẩu không được bỏ trống");
            } else
            {
               login(email, password);
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void login(string email, string password)
        {
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT Email, Mat_khau, Vai_tro, Ten " +
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
                                    string userName = records["Ten"].ToString();
                                    string role = records["Vai_tro"].ToString();
                                    // string userEmail = records["Email"].ToString();
                                    // string userPassword = records["Mat_khau"].ToString();                          
                                    // userPassword = GetMD5(userEmail, userPassword);
                                    Control.checkRole(this, userName, role);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email hoặc mật khẩu không đúng");
                            }
                        }
                        connect.Close(); 
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
