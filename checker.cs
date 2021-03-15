using System;
using System.Diagnostics;
namespace BatteryManagementSystem
{
    public class BatteryChargingFactors
    {
        static int Main()
        {
            Debug.Assert(BatteryManager.IsBatteryConditionOk(25, 65, 0.7f));
            Debug.Assert(!BatteryManager.IsBatteryConditionOk(50, 65, 0.7f));
            Debug.Assert(BatteryManager.IsBatteryConditionOk(25, 65, 0.7f));
            Debug.Assert(!BatteryManager.IsBatteryConditionOk(25, 105, 0.7f));
            Debug.Assert(BatteryManager.IsBatteryConditionOk(25, 65, 0.7f));
            Debug.Assert(!BatteryManager.IsBatteryConditionOk(25, 65, 0.9f));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}