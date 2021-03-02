namespace BatteryManagementSystem
{
    public class ChargeRateValidator : IValidator<BatteryProtector>
    {
        static readonly float chargeRateMaximum = 0.8f;

        static readonly float chargeRateMinimum = 0.3f;

        public bool IsValid(BatteryProtector batteryProtector)
        {
            return !(batteryProtector.ChargeRate > chargeRateMaximum);
        }

        public BreachLevel GetBreachLevel(BatteryProtector batteryProtector)
        {
            if (batteryProtector.ChargeRate < chargeRateMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryProtector.ChargeRate > chargeRateMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
