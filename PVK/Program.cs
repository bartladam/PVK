
using PVK;

PragueCompany PVK = new PragueCompany("PRAGUE WATER SUPPLY AND SEWERAGE COMPANY");
House house = new House(new ContactPerson("Petr", "Vybíhal", 735125654), PVK, new WaterMeter("158ABC")) {Adress = "K dolinám 12"};
ApartmentBuilding apartment = new ApartmentBuilding("Bachyně 17",
    new Flat(new ContactPerson("Tomáš", "Marný", 605417824), PVK, new WaterMeter("789FGH"), "1.1"),
    new Flat(new ContactPerson("Roman", "Hrozný", 74222354), PVK, new WaterMeter("M85FGA"), "1.2"),
    new Flat(new ContactPerson("Anděla", "Nebeská", 547364892), PVK, new WaterMeter("JA12MA"), "1.3"));

PVK.AddToList(house);
PVK.AddToList(apartment);

for (int i = 0; i < 5; i++)
{
    house.WaterCharges();
}
Random randomWaterCharges = new Random();
foreach (Flat item in apartment.flats)
{
    for (int i = 0; i < randomWaterCharges.Next(5,10); i++)
    {
        item.WaterCharges();
    }
}
Console.WriteLine(PVK.BillingTime()); 