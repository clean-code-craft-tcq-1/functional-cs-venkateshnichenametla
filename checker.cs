using System;
using System.Diagnostics;
namespace BatteryManagementSystem
{
    public class BatteryChargingFactors
    {
        public static bool IsTemperatureValid(BatteryManager batteryManager)
        {
            return new TemperatureValidator().IsValid(batteryManager);
        }
        public static bool IsStateOfChargeValid(BatteryManager batteryManager)
        {
            return new StateOfChargeValidator().IsValid(batteryManager);
        }
        public static bool IsChargeRateValid(BatteryManager batteryManager)
        {
            return new ChargeRateValidator().IsValid(batteryManager);
        }
        public static BreachLevel GetTemperatureBreachLevel(BatteryManager batteryManager)
        {
            return new TemperatureValidator().GetBreachLevel(batteryManager);
        }
        public static BreachLevel GetChargeRateBreachLevel(BatteryManager batteryManager)
        {
            return new ChargeRateValidator().GetBreachLevel(batteryManager);
        }
        public static BreachLevel GetStateOfChargeBreachLevel(BatteryManager batteryManager)
        {
            return new StateOfChargeValidator().GetBreachLevel(batteryManager);
        }
        static int Main()
        {
            Debug.Assert(IsTemperatureValid(new BatteryManager(25, 65, 0.7f)));
            Debug.Assert(!IsTemperatureValid(new BatteryManager(50, 65, 0.7f)));

            Debug.Assert(IsStateOfChargeValid(new BatteryManager(25, 65, 0.7f)));
            Debug.Assert(!IsStateOfChargeValid(new BatteryManager(25, 105, 0.7f)));

            Debug.Assert(IsChargeRateValid(new BatteryManager(25, 65, 0.7f)));
            Debug.Assert(!IsChargeRateValid(new BatteryManager(25, 65, 0.9f)));

            Debug.Assert(GetTemperatureBreachLevel(new BatteryManager(-5, 65, 0.7f)) == BreachLevel.Low);
            Debug.Assert(GetTemperatureBreachLevel(new BatteryManager(15, 65, 0.7f)) == BreachLevel.Normal);
            Debug.Assert(GetTemperatureBreachLevel(new BatteryManager(80, 65, 0.7f)) == BreachLevel.High);

            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryManager(15, 10, 0.7f)) == BreachLevel.Low);
            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryManager(15, 50, 0.7f)) == BreachLevel.Normal);
            Debug.Assert(GetStateOfChargeBreachLevel(new BatteryManager(15, 100, 0.7f)) == BreachLevel.High);

            Debug.Assert(GetChargeRateBreachLevel(new BatteryManager(15, 65, 0.2f)) == BreachLevel.Low);
            Debug.Assert(GetChargeRateBreachLevel(new BatteryManager(15, 65, 0.7f)) == BreachLevel.Normal);
            Debug.Assert(GetChargeRateBreachLevel(new BatteryManager(15, 65, 0.9f)) == BreachLevel.High);

            Console.WriteLine("All ok");
            return 0;
        }
    }
}