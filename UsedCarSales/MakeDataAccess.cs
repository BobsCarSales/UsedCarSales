using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class MakeDataAccess
    {
        private static MakeDataAccess instance { get; set; }
        
        public static MakeDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MakeDataAccess();
                }

                return instance;
            }
        }

        public List<Make> GetAllMakes()
        {
            List<Make> allMakes = new List<Make>();

            var query = "SELECT * FROM Make";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);
            MySqlDataReader reader = command.ExecuteReader();

            Make m;
            while (reader.Read())
            {
                m = new Make();

                m.Id = reader["id"].ToString();

                allMakes.Add(m);
            }

            reader.Close();
            return allMakes;
        }
    }
}
