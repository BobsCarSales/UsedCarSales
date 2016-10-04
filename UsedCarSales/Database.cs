﻿using System;
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
            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model);
            command.ExecuteNonQuery();

            //TODO: print vehicle information for debugging
            Console.WriteLine("New vehicle added succesfully");
        }

        public void editVehicle(Vehicle vehicle)
        {
            var query = "UPDATE Vehicle SET used=@used, sold=@sold, model=@model WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, connection);

            //need the ID to edit the specific vehicle
            command.Parameters.AddWithValue("@id", vehicle.Id);

            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model);
            command.ExecuteNonQuery();

            Console.WriteLine("Vehicle {0} edited successfully", vehicle.Id);
        }

        public void deleteVehicle(Vehicle vehicle)
        {
            var query = "DELETE FROM Vehicle WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", vehicle.Id);

            Console.WriteLine("Vehicle {0} deleted successfully", vehicle.Id);
        }

        public List<Vehicle> searchVehicle(Vehicle vehicle)
        {
            var query = "SELECT * FROM Vehicle WHERE ";

            //TODO: write a function to make this simpler. just trying to get it working before tuesday
            int count = 0;
            if (vehicle.Used != null)
            {
                //add used to the query
                query += "used=@used";
                count++;
            }
            if (vehicle.Sold != null)
            {
                //if we already have a WHERE clause, add an AND clause
                if (count > 0)
                {
                    query += " AND ";
                }

                query += "sold=@sold";
                count++;
            }
            if (vehicle.Model != null)
            {
                //if we already have a WHERE clause, add an AND clause
                if (count > 0)
                {
                    query += " AND ";
                }

                query += "model=@model";
                //count does not need to be incremented here unless we add another variable to search by
            }

            MySqlCommand command = new MySqlCommand(query, connection);

            if (vehicle.Used != null)
            {
                command.Parameters.AddWithValue("@used", vehicle.Used);
            }
            if (vehicle.Sold != null)
            {
                command.Parameters.AddWithValue("@sold", vehicle.Sold);
            }
            if (vehicle.Model != null)
            {
                command.Parameters.AddWithValue("@model", vehicle.Model);
            }

            MySqlDataReader reader = command.ExecuteReader();

            //TODO: need a function for this, will probably be reused
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle v;
            while (reader.Read())
            {
                v = new Vehicle();

                v.Id = Int32.Parse(reader["id"].ToString());
                v.Used = Boolean.Parse(reader["used"].ToString());
                v.Sold = Boolean.Parse(reader["sold"].ToString());
                v.Model = Int32.Parse(reader["model"].ToString());

                vehicles.Add(v);
            }

            reader.Close();

            Console.WriteLine("Vehicles retrieved successfully");

            return vehicles;
        }

        public List<Make> GetAllMakes()
        {
            List<Make> allMakes = new List<Make>();

            var query = "SELECT * FROM Make";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            Make m;
            while (reader.Read())
            {
                m = new Make();

                m.Id = Int32.Parse(reader["id"].ToString());
                m.Name = reader["name"].ToString();

                allMakes.Add(m);
            }

            reader.Close();
            return allMakes;
        }

        public List<Model> GetModelByMakeId(int makeId)
        {
            List<Model> models = new List<Model>();

            var query = "SELECT * FROM Model WHERE make=@makeId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@makeId", makeId);
            MySqlDataReader reader = command.ExecuteReader();

            Model m;
            while (reader.Read())
            {
                m = new UsedCarSales.Model();

                m.Id = Int32.Parse(reader["id"].ToString());
                m.Name = reader["name"].ToString();
                m.MakeId = Int32.Parse(reader["make"].ToString());

                models.Add(m);
            }

            reader.Close();
            return models;
        }
    }
}
