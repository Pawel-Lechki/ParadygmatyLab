using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadygmatyLab
{
    public class Car
    {
        private string marka;
        private string model;
        private int rokProdukcji;

        public Car() // konstruktor bezparametrowy
        { 
            
        }

        public Car(string marka, string model, int rokProdukcji) // konstruktor argumentowy
        { 
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
        }
        public void setMarka(string marka)
        {
            this.marka = marka;
        }

        public string getMarka()
        {
            return this.marka;
        }
    }
}
