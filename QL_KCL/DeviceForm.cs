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
    public partial class DeviceForm : Form
    {
        public DeviceForm()
        {
            InitializeComponent();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            try
            {
                gridDevice.DataSource = LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable LoadData()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                string query = "SELECT t.ID, t.Ten_thiet_bi, t.So_luong, t.Nhan_vien_tiep_nhan, " +
                                "FORMAT (t.Ngay_tiep_nhan, 'dd/MM/yyyy ') as Ngay_tiep_nhan, k.Ten_KCL " +
                                "FROM THIET_BI AS t " +
                                "INNER JOIN KHU_CACH_LY as k " +
                                "ON t.Khu_cach_ly = k.ID";
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

        private void ClearField()
        {
            boxID.Clear();
            boxName.Clear();
            boxStaff.Clear();
        }

        private Device getDevice()
        {
            Device device = null;
            string ID = boxID.Text;
            string name = boxName.Text;
            string staff =  boxStaff.Text;
            decimal quantity = boxQuantity.Value;
            string date = datePicker.Value.ToShortDateString();
            string kcl = kclSelected.SelectedKCL.ID;
            if (Control.isEmptyField(ID) || Control.isEmptyField(name) || Control.isEmptyField(staff))
            {
                return null;
            } else { device = new Device(ID, name, quantity, staff, kcl, date); }
            return device;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Device device = getDevice();
            if (device != null)
            {
                if (AddDevice(device))
                {

                }
            } else { MessageBox.Show("Vui lòng nhập đủ thông tin!"); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private bool AddDevice(Device device)
        {
            using (SqlConnection connect = ConnectionDB.builderDB())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connect.Open();
                        cmd.Connection = connect;
                        cmd.CommandText = "INSERT THIET_BI VALUES(@ID, @name, @quantity, @staff, @kcl, @date);";
                        cmd.Parameters.AddWithValue("@ID", DbType.String).Value = device.ID;
                        cmd.Parameters.AddWithValue("@name", DbType.String).Value = device.name;
                        cmd.Parameters.AddWithValue("@quantity", DbType.String).Value = device.quantity;
                        cmd.Parameters.AddWithValue("@staff", DbType.String).Value = device.staff;
                        cmd.Parameters.AddWithValue("@kcl", DbType.String).Value = device.kcl;
                        cmd.Parameters.AddWithValue("@date", DbType.String).Value = device.date;
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
    }
}
