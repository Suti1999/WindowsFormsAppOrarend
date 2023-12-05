using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppOrarend
{
    internal class Database
    {
      
        MySqlConnection connection;
        MySqlCommand command;

      
        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();

            try
            {
               
                kapcsolatNyitas();

                kapcsolatZarasa();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        
        public void kapcsolatZarasa()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /
        public void kapcsolatNyitas()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public int Bejelentkezes(string nev, string jelszo)
        {
            int userid = -1;
            kapcsolatNyitas();
            command.CommandText = "SELECT tanarok.nev, tanarok.jelszo FROM orarend WHERE tanarok.nev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(jelszo))
                {
                    userid = reader.GetInt32("tanarid");
                }
            }
            kapcsolatZarasa();
            return userid;
        }
    }
}
