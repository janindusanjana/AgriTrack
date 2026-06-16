using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace AgriTrack
{
    public static class DatabaseHelper
    {

        // This looks for the database file in the same folder where the app is running
        private static string dbPath = Path.Combine(Application.StartupPath, "AgriTrackDB.db");

        // The connection string tells C# how to open the file
        public static string ConnectionString = $"Data Source={dbPath};Version=3;";

        // A quick test method to make sure it works!
        public static void TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    MessageBox.Show("Success! AgriTrack is connected to the database.", "Database Test");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error");
            }
        }
    }
}