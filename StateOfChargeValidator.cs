namespace BatteryManagementSystem
{
    public class StateOfChargeValidator : IValidator<BatteryManager>
    {
        private static readonly float stateOfChargeMinimum = 20;

        private static readonly float stateOfChargeMaximum = 80;

        //Pure function
        public bool IsValid(BatteryManager batteryManager)
        {
            return !(batteryManager.StateOfCharge < stateOfChargeMinimum || batteryManager.StateOfCharge > stateOfChargeMaximum);
        }

        //Pure function
        public BreachLevel GetBreachLevel(BatteryManager batteryManager)
        {
            if (batteryManager.StateOfCharge < stateOfChargeMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryManager.StateOfCharge > stateOfChargeMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
