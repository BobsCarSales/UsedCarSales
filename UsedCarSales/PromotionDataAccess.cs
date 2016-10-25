using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class PromotionDataAccess
    {
        private static PromotionDataAccess instance { get; set; }

        public static PromotionDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PromotionDataAccess();
                }

                return instance;
            }
        }

        public List<Promotion> GetAllPromotions()
        {
            List<Promotion> allPromotions = new List<Promotion>();

            var query = "SELECT * FROM Promotion";
            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);
            MySqlDataReader reader = command.ExecuteReader();

            Promotion p;
            while (reader.Read())
            {
                p = new Promotion();

                p.Id = Int32.Parse(reader["id"].ToString());

                allPromotions.Add(p);
            }

            reader.Close();
            return allPromotions;
        }

        public void addPromotion(Promotion promotion)
        {
            //don't insert the ID here because it should automatically happen
            var query = "INSERT INTO Promotion (discountAmount, make) VALUES (@discountAmount, @make)";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //add vehicle values to command to be executed by the database
            command.Parameters.AddWithValue("@discountAmount", promotion.DiscountAmount);
            command.Parameters.AddWithValue("@sold", promotion.Make);
            command.ExecuteNonQuery();

            //TODO: print vehicle information for debugging
            Console.WriteLine("New promotion added succesfully");
        }

        public void editPromotion(Promotion promotion)
        {
            var query = "UPDATE Promotion SET discountAmount=@discountAmount, make=@make WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            //need the ID to edit the specific vehicle
            command.Parameters.AddWithValue("@id", promotion.Id);

            command.Parameters.AddWithValue("@discountAmount", promotion.DiscountAmount);
            command.Parameters.AddWithValue("@make", promotion.Make);
            command.ExecuteNonQuery();

            Console.WriteLine("Promotion {0} edited successfully", promotion.Id);
        }

        public bool deletePromotion(Promotion promotion)
        {
            var query = "DELETE FROM Promotion WHERE id=@id";

            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

            try
            {
                command.Parameters.AddWithValue("@id", promotion.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting promotion");
                Console.WriteLine(e);
                return false;
            }

            Console.WriteLine("Promotion {0} deleted successfully", promotion.Id);

            return true;
        }
    }
}
