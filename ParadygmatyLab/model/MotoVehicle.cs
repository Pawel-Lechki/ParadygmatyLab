using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class MotoVehicle : Vehicle
    {
        private int engineDisplacement;
        private double baseReantPriceModifer;
        
        public MotoVehicle(int engineDisplacement, double baseReantPriceModifer, int baseReantPrice, string id) : base(baseReantPrice, id)
        {
            this.engineDisplacement = engineDisplacement;
            this.baseReantPriceModifer = CalculatePriceModifer(engineDisplacement);
            
        }

        public double CalculatePriceModifer(int value)
        {
            double priceModifier;
            if (value < 1000) priceModifier = 1.0;
            else if( value >= 1000 && value <= 2000)
            {
                double percentIncrease = (double) (value - 1000) / (2000 - 1000);
                priceModifier = 1.0 + 0.5 * percentIncrease;
            } else
            {
                priceModifier = 1.5;
            }

            return priceModifier;
        }

        public double getBaseReantPriceModifer()
        {
            return this.baseReantPriceModifer;
        }
    }
}
