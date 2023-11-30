using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class Vehicle
    {
        private readonly int baseReantPrice;
        private readonly string id;

        public Vehicle(int baseReantPrice, string id)
        {
            this.baseReantPrice = baseReantPrice;
            this.id = id;
        }

        public string vihicleInfo()
        {
            return id + " " + baseReantPrice.ToString();
        }

        public int getBaseRentPrice()
        {
            return baseReantPrice;
        }
    }

}
