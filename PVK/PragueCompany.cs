using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class PragueCompany
    {
        public string nameCompany { get; set; }
        private List<object> realEstate { get; set; }
        public PragueCompany(string nameCompany)
        {
            this.nameCompany = nameCompany;
            realEstate = new List<object>();
        }
        public string BillingTime()
        {
            string bill = "";
            foreach (object item in realEstate)
            {
                if(item is House)
                {
                    House house = (House)item;
                    bill += house.contactPerson.RecieveBill(new Billing(house.contactPerson.Name, house.contactPerson.Surname, house.contactPerson.telephoneNumber, house.waterMater.consumedValue, house.waterMater.consumedValue * 20)) + "\n";
                }
                if(item is ApartmentBuilding)
                {
                    ApartmentBuilding apartment = (ApartmentBuilding)item;
                    foreach (Flat flats in apartment.flats)
                    {
                        bill += flats.contactPerson.RecieveBill(new Billing(flats.contactPerson.Name, flats.contactPerson.Surname, flats.contactPerson.telephoneNumber, flats.waterMater.consumedValue, flats.waterMater.consumedValue * 20)) + "\n";
                    }
                }
            }
            return bill;
        }
        public void AddToList(object realEstate)
        {
            this.realEstate.Add(realEstate);
        }

    }
}
