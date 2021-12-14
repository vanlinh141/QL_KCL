using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace QL_KCL
{
    public partial class DeviceForm : Form
    {
        public DeviceForm(string userID)
        {
            InitializeComponent();
            datePicker.CustomFormat = "dd-MM-yyyy";
            boxStaff.Text = userID;
        }

        private readonly string queryLoadData = "SELECT t.ID, t.Ten_thiet_bi, t.So_luong, t.Nhan_vien_tiep_nhan, " +
                                "FORMAT (t.Ngay_tiep_nhan, 'dd/MM/yyyy ') as Ngay_tiep_nhan, k.Ten_KCL " +
                                "FROM THIET_BI AS t " +
                                "INNER JOIN KHU_CACH_LY as k " +
                                "ON t.Khu_cach_ly = k.ID";

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            gridDevice.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void ClearField()
        {
            boxID.Clear();
            boxName.Clear();
            boxQuantity.Value = 1;
        }

        private Device GetDevice()
        {
            Device device = null;
            string ID = boxID.Text;
            string name = boxName.Text;
            if (!Controller.IsEmptyField(ID) && !Controller.IsEmptyField(name))
            {
                string staff = boxStaff.Text;
                decimal quantity = boxQuantity.Value;
                string date = datePicker.Value.ToShortDateString();
                string kcl = kclSelected.SelectedKCL.ID;
                device = new Device(ID, name, quantity, staff, kcl, date);
            }
            return device;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Device device = GetDevice();
            if (device != null)
            {
                if (!Controller.CheckExistID("THIET_BI", device.ID))
                {
                    Thread thread = new Thread(ClearField);
                    AddDevice(device);
                    thread.Start();
                    gridDevice.DataSource = ConnectionDB.LoadData(queryLoadData);
                    
                }
                else { MessageBox.Show("Thiết bị đã tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Device device = GetDevice();
            if (device != null)
            {
                if (Controller.CheckExistID("THIET_BI", device.ID))
                {
                    Thread thread = new Thread(ClearField);
                    UpdateDevice(device);                       
                    thread.Start();
                    gridDevice.DataSource = ConnectionDB.LoadData(queryLoadData);                  
                }
                else { MessageBox.Show("Thiết bị không tồn tại!"); }
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string deviceID = boxID.Text;
            if (!Controller.IsEmptyField(deviceID))
            {
                if (Controller.CheckExistID("THIET_BI", deviceID))
                {
                    Thread thread = new Thread(ClearField);
                    ConnectionDB.DeleteByID("THIET_BI", deviceID);
                    thread.Start();
                    gridDevice.DataSource = ConnectionDB.LoadData(queryLoadData);
                    
                }
                else MessageBox.Show("Mã thiết bị không tồn tại!");
            }
            else MessageBox.Show("Vui lòng nhập mã thiết bị!");
        }

        private void AddDevice(Device device)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "INSERT THIET_BI VALUES(@ID, @name, @quantity, @staff, @kcl, @date);";
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = device.ID;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = device.Name;
                        cmd.Parameters.AddWithValue("@quantity", DbType.String).Value = device.Quantity;
                        cmd.Parameters.AddWithValue("@staff", DbType.String).Value = device.Staff;
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = device.Kcl;
                        cmd.Parameters.AddWithValue("@date", DbType.String).Value = device.Date;
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

        private void UpdateDevice(Device device)
        {
            using (SqlConnection connect = ConnectionDB.BuilderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "UPDATE THIET_BI " +
                            "SET Ten_thiet_bi = @name, So_luong = @quantity, " +
                            "Khu_cach_ly = @kcl, Ngay_tiep_nhan = @date" +
                            " WHERE ID = @ID;";
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = device.ID;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = device.Name;
                        cmd.Parameters.AddWithValue("@quantity", DbType.String).Value = device.Quantity;
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = device.Kcl;
                        cmd.Parameters.AddWithValue("@date", DbType.String).Value = device.Date;
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
    }
}
