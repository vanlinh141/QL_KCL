using System;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class ManagerForm : Form
    {
        public static string _userID;
        public delegate void UserInfor(string value);
        public ManagerForm(string userID, string userName)
        {
            InitializeComponent();
            txtUserName.Text = userName;
            _userID = userID;
        }

        private void SetValue(String value)
        {
            txtUserName.Text = value;
        }

        private Form currentForm;

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new StaffForm(SetValue, _userID));
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new StaffForm(SetValue, _userID));
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new ReportForm());
        }
    }
}
