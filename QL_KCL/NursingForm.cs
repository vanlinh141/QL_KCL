using System;
using System.Windows.Forms;
namespace QL_KCL
{
    public partial class NursingForm : Form
    {
        private static string _userID;
        private static string _userRole;
        public NursingForm(string userID, string userName, string userRole)
        {
            InitializeComponent();
            txtUserName.Text = userName;
            _userID = userID;
            _userRole = userRole;
        }

        private Form currentForm;

        private void NursingForm_Load(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new VictimForm(_userRole));
        }

        private void BtnBed_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new BedForm());
        }

        private void BtnDevice_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new DeviceForm(_userID));
        }

        private void BtnVictim_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new VictimForm(_userRole));
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new TestForm(_userID));
        }

        private void BtnHealth_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new HealthForm(_userRole));
        }
    }
}
