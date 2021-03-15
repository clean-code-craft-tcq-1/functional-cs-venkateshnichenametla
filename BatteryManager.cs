using System;
namespace BatteryManagementSystem
{
    public class BatteryManager
    {
        public static bool IsBatteryConditionOk(float temperature, float stateOfCharge, float chargeRate)
        {
            return IsTemperatureInRange(temperature) && IsStateOfChargeInRange(stateOfCharge) && IsChargeRateInRange(chargeRate);
        }

        public static bool IsTemperatureInRange(float temperature)
        {
            bool isValid = IsInRange(temperature, BatteryRanges.MinimumTemperature, BatteryRanges.MaximumTemperature);
            if (!isValid)
                DisplayErrorMessage("Temperture is Out of Range");
            return isValid;
        }

        public static bool IsStateOfChargeInRange(float stateOfCharge)
        {
            bool isValid = IsInRange(stateOfCharge, BatteryRanges.MinimumStateOfCharge, BatteryRanges.MaximumStateOfCharge);
            if (!isValid)
                DisplayErrorMessage("State of charge is Out of Range");
            return isValid;
        }

        public static bool IsChargeRateInRange(float chargeRate)
        {
            bool isValid = IsInRange(chargeRate, BatteryRanges.MinimumChargeRate, BatteryRanges.MaximumChargeRate);
            if (!isValid)
                DisplayErrorMessage("Charge Rate is Out of Range");
            return isValid;
        }

        public static bool IsInRange(float currentValue, float minimumValue, float maximumValue)
        {
            return ((currentValue > minimumValue) && (currentValue < maximumValue));
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
