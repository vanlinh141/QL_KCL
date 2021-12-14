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

        public static void DeleteByID(string tableName, string ID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    _connect.Open();
                    cmd.Connection = _connect;
                    cmd.CommandText = "DELETE " + tableName + " WHERE ID = @ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    _connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
