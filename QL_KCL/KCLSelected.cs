using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class KCLSelected : UserControl
    {
        public KCLSelected()
        {
            InitializeComponent();
        }

        public KCLs SelectedKCL
        {
            get { return (KCLs)cbBoxKCL.SelectedItem; }
        }

        private void KCLSelected_Load(object sender, EventArgs e)
        {
            List<KCLs> kcls = LoadKCL();

            this.cbBoxKCL.DataSource = kcls;
            this.cbBoxKCL.ValueMember = "ID";
            this.cbBoxKCL.DisplayMember = "Name";
        }

        private List<KCLs> LoadKCL()
        {
            List<KCLs> kcls = new List<KCLs>();
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT ID, Ten_KCL FROM KHU_CACH_LY;";

                    try
                    {
                        connect.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ID = reader["ID"].ToString();
                                string Name = reader["Ten_KCL"].ToString();
                                kcls.Add(new KCLs() { ID = ID, Name = Name });
                            }
                        }
                        connect.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return kcls;
        }
    }
}
