using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class WaterMeter
    {
        public string Label { get; init; }
        public int consumedValue { get; set; }
        public WaterMeter(string label)
        {
            this.Label = label;
        }
        public void WaterCharges()
        {
            consumedValue += 1;
        }
        public override string ToString()
        {
            return consumedValue.ToString();
        }

    }
}
