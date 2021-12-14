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
    public partial class VictimSelected : UserControl
    {
        public VictimSelected()
        {
            InitializeComponent();
        }

        public Victims SelectedVicim
        {
            get { return (Victims)cbBoxVictim.SelectedItem; } 
        }

        private void RefreshData()
        {
            cbBoxVictim.DataSource = LoadVictim();
        }

        private void VictimSelected_Load(object sender, EventArgs e)
        {
            cbBoxVictim.DataSource = LoadVictim();
            cbBoxVictim.ValueMember = "ID";
            cbBoxVictim.DisplayMember = "ID";
        }

        private List<Victims> LoadVictim()
        {
            List<Victims> victims = new List<Victims>();
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT B.ID " +
                                    "FROM BENH_NHAN AS B " +
                                    "LEFT JOIN  TT_SUC_KHOE AS T " +
                                    "ON B.ID = T.ID " +
                                    "WHERE T.ID IS NULL; ";

                    try
                    {
                        connect.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string _ID = reader["ID"].ToString();
                                victims.Add(new Victims() { ID = _ID });
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

            return victims;
        }
    }
}
