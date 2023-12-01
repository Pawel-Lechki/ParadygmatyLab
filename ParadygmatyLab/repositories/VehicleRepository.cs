using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.repositories
{
    public class VehicleRepository
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void removeVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        public Vehicle getVehicle(int index)
        {
            if (index >=0 && vehicles.Count < index)
            {
                return vehicles[index];
            }
            else
            {
                Console.WriteLine("Nie znaleziono pojazdu o podanym indexie.");
                return null;
            }
        }

        public void InitVehicleList(List<Vehicle> vehicles)
        {
            vehicles.AddRange(vehicles);
        }

        public void vehicleRaport()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.vehicleInfo());
            }
        }
    }
}
