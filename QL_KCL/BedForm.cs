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
    public partial class BedForm : Form
    {
        public BedForm()
        {
            InitializeComponent();
        }

        private void ClearField()
        {
            boxBedID.Clear();
        }

        private void BedForm_Load(object sender, EventArgs e)
        {
            try
            {
                gridBed.DataSource = LoadData();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            if (!Control.isEmptyField(bedID))
            {
                if (!Control.CheckExistID("GIUONG", bedID)) 
                {
                    if (AddBed(bedID, roomID))
                    {
                        ClearField();
                        gridBed.DataSource = LoadData();
                    }
                }
                else MessageBox.Show("Mã giường đã tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            if (!Control.isEmptyField(bedID))
            {
                if (Control.CheckExistID("GIUONG", bedID))
                {
                    if (UpdateBed(bedID, roomID))
                    {
                        ClearField();
                        gridBed.DataSource = LoadData();
                    }
                }
                else MessageBox.Show("Mã giường không tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            if (!Control.isEmptyField(bedID))
            {
                if (Control.CheckExistID("GIUONG", bedID))
                {
                    if (DeleteBed(bedID, roomID))
                    {
                        ClearField();
                        gridBed.DataSource = LoadData();
                    }
                    else MessageBox.Show("Mã giường không tồn tại");
                }
                else MessageBox.Show("Mã giường không tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private bool AddBed(string bedID, string roomID)
        {
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "INSERT GIUONG VALUES(@bedID, @roomID);";
                        cmd.Parameters.AddWithValue("@bedID", DbType.String).Value = bedID;
                        cmd.Parameters.AddWithValue("@roomID", DbType.String).Value = roomID;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                    return false;
                }
            }
        }

        private bool UpdateBed(string bedID, string roomID)
        {
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "UPDATE GIUONG SET Phong = @roomID WHERE ID = @bedID;";
                        cmd.Parameters.AddWithValue("@bedID", DbType.String).Value = bedID;
                        cmd.Parameters.AddWithValue("@roomID", DbType.String).Value = roomID;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                    return false;
                }
            }
        }

        private bool DeleteBed(string bedID, string roomID)
        {
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "DELETE GIUONG WHERE ID = @bedID AND Phong = @roomID;";
                        cmd.Parameters.AddWithValue("@bedID", DbType.String).Value = bedID;
                        cmd.Parameters.AddWithValue("@roomID", DbType.String).Value = roomID;
                        var i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            return true;
                        } 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                    return false;
                }
            }
        }

        private DataTable LoadData()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                string query = "SELECT GIUONG.ID, GIUONG.Phong, PHONG.Ten_phong " +
                                  "FROM GIUONG " +
                                  "INNER JOIN PHONG " +
                                  "ON GIUONG.Phong = PHONG.ID; ";
                try
                {
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    adapter.Fill(dataTable);
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dataTable;
            }
        }
    }
}
