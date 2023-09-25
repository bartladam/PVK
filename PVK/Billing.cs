using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class Billing
    {

        /// <summary>
        /// On which name is bill
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// On which surname is bill
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Telephone number for check thats bill is for me
        /// </summary>
        public long telephoneNumber { get; private set; }
        /// <summary>
        /// My consuption water
        /// </summary>
        public int consumedWater { get; init; }
        /// <summary>
        /// Amount of waste drain
        /// </summary>
        public int wasteDrain { get; set; }
        /// <summary>
        /// PVK set price water on litre
        /// </summary>
        public const int priceForLitre = 20;
        /// <summary>
        /// PVK set price for litre sewage
        /// </summary>
        public const int priceForLitreSewage = 10;
        /// <summary>
        /// Final price for water
        /// </summary>
        public int waterPrice { get; init; }
        /// <summary>
        /// Final price for sewage
        /// </summary>
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
