using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class RoomSelected : UserControl
    {
        public RoomSelected()
        {
            InitializeComponent();
        }
        public Rooms SelectedRoom
        {
            get { return (Rooms)cbBoxRoom.SelectedItem; }
        }

        private void RoomSelected_Load(object sender, EventArgs e)
        {
            List<Rooms> rooms = LoadRooms();
            cbBoxRoom.DataSource = rooms;
            cbBoxRoom.ValueMember = "ID";
            cbBoxRoom.DisplayMember = "Name";
        }

        private List<Rooms> LoadRooms()
        {
            List<Rooms> rooms = new List<Rooms>();
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT ID, Ten_phong FROM PHONG;";
                    try
                    {
                        connect.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string _ID = reader["ID"].ToString();
                                string _Name = reader["Ten_phong"].ToString();
                                rooms.Add(new Rooms() { ID = _ID, Name = _Name });
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
            return rooms;
        }
    }
}
