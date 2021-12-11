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
    public partial class NursingForm : Form
    {
        public NursingForm(string userName)
        {
            InitializeComponent();
            this.txtUserName.Text = userName;
        }

        private Form currentForm;

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Anchor = AnchorStyles.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BedForm());
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeviceForm());
        }

        private void NursingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
