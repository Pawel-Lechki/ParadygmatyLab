using ParadygmatyLab.model;
using System.IO;

namespace ClinetTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void clientTest()
        {
            // Arrange
            string clientFirstName = "Tomasz";
            string clientLastname = "Kajak";
            string clientPersonalID = "11111111116";
            string street = "Wpólna";
            string homeNumber = "8a";
            Address clinetAddress = new Address(street, homeNumber);
            Client client1 = new Client(clientFirstName, clientLastname, clientPersonalID, clinetAddress);

            // Act
            client1.setFirstName("");
            client1.setLastName("");

            // Assert
            string actualFirstName = client1.getFirstName();
            string actualLastname = client1.getLastName();
            string actualPersonalId = client1.getPersonalId();
            Assert.AreEqual(clientFirstName, actualFirstName, "Imie nie jest poprawne");
            Assert.AreEqual(clientLastname, actualLastname, "Nazwisko nie jest poprawne");
            Assert.AreEqual(actualPersonalId, clientPersonalID, "Numer Pesel nie jest proprawny");
        }
    }
}