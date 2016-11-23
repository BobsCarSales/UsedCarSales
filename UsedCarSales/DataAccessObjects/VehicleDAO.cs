using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    public static class VehicleDAO
    {
        //TODO: need to be checking for null values where corresponding columns are nOT NULL

        public static List<Vehicle> GetAllVehicles()
        {
            return DatabaseContext.dbContext.Vehicles.ToList();
        }

        public static List<Vehicle> SearchVehicles(Vehicle vehicle)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            if (vehicle.year != DateUtil.INVALID_YEAR)
            {
                vehicles = DatabaseContext.dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold)
                                                            && (v.year == vehicle.year))).ToList();
            }
            else
            {
                vehicles = DatabaseContext.dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold))).ToList();
            }

            return vehicles;
        }

        public static void RemoveVehicle(Vehicle vehicle)
        {
            DatabaseContext.dbContext.Vehicles.Remove(vehicle);
            DatabaseContext.dbContext.SaveChangesAsync();
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            DatabaseContext.dbContext.Vehicles.Add(vehicle);
            DatabaseContext.dbContext.SaveChangesAsync();
        }

        public static void EditVehicle(Vehicle vehicle)
        {
            Vehicle vehicleToUpdate = DatabaseContext.dbContext.Vehicles.First(v => v.id == vehicle.id);

            DatabaseContext.dbContext.Vehicles.Attach(vehicleToUpdate);
            vehicleToUpdate = vehicle;
            DatabaseContext.dbContext.SaveChangesAsync();
        }
    }
}
