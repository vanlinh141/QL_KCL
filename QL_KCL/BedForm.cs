using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class BedForm : Form
    {
        public BedForm()
        {
            InitializeComponent();
        }

        private readonly string queryLoadData = "SELECT G.ID, G.Phong, P.Ten_phong " +
                                  "FROM GIUONG AS G " +
                                  "INNER JOIN PHONG AS P " +
                                  "ON G.Phong = P.ID; ";

        private void ReloadData()
        {
            boxBedID.Clear();
            gridBed.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void BedForm_Load(object sender, EventArgs e)
        {
            gridBed.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            if (!Controller.IsEmptyField(bedID))
            {
                if (!Controller.CheckExistID("GIUONG", bedID))
                {
                    string query = "INSERT GIUONG VALUES(@bedID, @roomID);";
                    InsertOrUpdateBed(bedID, roomID, query);
                    ReloadData();
                }
                else MessageBox.Show("Mã giường đã tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            if (!Controller.IsEmptyField(bedID))
            {
                if (Controller.CheckExistID("GIUONG", bedID))
                {
                    string query = "UPDATE GIUONG SET Phong = @roomID WHERE ID = @bedID;";
                    InsertOrUpdateBed(bedID, roomID, query);
                    ReloadData();
                    
                }
                else MessageBox.Show("Mã giường không tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string roomID = roomSelected.SelectedRoom.ID;
            string bedID = boxBedID.Text;
            
            if (!Controller.IsEmptyField(bedID))
            {
                if (Controller.CheckExistID("GIUONG", bedID))
                {
                    if (!IsUsed(bedID))
                    {
                        if (DeleteBed(bedID, roomID))
                        {
                            ReloadData();
                        }
                        else MessageBox.Show("Không tìm thấy giường tương ứng!");
                    }
                    else MessageBox.Show("Không thể xóa vì giường đang được sử dụng");
                }
                else MessageBox.Show("Mã giường không tồn tại");
            }
            else MessageBox.Show("Mã giường không được bỏ trống");
        }

        private void InsertOrUpdateBed(string bedID, string roomID, string query)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@bedID", DbType.String).Value = bedID;
                        cmd.Parameters.AddWithValue("@roomID", DbType.String).Value = roomID;
                        cmd.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool DeleteBed(string bedID, string roomID)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
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
                        connect.Close();
                        if (i != 0)
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return false;
                }
            }
        }

        public static bool IsUsed(string bedID)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connect;
                    cmd.CommandText = "SELECT G.ID " +
                                    "FROM GIUONG AS G " +
                                    "WHERE G.ID = @bedID AND G.ID IN " +
                                    "(SELECT G.ID " +
                                    "FROM GIUONG " +
                                    "LEFT JOIN BENH_NHAN AS B " +
                                    "ON G.ID = B.Giuong " +
                                    "WHERE B.ID IS NOT NULL); ";
                    cmd.Parameters.AddWithValue("@bedID", bedID);
                    try
                    {
                        connect.Open();
                        using (SqlDataReader records = cmd.ExecuteReader())
                        {
                            return records.HasRows;
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
    }
}
