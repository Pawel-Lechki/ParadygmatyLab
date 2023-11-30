using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab.model
{
    public class Client
    {
        private string firstName;
        private string lastName;
        //private string personalID;
        private readonly string personalID;

        public Address address;

        public List<Rent> rents;

        //public Client()
        private Client()
        {
            Console.WriteLine("Konstruktor bezparametrowy został wywołany");
            this.firstName = "Jan";
            this.lastName = "Nowak";
            this.personalID = "22222222222";
        }

        public Client(string firstName, string lastName, string personalID, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (IsValidPESEL(personalID))
            {
                this.personalID = personalID;
            }
            else
            {
                Console.WriteLine("Numer Pesel jest nie poprawny");
                return;
            }
            Console.WriteLine("Konstruktor parametory został wywolany");
            this.address = address;
            this.rents = new List<Rent>();

        }

        public string getClinetInfo()
        {
            return "Clinet " + this.firstName + " " + this.lastName + " " + this.personalID;
        }

        public void setFirstName(string firstName)
        {
            if (firstName == "") return;
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return this.firstName;
        }

        public void setLastName(string lastName)
        {
            if (lastName == "") return;
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return this.lastName;
        }

        public string getPersonalId()
        {
            return this.personalID;
        }

        static bool IsValidPESEL(string pesel)
        {
            // Sprawdzenie długości numeru PESEL
            if (pesel.Length != 11)
            {
                return false;
            }

            // Sprawdzenie, czy wszystkie znaki w numerze PESEL są cyframi
            foreach (char c in pesel)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            // Sprawdzenie sumy kontrolnej
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += (pesel[i] - '0') * weights[i];
            }

            int lastDigit = (pesel[10] - '0');

            int controlDigit = (10 - (sum % 10)) % 10;

            // Sprawdzenie, czy ostatnia cyfra numeru PESEL zgadza się z obliczoną cyfrą kontrolną
            return lastDigit == controlDigit;
        }

        public string getClientInfo()
        {
            string clinetInfo = "Klient: " + this.firstName + " " + this.lastName + " " + this.personalID + address.getAdres();
            foreach (Rent rent in rents)
            {
                clinetInfo += rent.rentInfo();
            }

            return clinetInfo;
        }

        public void addRent(Rent rent)
        {
            this.rents.Add(rent);
        }
    }
 }