using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                    ManagerForm managerForm = new ManagerForm(userID, userName);
                    managerForm.Show();
                    break;
                case "Bác sĩ":
                    DoctorForm doctorForm = new DoctorForm(userName, userRole);
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

        public static UserControl OpenChildGrid(Panel panelMain, UserControl currentForm, UserControl childForm)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
            }
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Anchor = AnchorStyles.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            return childForm;
        }

        public static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) &&
                hasMinimum8Chars.IsMatch(password);
            return isValidated;
        }

        public static bool IsValidNumberField(string field)
        {
            try
            {
                var convertNumber = long.Parse(field);
                var hasMinimum8Chars = new Regex(@".{9,}");
                var isValidated = hasMinimum8Chars.IsMatch(field);
                return isValidated;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
