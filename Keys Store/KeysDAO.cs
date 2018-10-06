using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace Keys_Store
{
    class DBConnection
    {
        public static string Password { get; set; } = "";

        public static bool IsEncrypted
        {
            get { return Password != ""; }
        }

        public static void SetPassword(string pass)
        {
            SQLiteConnection cnn = DBConnection.GetConnection();
            cnn.ChangePassword(pass);
            cnn.Close();
            Password = pass;
        }

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection cnn = new SQLiteConnection("Data Source=Keys.db;Version=3;");
            cnn.SetPassword(Password);
            cnn.Open();
            return cnn;
        }
    }
    class KeysDAO
    {
        public static void Create()
        {
            SQLiteConnection.CreateFile("Keys.db");
            SQLiteConnection cnn = DBConnection.GetConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = @"BEGIN TRANSACTION;CREATE TABLE'packages'(`SubID`INTEGER NOT NULL UNIQUE,`AppID`INTEGER,`Name`TEXT,`HasCards`INTEGER,PRIMARY KEY(`SubID`));CREATE TABLE'keys'(`Key`TEXT NOT NULL,`SubID`INTEGER,`Date`TEXT,`Details`TEXT,PRIMARY KEY(`Key`),FOREIGN KEY(`SubID`)REFERENCES`packages`(`SubID`));COMMIT;";
            command.ExecuteNonQuery();
            cnn.Close();
        }
        public static List<Key> ReadAll()
        {
            List<Key> keys = new List<Key>();
            SQLiteConnection cnn = DBConnection.GetConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM keys";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
            }

            cnn.Close();

            return keys;
        }
        public static List<Key> Find(int subID)
        {
            List<Key> keys = new List<Key>();
            SQLiteConnection cnn = DBConnection.GetConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM keys WHERE SubID = '" + subID + "' ORDER BY 'Date' DESC";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                keys.Add(new Key(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3)));
            }

            cnn.Close();

            return keys;
        }
        public static void Add(List<Key> keys)
        {
            if (keys != null && keys.Count > 0)
            {
                SQLiteConnection cnn = DBConnection.GetConnection();
                SQLiteCommand command = new SQLiteCommand(cnn);

                StringBuilder SQL = new StringBuilder("INSERT INTO keys VALUES ");

                foreach (Key key in keys)
                {
                    SQL.AppendFormat("('{0}','{1}','{2}','{3}'),", key.KeyCode, key.SubId, key.Date.ToString("yyyy-MM-dd"), key.Details.Replace("'", "''"));
                }

                SQL.Length--;
                command.CommandText = SQL.ToString();

                command.ExecuteNonQuery();

                cnn.Close();
            }
        }

        public static void Remove(List<Key> keys)
        {
            if (keys != null && keys.Count > 0)
            {
                SQLiteConnection cnn = DBConnection.GetConnection();
                SQLiteCommand command = new SQLiteCommand(cnn);
                StringBuilder SQL = new StringBuilder("DELETE FROM keys WHERE ");

                foreach (Key key in keys)
                {
                    SQL.AppendFormat("Key = '{0}' OR ", key.KeyCode);
                }

                SQL.Length -= 4;
                command.CommandText = SQL.ToString();

                command.ExecuteNonQuery();

                cnn.Close();
            }
        }

        public static void Backup()
        {
            try
            {
                ReadAll();
                System.IO.File.Copy("Keys.db", "Keys.bak", true);
            }
            catch (Exception)
            {
            }
        }
    }
    class PackagesDAO
    {
        public static List<Package> ReadAll()
        {
            List<Package> packages = new List<Package>();
            SQLiteConnection cnn = DBConnection.GetConnection();

            SQLiteCommand command = new SQLiteCommand(cnn);
            command.CommandText = "SELECT * FROM packages ORDER BY Name ASC";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                packages.Add(new Package(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetBoolean(3)));
            }

            cnn.Close();

            return packages;
        }

        public static void Add(Package package)
        {
            SQLiteConnection cnn = DBConnection.GetConnection();
            SQLiteCommand command = new SQLiteCommand(cnn);

            command.CommandText = $"INSERT OR IGNORE INTO packages ('SubID','AppID','Name','HasCards') VALUES ('{package.SubId}','{package.AppId}','{package.AppName.Replace("'", "''")}','{Convert.ToInt16(package.HasCards)}')";

            command.ExecuteNonQuery();

            cnn.Close();
        }

    }
}
