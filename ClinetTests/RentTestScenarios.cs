using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinetTests
{
    [TestClass]
    public class RentTestScenarios
    {
        [TestMethod]
        public void TC1()
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
            Rent rent1 = new Rent(vehicle, client);
            client.addRent(rent1);

            // Assert
            Assert.AreEqual(rent1.getRentTime(), 0, "Czas wypożyczenia dla nie oddanego  pojazdu nie jest równa 0");        
        }

        [TestMethod]
        public void TC2()
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
            Rent rent1 = new Rent(vehicle, client);
            DateTime tomorrow = DateTime.Now.AddDays(1);

            // Act           
            rent1.returnVehicle(tomorrow);
            client.addRent(rent1);

            // Assert
            Assert.AreNotEqual(rent1.getRentTime(), 0, "Czas wypożyczenia pojazdu oddanego jest zerowy");          
        }
        [TestMethod]
        public void TC3()
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
            Rent rent1 = new Rent(vehicle, client);
            DateTime today = DateTime.Now;
            DateTime yesterday = today.AddDays(-1);

            // Act


            
            rent1.returnVehicle(today);
            client.addRent(rent1);

            // Assert
            Assert.AreNotEqual(rent1.getRentEndDate(), yesterday, "Czas oddania pojazdu jest wcześniejsz od czasu wypożyczenia");
        }

        [TestMethod]
        public void TC4()
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
            Rent rent1 = new Rent(vehicle, client);
            DateTime tomorrow = DateTime.Now.AddDays(1);
            // Act            
            rent1.returnVehicle(tomorrow);
            client.addRent(rent1);

            // Assert
            Assert.AreEqual(rent1.getRentCost(), 10, "Wartość wypożyczenia nie jest naliczna prawidłowo");
        }
    }
}
