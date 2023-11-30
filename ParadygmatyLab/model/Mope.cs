﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class Mope : MotoVehicle
    {
        private double actualReantalPrice;
        public Mope(int engineDisplacement, double baseReantPriceModifer, int baseReantPrice, string id) : base(engineDisplacement, baseReantPriceModifer, baseReantPrice, id)
        {
            this.actualReantalPrice = baseReantPrice * baseReantPriceModifer;
        }
    }
}
