using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class VehicleDataAccess
    {
        private static VehicleDataAccess instance { get; set; }

        public static VehicleDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VehicleDataAccess();
                }

                return instance;
            }
        }

        //TODO: need exception handling
        public void addVehicle(Vehicle vehicle)
        {
            //don't insert the ID here because it should automatically happen
            var query = "INSERT INTO Vehicle (used, sold, model, year) VALUES (@used, @sold, @model, @year)";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //add vehicle values to command to be executed by the database
            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model.Id);
            command.Parameters.AddWithValue("@year", vehicle.Year);
            command.ExecuteNonQuery();

            //TODO: print vehicle information for debugging
            Console.WriteLine("New vehicle added succesfully");
        }

        //TODO: need exception handling
        public void editVehicle(Vehicle vehicle)
        {
            var query = "UPDATE Vehicle SET used=@used, sold=@sold, model=@model, year=@year WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //need the ID to edit the specific vehicle
            command.Parameters.AddWithValue("@id", vehicle.Id);

            command.Parameters.AddWithValue("@used", vehicle.Used);
            command.Parameters.AddWithValue("@sold", vehicle.Sold);
            command.Parameters.AddWithValue("@model", vehicle.Model.Id);
            command.Parameters.AddWithValue("@year", vehicle.Year);
            command.ExecuteNonQuery();

            Console.WriteLine("Vehicle {0} edited successfully", vehicle.Id);
        }

        public bool deleteVehicle(Vehicle vehicle)
        {
            var query = "DELETE FROM Vehicle WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            try
            {
                command.Parameters.AddWithValue("@id", vehicle.Id);
                command.ExecuteNonQuery();
            } catch (Exception e)
            {
                Console.WriteLine("Error deleting vehicle");
                Console.WriteLine(e);
                return false;
            }

            Console.WriteLine("Vehicle {0} deleted successfully", vehicle.Id);

            return true;
        }

        //TODO: need exception handling
        public List<Vehicle> searchVehicle(Vehicle vehicle)
        {
            var query = "SELECT * FROM Vehicle WHERE ";

            List<String> parameters = new List<String>();
            if (vehicle.Used != null) parameters.Add("used=@used");
            if (vehicle.Sold != null) parameters.Add("sold=@sold");
            if (vehicle.Model != null) parameters.Add("model=@model");
            if (vehicle.Year != null) parameters.Add("year=@year");

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
            if (vehicle.Year != null) command.Parameters.AddWithValue("@year", vehicle.Year);

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
                v.Year = Int32.Parse(reader["year"].ToString());

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
