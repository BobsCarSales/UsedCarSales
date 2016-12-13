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

        public static List<Vehicle> SearchVehicles(Vehicle vehicle, decimal? minPrice, decimal? maxPrice)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            if(minPrice == null || minPrice < 0 || minPrice >= Decimal.MaxValue)
            {
                minPrice = 0;
            }
            if(maxPrice == null || maxPrice < 0 || maxPrice >= Decimal.MaxValue)
            {
                maxPrice = Decimal.MaxValue;
            }

            if (vehicle.year != DateUtil.INVALID_YEAR)
            {
                vehicles = DatabaseContext.dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold)
                                                            && (v.year == vehicle.year)
                                                            && (v.price <= maxPrice)
                                                            && (v.price >= minPrice))).ToList();
            }
            else
            {
                vehicles = DatabaseContext.dbContext.Vehicles.Where(v => ((v.Model.id == vehicle.Model.id)
                                                            && (v.used == vehicle.used)
                                                            && (v.sold == vehicle.sold)
                                                            && (v.price <= maxPrice)
                                                            && (v.price >= minPrice))).ToList();
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
            DatabaseContext.dbContext.Entry(vehicle).State = System.Data.Entity.EntityState.Modified;
            DatabaseContext.dbContext.SaveChangesAsync();
        }
    }
}
