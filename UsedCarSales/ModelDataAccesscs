using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class ModelDatabaseHandler
    {
        private static ModelDatabaseHandler instance { get; set; }
        
        public static ModelDatabaseHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModelDatabaseHandler();
                }

                return instance;
            }
        }

        public List<Model> GetModelByMakeId(String makeId)
        {
            List<Model> models = new List<Model>();

            var query = "SELECT * FROM Model WHERE make=@makeId";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);
            command.Parameters.AddWithValue("@makeId", makeId);
            MySqlDataReader reader = command.ExecuteReader();

            Model m;
            while (reader.Read())
            {
                m = new UsedCarSales.Model();

                m.Id = reader["id"].ToString();
                m.Make = reader["make"].ToString();

                models.Add(m);
            }

            reader.Close();
            return models;
        }

        public Model GetModelById(String id)
        {
            var query = "SELECT * FROM Model WHERE id=@id";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Model m = new UsedCarSales.Model();
            m.Id = reader["id"].ToString();
            m.Make = reader["make"].ToString();

            reader.Close();
            return m;
        }
    }
}
