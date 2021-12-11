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

            this.cbBoxRoom.DataSource = rooms;
            this.cbBoxRoom.ValueMember = "ID";
            this.cbBoxRoom.DisplayMember = "Name";
        }

        private List<Rooms> LoadRooms()
        {
            List<Rooms> rooms = new List<Rooms>();
            using (SqlConnection connect = ConnectionDB.builderDB())
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
                                string ID = reader["ID"].ToString();
                                string Name = reader["Ten_phong"].ToString();
                                rooms.Add(new Rooms() { ID = ID, Name = Name });
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
