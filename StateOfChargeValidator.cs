namespace BatteryManagementSystem
{
    public class StateOfChargeValidator : IValidator<BatteryProtector>
    {
        private static readonly float stateOfChargeMinimum = 20;

        private static readonly float stateOfChargeMaximum = 80;

        public bool IsValid(BatteryProtector batteryProtector)
        {
            return !(batteryProtector.StateOfCharge < stateOfChargeMinimum || batteryProtector.StateOfCharge > stateOfChargeMaximum);
        }

        public BreachLevel GetBreachLevel(BatteryProtector batteryProtector)
        {
            if (batteryProtector.StateOfCharge < stateOfChargeMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryProtector.StateOfCharge > stateOfChargeMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
