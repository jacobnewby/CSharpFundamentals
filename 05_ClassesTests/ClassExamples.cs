using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "SnickerDoodle";
            cookie.Ingredient = "sugar";
            cookie.BatchSize = 122;
            cookie.Direction = "Good Luck omegaLul";
            cookie.Shape = "Diamond";
            cookie.Size = "Small";
            cookie.IsGood = true;

            Cookie cookie2 = new Cookie();

            cookie2.Name = "Triple Chocolate Fudge";
            cookie2.Ingredient = "Chocolate, dumby";
            cookie2.BatchSize = 1;
            cookie2.Direction = "It's a secret. I will never tell you.";
            cookie2.Shape = "Moby Dick";
            cookie2.Size = "ninety feet";
            cookie2.IsGood = true;

            cookie2.SetPrice();

            Cookie cookieThree = new Cookie("Peanut Butter", "Don't be stupid.", "Too big for you.", "Do it yourself.", "Peanut", 128);


        }
        [TestMethod]
        public void Veh()
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Color = "Tan";
            vehicle.CoolnessFactor = 6;
            vehicle.CarStart();
            vehicle.Make = "Buick";
            vehicle.Mileage = 200000d;
            vehicle.Model = "Park Avenue";
            vehicle.VIN = "idk";
            vehicle.Year = 2000;
            vehicle.TypeOfVehicle = "sedan";

            Vehicle vehicle2 = new Vehicle("Buick", "Park Avenue", 200000d, "Tan", "idk", 2000, 6, "sedan");
            vehicle2.CarStart();
            Assert.IsTrue(vehicle2.IsRunning);

            vehicle2.TurnOff();
            Assert.IsFalse(vehicle2.IsRunning);

        }
    }
}