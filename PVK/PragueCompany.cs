using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class PragueCompany
    {
        /// <summary>
        /// Customer need to know with which company has contract
        /// </summary>
        public string nameCompany { get; set; }
        /// <summary>
        /// PVK have to know where he distributs his water
        /// </summary>
        private List<object> realEstate { get; set; }
        public PragueCompany(string nameCompany)
        {
            this.nameCompany = nameCompany;
            realEstate = new List<object>();
        }
        /// <summary>
        /// PVK is sending bill for water
        /// </summary>
        /// <returns></returns>
        public string Invoices()
        {
            string bills = "";
            foreach (object item in realEstate)
            {
                if(item is House)
                {
                    House house = (House)item;
                    bills += house.contactPerson.RecieveBill(new Billing(house.contactPerson.Name, house.contactPerson.Surname, house.contactPerson.telephoneNumber, house.waterMater.consumedValue, house.sewageDrain)) + "\n";
                }
                if(item is ApartmentBuilding)
                {
                    ApartmentBuilding apartment = (ApartmentBuilding)item;
                    foreach (Flat flats in apartment.flats)
                    {
                        bills += flats.contactPerson.RecieveBill(new Billing(flats.contactPerson.Name, flats.contactPerson.Surname, flats.contactPerson.telephoneNumber, flats.waterMater.consumedValue,flats.sewageDrain)) + "\n";
                    }
                }
            }
            return bills;
        }
        /// <summary>
        /// Add new apartment / house to database where PVK have to distribute water
        /// </summary>
        /// <param name="realEstate"></param>
        public void AddToList(object realEstate)
        {
            this.realEstate.Add(realEstate);
        }

    }
}
