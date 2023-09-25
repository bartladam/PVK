using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class Flat:House
    {
        public string Label { get; init; }
        public Flat(ContactPerson contactPerson, PragueCompany company, WaterMeter waterMater,string label): base(contactPerson, company, waterMater)
        {
            this.Label = label;
        }
    }
}
