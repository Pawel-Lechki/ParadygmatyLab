// Paweł Lechki nr albumu 45257
using ParadygmatyLab;
using ParadygmatyLab.model;
using ParadygmatyLab.repositories;
using System.Diagnostics;
/*Car c1 = new Car();
Car c2 = new Car("Lexus", "GS", 2007);*/

//Client client1 = new Client();
/*Client client1 = new Client("Jan", "Nowak", "22222222222");
Console.WriteLine(client1.getClinetInfo());*/

/*Client client2 = new Client("Jan", "Kowalski", "11111111116");
Console.WriteLine(client2.getClinetInfo());*/


/*client1.setFirstName("");
Console.WriteLine(client1.getClinetInfo());*/

// client2.firstName = "";
// Console.WriteLine(client2.getClinetInfo());

VehicleRepository vehicleRepository = new VehicleRepository();

List<Vehicle> vehicles = new List<Vehicle>
{
    new Bicycle(1, "B001"),
    new Bicycle(1, "B002"),
    new Mope(900, 50, "S001"),
    new Mope(1100, 60, "S002"),
    new Mope(1500, 80, "S003"),
    new Mope(1300, 70, "S004"),
    new Car(Segment.B, 1100, 80, "S004"),
    new Car(Segment.C, 1200, 90,  "C001"),
    new Car(Segment.D, 1300, 100, "C002"),
    new Car(Segment.E, 1500, 150, "C003"),
};

Console.WriteLine("Naciśnij dowolny klawisz...");
Console.ReadKey();
