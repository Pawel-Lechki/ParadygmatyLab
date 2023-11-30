using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinetTests
{
    [TestClass]
    public class RentTest
    {
        [TestMethod]
        public void RentVahicleTest()
        {
            // Arrange
            string clientFirstName = "Krzysztof";
            string clientLastName = "Kajak";
            string clientPersonalID = "22222222222";

            string street = "Wpólna";
            string homeNumber = "8a";

            Address clientAdress = new Address(street, homeNumber);

            Client client = new Client(clientFirstName, clientLastName, clientPersonalID, clientAdress);

            Vehicle vehicle = new Vehicle(10, "WWL001");
            DateTime today = DateTime.Now;

            // Act
            DateTime endRent = DateTime.Now.AddDays(-10);

            Rent rent1 = new Rent(vehicle, client, endRent);
            client.addRent(rent1);
            
            // Assert
            Assert.AreEqual(rent1.getRentTime(), 0, "Wartość nie jest równa 0" );
            Assert.AreNotEqual(rent1.getRentCost(), 0);

            rent1.returnVehicle(today);
            Assert.AreEqual(rent1.getRentTime(), 0, "Wartość nie jest równa 0");
            
            // spr czy klinet ma wypożyczenia
            Assert.IsTrue(client.rents.Count() > 0);

        }
    }
}
