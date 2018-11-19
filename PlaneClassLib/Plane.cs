using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneClassLib
{
    public class Plane
    {
        public double StartFuel { get; set; }
        public double FuelCostsOnKm { get; set; }

        public double ExistFuel(double distance)
        {
            return StartFuel - (distance * FuelCostsOnKm);
        }

        public bool AutopilotActivate(bool turbulance, bool shortDistanceToAirport)
        {
            return (!turbulance && !shortDistanceToAirport) ? true : false;
        }

    }
}
