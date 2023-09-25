using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class ContactPerson
    {
        /// <summary>
        ///  PVK need to know name person who recieve a bill
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// PVK need to know surname person who recieve a bill
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// PVK need to know telephone number when somewhere is show issue
        /// </summary>
        public long telephoneNumber { get; private set; }
        /// <summary>
        /// Received bill from PVK for water and waste
        /// </summary>
        private Billing billing { get; set; }
        public ContactPerson(string name, string surname, long telephoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.telephoneNumber = telephoneNumber;
        }
        /// <summary>
        /// Contact person recieve a bill for water and waste
        /// </summary>
        /// <param name="billing"></param>
        /// <returns></returns>
        public string RecieveBill(Billing billing)
        {
            this.billing = billing;
            return string.Format("Bill:\nName: {0} {1}\nConsumed water: {2}l\nPrice for litre {3} Kč\nSewage drain: {4}l\nPrice for litre sewage: {5} Kč\nFinal price: {6} Kč\n", billing.Name,billing.Surname,billing.consumedWater,20,billing.wasteDrain,10, billing.waterPrice + billing.wastePrice);
        }
    }
}
