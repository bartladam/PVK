using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class ApartmentBuilding
    {
        /// <summary>
        /// Adress is important for invoice
        /// </summary>
        public string Adress { get; init; }
        /// <summary>
        /// Apartment bulding has a lot of flats
        /// </summary>
        public List<Flat> flats { get; private set; }
        public ApartmentBuilding(string adress, params Flat[] flats)
        {
            this.flats = new List<Flat>(flats);
            this.Adress = adress;
        }
    }
}
