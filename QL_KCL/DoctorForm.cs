using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class DoctorForm : Form
    {
        public DoctorForm(string userID, string userName, string userRole)
        {
            InitializeComponent();
            UserID = userID;
            UserName = userName;
            UserRole = userRole;
        }

        private Form currentForm;

       
        public static string UserID { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new StatusVictimForm());
        }

        private void BtnVictim_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new VictimForm(UserRole));
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            currentForm = Controller.OpenChildForm(panelMain, currentForm, new StatusVictimForm());
        }
    }
}
