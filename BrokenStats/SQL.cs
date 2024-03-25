using System.Data;
using System.Data.SQLite;

namespace BrokenStats
{
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
                string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Nick VARCHAR(255), Experience VARCHAR(255), Psycho_Experience VARCHAR(255), Gold VARCHAR(255), Dropped_items VARCHAR(255), Opponents VARCHAR(300));";

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

                string[] parts = name.Split('\t');

                string insertDataQuery = "INSERT INTO MyTable (Nick, Experience, Psycho_Experience, Gold, Dropped_items, Opponents) VALUES (@Nick, @Experience, @Psycho_Experience, @Gold, @Dropped_items, @Opponents);";

                using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                {

                    command.Parameters.AddWithValue("@Nick", parts[0]);
                    command.Parameters.AddWithValue("@Experience", parts[1]);
                    command.Parameters.AddWithValue("@Psycho_Experience", parts[2]);
                    command.Parameters.AddWithValue("@Gold", parts[3]);
                    command.Parameters.AddWithValue("@Dropped_items", parts[4]);
                    command.Parameters.AddWithValue("@Opponents", parts[5]);
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