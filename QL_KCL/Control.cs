using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                  ManagerForm managerForm = new ManagerForm();
                  managerForm.Show();
                    break;
                case "Bác sĩ":
                  DoctorForm doctorForm = new DoctorForm();
                  doctorForm.Show();
                    break;
                case "Quản trị viên":
                    AdminForm adminForm = new AdminForm();
                  adminForm.Show();
                    break;
                default:
                    NursingForm nursingForm = new NursingForm();
                    nursingForm.Show();
                    break; 
            }
        }

        public string GetMD5(string userEmail, string userPassword)
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
    }
}
