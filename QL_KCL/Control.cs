using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{

    class Control
    {
        public static void checkRole(LoginForm loginForm, string userName, string role)
        {
            loginForm.Hide();
            switch (role)
            {
               case "Giám đốc":
                    ManagerForm managerForm = new ManagerForm(userName);
                    managerForm.Show();
                    break;
                case "Bác sĩ":
                    DoctorForm doctorForm = new DoctorForm(userName);
                    doctorForm.Show();
                    break;
                case "Admin":
                    AdminForm adminForm = new AdminForm(userName);
                    adminForm.Show();
                    break;
                default:
                    NursingForm nursingForm = new NursingForm(userName);
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

        public static bool isEmptyField(string field)
        {
            if (field.Trim() == "")
            {
                return true;
            }
            else return false;
        }
        public static bool CheckExistID(string tableName, string ID)
        {
            bool isExist = true;
            using (SqlConnection connect = ConnectionDB.builderDB())
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            return isExist;
        }
    }
}
