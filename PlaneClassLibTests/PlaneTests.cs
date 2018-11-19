using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneClassLib.Tests
{
    [TestClass()]
    public class PlaneTests
    {
        [TestMethod()]
        public void ExistFuel_20_800returned()
        {
            // arrange
            double distance = 20.0;
            double expected = 800.0;


            //act
            Plane plane = new Plane { StartFuel = 1000, FuelCostsOnKm = 10 };
            double actual = plane.ExistFuel(distance);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AutopilotActivate_0and0_trueReturned()
        {
            // arrange
            bool turbulance = false;
            bool shortDistanceToAirport = false;
            bool expected = true;


            //act
            Plane plane = new Plane();
            bool actual = plane.AutopilotActivate(turbulance, shortDistanceToAirport);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AutopilotActivate_1and0_falseReturned()
        {
            // arrange
            bool turbulance = true;
            bool shortDistanceToAirport = false;
            bool expected = false;


            //act
            Plane plane = new Plane();
            bool actual = plane.AutopilotActivate(turbulance, shortDistanceToAirport);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AutopilotActivate_0and1_falseReturned()
        {
            // arrange
            bool turbulance = false;
            bool shortDistanceToAirport = true;
            bool expected = false;


            //act
            Plane plane = new Plane();
            bool actual = plane.AutopilotActivate(turbulance, shortDistanceToAirport);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AutopilotActivate_1and1_falseReturned()
        {
            // arrange
            bool turbulance = true;
            bool shortDistanceToAirport = true;
            bool expected = false;


            //act
            Plane plane = new Plane();
            bool actual = plane.AutopilotActivate(turbulance, shortDistanceToAirport);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}