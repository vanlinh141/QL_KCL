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
    public partial class ExitButton : UserControl
    {
        public ExitButton()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            
        }
    }
}
