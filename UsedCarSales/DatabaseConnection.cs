using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Linq;
using System.Collections;

namespace UsedCarSales
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance { get; set; }
        public MySqlConnection connection { get; set; }

        //create a new database instance
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }

                return instance;
            }
        }

        private DatabaseConnection()
        {
            openConnection();
        }

        //destructor for closing the database when the program is closed. this shouldn't need to be called manually anywhere
        ~DatabaseConnection()
        {
            closeConnection();
        }

        //open the connection to the database.
        public void openConnection()
        {
            String connectionString = "server=brettnapier.com;user=csc440Group;database=csc440GroupProject;port=3306;password=csc440GroupPass;";
            connection = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //close the connection the database. will be called when the program is closed
        public void closeConnection()
        {
            connection.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}
