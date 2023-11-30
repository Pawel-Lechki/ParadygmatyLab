using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void rentRaport()
        {
            foreach (var rent in rents)
            {
                Console.WriteLine(rent.rentInfo());
            }
        }
    }
}
