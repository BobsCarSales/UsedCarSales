using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    public static class VehicleDAO
    {
        public static EntityContext dbContext = new EntityContext();
   
        public static List<Vehicle> SearchVehicles(Vehicle vehicle)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            if (vehicle.year != -1)
            {
                vehicles = dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold)
                                                            && (v.year == vehicle.year))).ToList();
            }
            else
            {
                vehicles = dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold))).ToList();
            }

            return vehicles;
        }

        public static void RemoveVehicle(Vehicle vehicle)
        {
            dbContext.Vehicles.Remove(vehicle);
            dbContext.SaveChangesAsync();
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            dbContext.Vehicles.Add(vehicle);
            dbContext.SaveChangesAsync();
        }

        public static void EditVehicle(Vehicle vehicle)
        {
            Vehicle vehicleToUpdate = dbContext.Vehicles.First(v => v.id == vehicle.id);
            dbContext.Vehicles.Attach(vehicleToUpdate);
            vehicleToUpdate = vehicle;
            dbContext.SaveChangesAsync();
        }
    }
}
