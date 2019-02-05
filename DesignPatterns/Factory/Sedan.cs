﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Sedan : Vehicle
    {
        public override string VehicleName()
        {
            return "Toyota Avensis Sedan Car";
        }

        public override int VehiclePrice()
        {
            return 2000;
        }
    }
}