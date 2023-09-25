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
        public int wasteDrain { get; set; }
        public const int priceForLitre = 20;
        public const int priceForLitreSewage = 10;
        public int waterPrice { get; init; }
        public int wastePrice { get; init; }
        public Billing(string name, string surname, long telephoneNumber, int consumedWater,int wasteDrain)
        {
            this.Name = name;
            this.Surname = surname;
            this.telephoneNumber = telephoneNumber;
            this.consumedWater = consumedWater;
            this.wasteDrain = wasteDrain;
            this.waterPrice = consumedWater * priceForLitre;
            this.wastePrice = wasteDrain * priceForLitreSewage;
        }
    }
}
