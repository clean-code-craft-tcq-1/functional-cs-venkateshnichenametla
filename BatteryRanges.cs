using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatteryManagementSystem
{
    public class BatteryRanges
    {
        internal static readonly float MinimumTemperature = 0;
        internal static readonly float MaximumTemperature = 45;
        internal static readonly float MinimumStateOfCharge = 20;
        internal static readonly float MaximumStateOfCharge = 80;
        internal static readonly float MinimumChargeRate = 0.3f;
        internal static readonly float MaximumChargeRate = 0.8f;
    }
}
