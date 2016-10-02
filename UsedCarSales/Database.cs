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
    class Database
    {
        private static Database instance { get; set; }
        private MySqlConnection connection { get; set; }

        //create a new database instance
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }

                return instance;
            }
        }

        private Database()
        {
            openConnection();
        }

        //destructor for closing the database when the program is closed. this shouldn't need to be called manually anywhere
        ~Database()
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

        public void addVehicle(Vehicle vehicle)
        {
            //don't insert the ID here because it should automatically happen
            var query = "INSERT INTO Vehicle (used, sold, model) VALUES (@used, @sold, @model)";

            MySqlCommand command = new MySqlCommand(query, connection);

            //add vehicle values to command to be executed by the database
            command.Parameters.AddWithValue("@used", vehicle.used);
            command.Parameters.AddWithValue("@sold", vehicle.sold);
            command.Parameters.AddWithValue("@model", vehicle.model);
            command.ExecuteNonQuery();
        }

        public void test()
        {
            var query = "SELECT * FROM Vehicle";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            Vehicle vehicle;
            List<Vehicle> vehicles = new List<Vehicle>();
            while (reader.Read())
            {
                vehicle = new Vehicle();

                vehicle.id = int.Parse(reader["id"].ToString());
                vehicle.used = bool.Parse(reader["used"].ToString());
                vehicle.sold = bool.Parse(reader["sold"].ToString());
                vehicle.model = int.Parse(reader["model"].ToString());

                vehicles.Add(vehicle);
            }

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine("Id: {0}, Used: {1}, Sold: {2}, Model: {3}", v.id, v.used, v.sold, v.model);
            }

            reader.Close();

            Vehicle newVehicle = new Vehicle();
            newVehicle.used = false;
            newVehicle.sold = false;
            newVehicle.model = 2;

            addVehicle(newVehicle);
        }

    }
}
