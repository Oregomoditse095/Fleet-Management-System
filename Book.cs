using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAPTECH_FLEET_MANAGEMENT_SYSTEM
{
    class Book
    {
        //for recording
        public string TripID { get; set; }
        public string vehicleReg { get; set; }
        public double km { get; set; }
        public double FuelTank { get; set; }
        //to calculate fuel usage but still under Recordings.cs
        public double LitresRefilled { get; set; }

        //calculating fuel usage
        public double FuelUsage()
        {
            double fuel = FuelTank / km * 10;
            double dif = km - 10;
            //estimate fuel usage
            double eFuel = fuel + dif;

            if (LitresRefilled > 0.0)
            {
                double addedFuel = eFuel + LitresRefilled;
                return addedFuel;
            }
            else

                return eFuel;

            //km is a property that gets the number of kms travelled on a single trip
            //fuel tank is a variable for the amount of fuel used on certain trip
        }

    }
}
