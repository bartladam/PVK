using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class House
    {
        /// <summary>
        /// Adress is important for invoice
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// PVK has contact on the responsible person, when is something wrong
        /// </summary>
        public ContactPerson contactPerson { get; private set; }
        /// <summary>
        /// Contract company for water and sewage
        /// </summary>
        public PragueCompany company { get; set; }
        /// <summary>
        /// Each house / flat have to water mater for consumption
        /// </summary>
        public WaterMeter waterMater { get;  private set; }
        /// <summary>
        /// Amount sewage drain  
        /// </summary>
        public int sewageDrain { get; private set; }
        public House(ContactPerson contactPerson, PragueCompany company, WaterMeter waterMater)
        {
            this.contactPerson = contactPerson;
            this.company = company;
            this.waterMater = waterMater;
        }
        /// <summary>
        /// When a member of the household is using water, water meter count it
        /// </summary>
        public void ConsumptionWater()
        {
            waterMater.ConsumptionWater();
        }
        /// <summary>
        /// When someone from member of the household is draining waste water
        /// </summary>
        public void SewageWater()
        {
            sewageDrain += 1;
        }

    }
}
