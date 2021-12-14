using System;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(string userID, string userName, string userRole)
        {
            InitializeComponent();
            UserID = userID;
            UserName = userName;
            UserRole = userRole;
        }

        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
    }
}
