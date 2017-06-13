using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MuseumBD
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string databaseName = @"MuseumBD.db";
            SQLiteConnection.CreateFile(databaseName);
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Sourse = {0}", databaseName));
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Article (Id_article INTEGER PRIMARY KEY AUTO_INCREMENT, Title TEXT, Date_pub DATE, Text TEXT);", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Teacher (Id_teacher INTEGER PRIMARY KEY AUTO_INCREMENT, Name TEXT, Birthday DATE, Department TEXT);", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Article (Id_article INTEGER PRIMARY KEY AUTO_INCREMENT, Title TEXT, Date_pub DATE, Text TEXT);", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
