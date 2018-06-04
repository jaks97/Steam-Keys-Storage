using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Keys_Store
{
    class DBConnection
    {
        private static string connectionString = "Data Source=Keys.db;Version=3;";

        public static string Password
        {
            get
            {
                string[] str = connectionString.Replace(" ", string.Empty).Split(new string[] { "Password=" }, StringSplitOptions.None);
                return str.Length > 1 ? str.Last().Replace(";", string.Empty) : string.Empty;
            }
            set
            {
                connectionString = "Data Source=Keys.db;Version=3;Password=" + value + ";";
                if (value == string.Empty)
                    connectionString = "Data Source=Keys.db;Version=3;";
            }
        }

        public static bool IsEncrypted
        {
            get
            {
                return Password != string.Empty;
            }
        }


        public static void SetPassword(string pass)
        {
            SQLiteConnection cnn = DBConnection.getConnection();
            cnn.ChangePassword(pass);
            cnn.Close();
            Password = pass;
        }

        public static SQLiteConnection getConnection()
        {
            SQLiteConnection cnn = new SQLiteConnection(connectionString);
            cnn.Open();
            return cnn;
        }
    }
    class KeysDAO
    {
        public static void create()
        {
            SQLiteConnection.CreateFile("Keys.db");
            SQLiteConnection cnn = DBConnection.getConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = @"BEGIN TRANSACTION;CREATE TABLE'packages'(`SubID`INTEGER NOT NULL UNIQUE,`AppID`INTEGER,`Name`TEXT,`HasCards`INTEGER,`Details`TEXT,PRIMARY KEY(`SubID`));CREATE TABLE'keys'(`Key`TEXT NOT NULL,`SubID`INTEGER,`Date`TEXT,`Details`TEXT,PRIMARY KEY(`Key`),FOREIGN KEY(`SubID`)REFERENCES`packages`(`SubID`));COMMIT;";
            command.ExecuteNonQuery();
        }
        public static List<Key> readAll()
        {
            List<Key> keys = new List<Key>();
            SQLiteConnection cnn = DBConnection.getConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM keys";
            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                if (reader.IsDBNull(4))
                {
                    keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
                }
                else
                    keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
            }

            cnn.Close();

            return keys;
        }
        public static List<Key> find(int subID)
        {
            List<Key> keys = new List<Key>();
            SQLiteConnection cnn = DBConnection.getConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM keys where SubID = '"+subID+ "' ORDER BY 'Date' DESC";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(4))
                {
                    keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
                }
                else
                    keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
            }

            cnn.Close();

            return keys;
        }
        public static void add(List<Key> keys)
        {
            SQLiteConnection cnn = DBConnection.getConnection();
            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "INSERT INTO keys values ";
            foreach (Key key in keys)
            {
                command.CommandText += "('" + key.KeyCode + "', '" + key.SubId + "', '" + key.Date.ToString("yyyy-MM-dd") + "', '" + key.Details.Replace("'", "''") + "'),";
            }

            command.CommandText = command.CommandText.Remove(command.CommandText.Length - 1);
            
            command.ExecuteNonQuery();

            cnn.Close();
        }

        public static void remove(List<Key> keys)
        {
            SQLiteConnection cnn = DBConnection.getConnection();
            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "DELETE FROM keys WHERE key = 0";

            foreach (Key key in keys)
            {
                command.CommandText += " OR Key = '" + key.KeyCode + "'";
            }

            command.ExecuteNonQuery();
            
            cnn.Close();
        }

        public static void Backup()
        {
            try
            {
                readAll();
                System.IO.File.Copy("Keys.db", "Keys.bak", true);
            }
            catch (Exception)
            {
            }
        }
    }
    class PackagesDAO
    {
        public static List<Package> readAll()
        {
            List<Package> packages = new List<Package>();
            SQLiteConnection cnn = DBConnection.getConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM packages ORDER BY Name ASC";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                packages.Add(new Package(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetBoolean(3), reader.GetString(4)));
            }

            cnn.Close();

            return packages;
        }

        public static void add(Package package)
        {
            SQLiteConnection cnn = DBConnection.getConnection();
            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "INSERT OR IGNORE INTO packages values ";

            command.CommandText += "('" + package.SubId + "', '" + package.AppId + "', '"
                + package.AppName.Replace("'", "''") + "', '" + Convert.ToInt16(package.HasCards) + "', '" + package.Details.Replace("'", "''") + "')";
            

            command.ExecuteNonQuery();

            cnn.Close();
        }

    }
}
