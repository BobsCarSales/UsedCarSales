//using System;
//using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UsedCarSales
//{
//    class GenericDataAccess
//    {
//        public static bool DeleteRecord(int id, string tableName)
//        {
//            var query = "DELETE FROM " + tableName + " WHERE id=@id";

//            MySqlCommand command = new MySqlCommand(query, DatabaseConnection.Instance.connection);

//            try
//            {
//                command.Parameters.AddWithValue("@id", id);
//                command.ExecuteNonQuery();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Error deleting record from {}", tableName);
//                Console.WriteLine(e);
//                return false;
//            }

//            Console.WriteLine("Record from {0} with id {1} deleted successfully", tableName, id);

//            return true;
//        }
//    }
//}
