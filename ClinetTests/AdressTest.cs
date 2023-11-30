using ParadygmatyLab.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinetTests
{
    [TestClass]
    public class AdressTest
    {
        [TestMethod]
        public void ClientAddressTest()
        {
            // Arrange
            string clientfirsntName1 = "Tomasz";
            string clinetlastName1 = "Bezpalcy";
            string clientPesonalId1 = "22222222222";

            string clientfirsntName2 = "Krzysztof";
            string clinetlastName2 = "Kajak";
            string clientPesonalId2 = "11111111116";

            string street = "Wpólna";
            string homeNumber = "8a";
            
            Address clinetAddress = new Address(street, homeNumber);

            Client client1 = new Client(clientfirsntName1, clinetlastName1, clientPesonalId1, clinetAddress);
            Client client2 = new Client(clientfirsntName2, clinetlastName2, clientPesonalId2, clinetAddress);

            // Act
            client1.getClientInfo();
            client2.getClientInfo();
            clinetAddress.setNewAdress("Hoża", "1b");
            client1.getClientInfo();
            client2.getClientInfo();

            // Assert
            Assert.AreEqual(client1.address, client2.address, "Adresy nie są takie same");
        }
    }
}
