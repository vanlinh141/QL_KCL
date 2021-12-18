using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KCL
{
    public class ConnectionDB
    {

        public static SqlConnection BuilderDB()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "LINH",
                InitialCatalog = "KCL_DB",
                IntegratedSecurity = true
            };
            return new SqlConnection(builder.ToString());
        }

        private static readonly SqlConnection _connect = BuilderDB();

        public static DataTable LoadData(string queryLoadData)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryLoadData, _connect);
                adapter.Fill(dataTable);       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connect.Close();
            }
            return dataTable;
        }

        public static bool CheckExistField(string tableName, string fieldName, string value)
        {
            bool isExist = true;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = _connect;
                cmd.CommandText = "SELECT * FROM " + tableName + " WHERE " + fieldName + " = '" + value + "';";
                try
                {
                    _connect.Open();
                    var reader = cmd.ExecuteReader();
                    isExist = reader.HasRows;
                    _connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
            return isExist;
        }

        public static bool CheckNewEmail(string staffID, string email)
        {
            bool isExist = true;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = _connect;
                cmd.CommandText = "SELECT * FROM TAI_KHOAN WHERE Nhan_vien != @staffID AND Email = @email;";
                cmd.Parameters.AddWithValue("@staffID", staffID);
                cmd.Parameters.AddWithValue("@email", email);
                try
                {
                    _connect.Open();
                    var reader = cmd.ExecuteReader();
                    isExist = reader.HasRows;
                    _connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return !isExist;
        }

        public static bool DeleteField(string tableName, string fieldName, string value)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    _connect.Open();
                    cmd.Connection = _connect;
                    cmd.CommandText = "DELETE " + tableName + " WHERE "+ fieldName +" = '"+ value +"';";
                    var i = cmd.ExecuteNonQuery();
                    if (i != 0) { return true; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    _connect.Close();
                }
                return false;
            }
        }
    }
}
