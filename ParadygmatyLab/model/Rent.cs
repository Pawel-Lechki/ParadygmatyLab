using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class Rent
    {
        private Guid id;
        private DateTime startRent;
        private DateTime endRent;
        private int rentCost;
        private Vehicle vehicle;
        private Client client;

        public Rent(Vehicle vehicle, Client client, DateTime? endRent = null)
        {
            this.id = Guid.NewGuid();
            this.startRent = DateTime.Now;
            this.vehicle = vehicle;
            if(vehicle.IsAvailable()) {
                if (endRent.HasValue)
                {
                    this.endRent = endRent.Value;
                    this.rentCost = CalculateRentCost(vehicle);
                }
                else if (endRent < DateTime.Now)
                {
                    this.rentCost = 0;
                }
                else
                {
                    this.rentCost = 0;
                }

                this.client = client;
                vehicle.setRent(this);
            } 
            else
            {
                Console.WriteLine("Pojazd nie jest dostępny do wypożyczenia.");
            } 
        }

        public int CalculateRentCost(Vehicle vehicle)
        {
            TimeSpan duration = this.endRent - this.startRent;
            int days = duration.Days;
            return days * vehicle.getBaseRentPrice();
        }

        public int getRentTime()
        {
            TimeSpan duration = this.endRent - this.startRent;
            int days = duration.Days;
            if (days <= 0) return 0;
            return days;
        }

        public Vehicle getVehicle()
        {
            return this.vehicle;
        }

        public Client getClient()
        {
            return this.client;
        }

        public int getRentCost()
        {
            return this.rentCost;
        }

        public DateTime getRentEndDate()
        {
            return this.endRent;
        }

        public void returnVehicle(DateTime dateTime)
        {
            this.endRent = dateTime;
            int days = getRentTime();
            this.rentCost =  days * this.vehicle.getBaseRentPrice();
        }
            
        public string rentInfo()
        {
            TimeSpan days = endRent - startRent;

            return "\nId: " + this.id + " Wypożyczono od: " + this.startRent + " do " + this.endRent 
                + "\nCzas wypożyczenia: " + days 
                + "\nKoszt wypożycznie: " + this.rentCost
                + "\nWypożyczający: " + this.client.getFirstName() + " " + this.client.getLastName()
                + "\nWpożyczony pojazd: " + this.vehicle.vehicleInfo();
        }
    }
}
