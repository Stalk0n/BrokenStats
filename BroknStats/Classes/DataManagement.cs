using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace BroknStats.Classes
{
    public class DataManagement
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public void SaveItemData(string itemName, int itemQuantity)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SaveItem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ItemName", itemName));
                cmd.Parameters.Add(new SqlParameter("@ItemQuantity", itemQuantity));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Blad przy zapisywaniu danych do sesji");
            }
        }


        public int Id { get; set; }
        public string SensorTypeName { get; set; }
        public List<SensorType> GetSensorTypes()
        {
            List<SensorType> sensorTypeList = new List<SensorType>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = "select SensorTypeId, SensorType from SENSOR_TYPE order by SensorType";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    SensorType sensorType = new SensorType();
                    sensorType.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensorType.SensorTypeName = dr["SensorType"].ToString();
                    sensorTypeList.Add(sensorType);
                }
            }
            con.Close();
            return sensorTypeList;
        }


















    }
}
