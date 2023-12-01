using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.repositories
{
    public class CurrentRentsRepository
    {
        private List<Rent> rents = new List<Rent>();
        
        public void creatRent(Rent rent)
        {
            this.rents.Add(rent);
        }

        public void removeRent(Rent rent)
        {
            this.rents.Remove(rent);
        }

        public string getClientForRentedVehicle(Vehicle vehicle)
        {
            Rent rentedVehicle = this.rents.FirstOrDefault(r => r.getVehicle() == vehicle);
            if (rentedVehicle != null)
            {
                return rentedVehicle.getClient().getClientInfo();
            }
            else
            {
                return "Pojazd nie jest obecnie wypożyczny";
            }

        }

        public void rentRaport()
        {
            foreach (var rent in rents)
            {
                Console.WriteLine(rent.rentInfo());
            }
        }
    }
}
