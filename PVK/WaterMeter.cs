using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK
{
    internal class WaterMeter
    {
        /// <summary>
        /// Important for employer from PVK to checking water meter
        /// </summary>
        public string Label { get; init; }
        /// <summary>
        /// Final consumed water value
        /// </summary>
        public int consumedValue { get; set; }
        public WaterMeter(string label)
        {
            this.Label = label;
        }
        /// <summary>
        /// increase consumption water
        /// </summary>
        public void ConsumptionWater()
        {
            consumedValue += 1;
        }
        public override string ToString()
        {
            return consumedValue.ToString();
        }

    }
}
