using System.Windows.Forms;

namespace QL_KCL
{
    public partial class AdminForm : Form
    {
        private static string _userID;
        public AdminForm(string userID, string userName)
        {
            InitializeComponent();
            _userID = userID;
            txtUsername.Text = userName;
        }

        private Form currentForm;

        private void AdminForm_Load(object sender, System.EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new AccountForm(_userID));
        }

        private void BtnAccount_Click(object sender, System.EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new AccountForm(_userID));
        }
    }
}
