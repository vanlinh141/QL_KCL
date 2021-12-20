using System;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class LogoutButton : UserControl
    {
        public LogoutButton()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
