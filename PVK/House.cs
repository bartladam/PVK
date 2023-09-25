using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class House
    {
        public string Adress { get; set; }
        public ContactPerson contactPerson { get; private set; }
        public PragueCompany company { get; set; }
        public WaterMeter waterMater { get;  private set; }
        public House(ContactPerson contactPerson, PragueCompany company, WaterMeter waterMater)
        {
            this.contactPerson = contactPerson;
            this.company = company;
            this.waterMater = waterMater;
        }

        public void WaterCharges()
        {
            waterMater.WaterCharges();
        }
        public void SewageCharges()
        {

        }

    }
}
