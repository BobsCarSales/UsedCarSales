using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class VehicleDatabaseHandler
    {
        private static VehicleDatabaseHandler instance { get; set; }

        public static VehicleDatabaseHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VehicleDatabaseHandler();
                }

                return instance;
            }
        }

        public void addVehicle(Vehicle vehicle)
        {
            //don't insert the ID here because it should automatically happen
            var query = "INSERT INTO Vehicle (used, sold, model) VALUES (@used, @sold, @model)";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //add vehicle values to command to be executed by the database
            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model.Id);
            command.ExecuteNonQuery();

            //TODO: print vehicle information for debugging
            Console.WriteLine("New vehicle added succesfully");
        }

        public void editVehicle(Vehicle vehicle)
        {
            var query = "UPDATE Vehicle SET used=@used, sold=@sold, model=@model WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //need the ID to edit the specific vehicle
            command.Parameters.AddWithValue("@id", vehicle.Id);

            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model.Id);
            command.ExecuteNonQuery();

            Console.WriteLine("Vehicle {0} edited successfully", vehicle.Id);
        }

        public void deleteVehicle(Vehicle vehicle)
        {
            var query = "DELETE FROM Vehicle WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            command.Parameters.AddWithValue("@id", vehicle.Id);

            Console.WriteLine("Vehicle {0} deleted successfully", vehicle.Id);
        }

        public List<Vehicle> searchVehicle(Vehicle vehicle)
        {
            var query = "SELECT * FROM Vehicle WHERE ";

            List<String> parameters = new List<String>();
            if (vehicle.Used != null) parameters.Add("used=@used");
            if (vehicle.Sold != null) parameters.Add("sold=@sold");
            if (vehicle.Model != null) parameters.Add("model=@model");

            for (int i = 0; i < parameters.Count; i++)
            {
                query += (parameters[i] + " ");
                if (i < parameters.Count - 1)
                {
                    query += "AND ";
                }
            }

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            if (vehicle.Used != null) command.Parameters.AddWithValue("@used", vehicle.Used);
            if (vehicle.Sold != null) command.Parameters.AddWithValue("@sold", vehicle.Sold);
            if (vehicle.Model != null) command.Parameters.AddWithValue("@model", vehicle.Model.Id);

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

                //get the id from the model in case we want to load the entire model later on
                Model model = new Model();
                model.Id = reader["model"].ToString();
                v.Model = model;

                vehicles.Add(v);
            }

            reader.Close();

            Console.WriteLine("Vehicles retrieved successfully");

            return vehicles;
        }
    }
}
