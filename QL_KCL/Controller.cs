using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{

    class Controller
    {
        public static void CheckRole(LoginForm loginForm, string userID, string userName, string userRole)
        {
            loginForm.Hide();
            switch (userRole)
            {
               case "Giám đốc":
                    ManagerForm managerForm = new ManagerForm(userID, userName, userRole);
                    managerForm.Show();
                    break;
                case "Bác sĩ":
                    DoctorForm doctorForm = new DoctorForm(userID, userName, userRole);
                    doctorForm.Show();
                    break;
                case "Admin":
                    AdminForm adminForm = new AdminForm(userID, userName);
                    adminForm.Show();
                    break;
                default:
                    NursingForm nursingForm = new NursingForm(userID, userName, userRole);
                    nursingForm.Show();
                    break; 
            }
        }

        public static string GetMD5(string userEmail, string userPassword)
        {
            string password = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(userEmail + userPassword);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte item in buffer)
            {
                password += item.ToString("X2");
            }
            return password;
        }

        public static bool IsEmptyField(string field)
        {
            if (field.Trim() == "")
            {
                return true;
            }
            return false;
        }

        public static bool CheckExistID(string tableName, string ID)
        {
            bool isExist = true;
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT * FROM " + tableName + " WHERE ID = @ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connect.Open();
                        var reader = cmd.ExecuteReader();
                        isExist = reader.HasRows;
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return isExist;
        }

        public static Form OpenChildForm(Panel panelMain, Form currentForm, Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Anchor = AnchorStyles.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            return childForm;
        }
    }
}
