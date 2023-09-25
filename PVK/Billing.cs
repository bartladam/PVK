using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class Billing
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public long telephoneNumber { get; private set; }
        public int consumedWater { get; init; }
        public const int priceForLitre = 20;
        public int price { get; init; }
        public Billing(string name, string surname, long telephoneNumber, int consumedWater, int price)
        {
            this.Name = name;
            this.Surname = surname;
            this.telephoneNumber = telephoneNumber;
            this.consumedWater = consumedWater;
            this.price = price;

        }
    }
}
