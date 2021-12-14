using System.Windows.Forms;

namespace QL_KCL
{
    public partial class AdminForm : Form
    {
        private static string _userID;
        private static string _userName;
        public AdminForm(string userID, string userName)
        {
            InitializeComponent();
            UserID = userID;
            UserName = userName;
        }

        public static string UserName { get => _userName; set => _userName = value; }
        public static string UserID { get => _userID; set => _userID = value; }
    }
}
