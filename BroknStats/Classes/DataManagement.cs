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



    }

    public class DataRowImporter
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }

        public List<DataRowImporter> GetTableRows()
        {
            List<DataRowImporter> dataRowList = new List<DataRowImporter>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = "select Id, ItemName, ItemQuantity from Session_Items order by ItemName";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    DataRowImporter dataRow = new DataRowImporter();
                    dataRow.Id = Convert.ToInt32(dr["Id"]);
                    dataRow.ItemName = dr["ItemName"].ToString();
                    dataRow.ItemQuantity = Convert.ToInt32(dr["ItemQuantity"]);
                    dataRowList.Add(dataRow);
                }
            }
            con.Close();
            return dataRowList;
        }
















    }

    
}
