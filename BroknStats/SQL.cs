using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace BroknStats
{
    XD

    public class SQLiteDatabaseHandler
    {
        private readonly string connectionString;

        public SQLiteDatabaseHandler(string databasePath)
        {
            connectionString = $"Data Source={databasePath};Version=3;";
        }

        public void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Tutaj możesz umieścić kod inicjalizujący bazę danych, tworzenie tabel itp.
                string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT);";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertData(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertDataQuery = "INSERT INTO MyTable (Name) VALUES (@Name);";

                using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectDataQuery = "SELECT * FROM MyTable;";

                using (SQLiteCommand command = new SQLiteCommand(selectDataQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public void CloseConnection()
        {
            // Możesz użyć try-catch, aby obsłużyć ewentualne wyjątki
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas zamykania połączenia: {ex.Message}");
            }
        }
    }

}