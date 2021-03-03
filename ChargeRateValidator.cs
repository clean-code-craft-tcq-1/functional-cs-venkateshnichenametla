﻿namespace BatteryManagementSystem
{
    public class ChargeRateValidator : IValidator<BatteryManager>
    {
        static readonly float chargeRateMaximum = 0.8f;

        static readonly float chargeRateMinimum = 0.3f;

        public bool IsValid(BatteryManager batteryManager)
        {
            return !(batteryManager.ChargeRate > chargeRateMaximum);
        }

        public BreachLevel GetBreachLevel(BatteryManager batteryManager)
        {
            if (batteryManager.ChargeRate < chargeRateMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryManager.ChargeRate > chargeRateMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
