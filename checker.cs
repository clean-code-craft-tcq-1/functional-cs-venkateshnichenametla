using System;
using System.Diagnostics;
namespace BatteryManagementSystem
{
    public class BatteryChargingFactors
    {
        public static bool IsTemperatureValid(BatteryProtector batteryProtector)
        {
            return new TemperatureValidator().IsValid(batteryProtector);
        }
        public static bool IsStateOfChargeValid(BatteryProtector batteryProtector)
        {
            return new StateOfChargeValidator().IsValid(batteryProtector);
        }
        public static bool IsChargeRateValid(BatteryProtector batteryProtector)
        {
            return new ChargeRateValidator().IsValid(batteryProtector);
        }
        public static BreachLevel GetTemperatureBreachLevel(BatteryProtector batteryProtector)
        {
            return new TemperatureValidator().GetBreachLevel(batteryProtector);
        }
        public static BreachLevel GetChargeRateBreachLevel(BatteryProtector batteryProtector)
        {
            return new ChargeRateValidator().GetBreachLevel(batteryProtector);
        }
        public static BreachLevel GetStateOfChargeBreachLevel(BatteryProtector batteryProtector)
        {
            return new StateOfChargeValidator().GetBreachLevel(batteryProtector);
        }
        static int Main()
        {
            Debug.Assert(IsTemperatureValid(new BatteryProtector(25, 65, 0.7f)));
            Debug.Assert(!IsTemperatureValid(new BatteryProtector(50, 65, 0.7f)));

            Debug.Assert(IsStateOfChargeValid(new BatteryProtector(25, 65, 0.7f)));
            Debug.Assert(!IsStateOfChargeValid(new BatteryProtector(25, 105, 0.7f)));

            Debug.Assert(IsChargeRateValid(new BatteryProtector(25, 65, 0.7f)));
            Debug.Assert(!IsChargeRateValid(new BatteryProtector(25, 65, 0.9f)));

            Debug.Assert(GetTemperatureBreachLevel(new BatteryProtector(-5, 65, 0.7f)) == BreachLevel.Low);
            Debug.Assert(GetTemperatureBreachLevel(new BatteryProtector(15, 65, 0.7f)) == BreachLevel.Normal);
            Debug.Assert(GetTemperatureBreachLevel(new BatteryProtector(80, 65, 0.7f)) == BreachLevel.High);

            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryProtector(15, 10, 0.7f)) == BreachLevel.Low);
            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryProtector(15, 50, 0.7f)) == BreachLevel.Normal);
            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryProtector(15, 100, 0.7f)) == BreachLevel.High);

            Debug.Assert(GetChargeRateBreachLevel(new BatteryProtector(15, 65, 0.2f)) == BreachLevel.Low);
            Debug.Assert(GetChargeRateBreachLevel(new BatteryProtector(15, 65, 0.7f)) == BreachLevel.Normal);

            Debug.Assert(GetChargeRateBreachLevel(new BatteryProtector(15, 65, 0.9f)) == BreachLevel.High);
            Console.WriteLine("All ok");
            return 0;
        }
    }
}