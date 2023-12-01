using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public enum Segment
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
    }

    public class Car : MotoVehicle
    {
        private double actualReantalPrice;

        public Car(Segment carSegment, int engineDisplacement, int baseReantPrice, string id) : base(engineDisplacement, baseReantPrice, id)
        {
            this.actualReantalPrice = baseReantPrice * this.getBaseReantPriceModifer() * (1.0 + (double)carSegment * 1.0);
        }
    }
}
