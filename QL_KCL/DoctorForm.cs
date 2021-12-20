using System;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class DoctorForm : Form
    {
        public DoctorForm(string userName, string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
            txtUsername.Text = userName;      
        }

        private Form currentForm;
  
        public static string UserRole { get; set; }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new VictimForm(UserRole));
        }

        private void BtnVictim_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new VictimForm(UserRole));
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new HealthForm(UserRole));
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new ReportForm());
        }
    }
}
