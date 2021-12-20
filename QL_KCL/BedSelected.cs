using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class BedSelected : UserControl
    {
        public BedSelected()
        {
            InitializeComponent();
        }

        public Beds SelectedBed
        {
            get { return (Beds)cbBoxBed.SelectedItem; }
        }

        public bool RefreshData()
        {
            List<Beds> beds = LoadBed();
            if (beds.Count > 0)
            {
                cbBoxBed.DataSource = beds;
                cbBoxBed.ValueMember = "ID";
                cbBoxBed.DisplayMember = "ID";
                return true;
            } else
            {
                cbBoxBed.DataSource = new List<string>(){"<Đã hết giường>"};
                return false;
            }     
        }

        private void BedSelected_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private List<Beds> LoadBed()
        {
            List<Beds> beds = new List<Beds>();
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT G.ID " +
                        "FROM GIUONG AS G " +
                        "LEFT JOIN BENH_NHAN AS B " +
                        "ON G.ID = B.Giuong " +
                        "WHERE B.ID IS NULL; ";
                    try
                    {
                        connect.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string _ID = reader["ID"].ToString();
                                beds.Add(new Beds() { ID = _ID });
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
            return beds;
        }
    }
}
