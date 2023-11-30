using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class Address
    {
        private string street;
        private string homeNumber;

        public Address(string street, string homeNumber)
        {
            this.street = street;
            this.homeNumber = homeNumber;
        }

        public string getAdres()
        {
            return "\nAdres: ul." + this.street + " " + this.homeNumber;
        }

        public void setNewAdress(string street, string homeNumber)
        {
            this.street = street;
            this.homeNumber = homeNumber;
        }

    }
}
