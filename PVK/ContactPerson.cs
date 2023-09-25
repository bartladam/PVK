using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class ContactPerson
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public long telephoneNumber { get; private set; }
        private Billing billing { get; set; }
        public ContactPerson(string name, string surname, long telephoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.telephoneNumber = telephoneNumber;
        }
        public string RecieveBill(Billing billing)
        {
            this.billing = billing;
            return string.Format("{0}",billing.price);
        }
    }
}
