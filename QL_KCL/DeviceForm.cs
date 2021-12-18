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

        private readonly string queryLoadData = "SELECT t.ID AS 'Mã thiết bị', t.Ten_thiet_bi AS 'Tên thiết bị', " +
            "t.So_luong AS 'Số lượng', t.Nhan_vien_tiep_nhan AS 'Nhân viên tiếp nhận', " +
            "FORMAT (t.Ngay_tiep_nhan, 'dd/MM/yyyy ') AS 'Ngày tiếp nhận', " +
            "k.Ten_KCL AS 'Khu cách ly' FROM THIET_BI AS t " +
            "INNER JOIN KHU_CACH_LY as k ON t.Khu_cach_ly = k.ID";

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            gridDevice.DataSource = ConnectionDB.LoadData(queryLoadData);
        }

        private void ClearField()
        {
            boxID.Clear();
            boxName.Clear();
            boxQuantity.Value = 1;
            datePicker.ResetText();
            kclSelected.ResetIndex();
        }

        private Device GetDevice()
        {
            Device device = null;
            string ID = boxID.Text;
            string name = boxName.Text;
            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(name))
            {
                string staff = boxStaff.Text;
                decimal quantity = boxQuantity.Value;
                string date = datePicker.Value.ToShortDateString();
                string kcl = kclSelected.SelectedKCL.ID;
                device = new Device(ID, name, quantity, staff, kcl, date);
            }
            else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }
            return device;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Device device = GetDevice();
            if (device != null)
            {
                if (!ConnectionDB.CheckExistField("THIET_BI", "ID", device.ID))
                {
                    Thread thread = new Thread(ClearField);
                    thread.Start();
                    string queryInsert = "INSERT THIET_BI VALUES(@ID, @name, @quantity, @staff, @kcl, @date);";
                    InsertOrUpdate(device, queryInsert);                  
                    DeviceForm_Load(sender, e);
                }
                else { MessageBox.Show("Thiết bị đã tồn tại!"); }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Device device = GetDevice();
            if (device != null)
            {
                string queryUpdate = "UPDATE THIET_BI " +
                            "SET Ten_thiet_bi = @name, So_luong = @quantity, " +
                            "Khu_cach_ly = @kcl, Ngay_tiep_nhan = @date" +
                            " WHERE ID = @ID;";
                if (InsertOrUpdate(device, queryUpdate, true))
                {
                    Thread thread = new Thread(ClearField);
                    thread.Start();                                        
                    DeviceForm_Load(sender, e);
                }
                else { MessageBox.Show("Thiết bị không tồn tại!"); }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ConnectionDB.DeleteField("THIET_BI", "ID", boxID.Text))
            {
                Thread thread = new Thread(ClearField);
                thread.Start();                                
                DeviceForm_Load(sender, e);
            }
            else MessageBox.Show("Mã thiết bị không tồn tại!");
        }

        private bool InsertOrUpdate(Device device, string query, bool isUpdate = false)
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
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = device.ID;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = device.Name;
                        cmd.Parameters.AddWithValue("@quantity", DbType.String).Value = device.Quantity;
                        if (!isUpdate)
                        {
                            cmd.Parameters.AddWithValue("@staff", DbType.String).Value = device.Staff;
                        }
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = device.Kcl;
                        cmd.Parameters.AddWithValue("@date", DbType.String).Value = device.Date;
                        var i = cmd.ExecuteNonQuery();
                        connect.Close();
                        if (i != 0) { return true; }                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return false;
                }
            }
        }
    }
}
