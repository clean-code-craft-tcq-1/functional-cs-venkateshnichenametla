namespace BatteryManagementSystem
{
    public class TemperatureValidator : IValidator<BatteryProtector>
    {
        private static readonly float temperatureMinimum = 0;

        private static readonly float temperatureMaximum = 45;

        public bool IsValid(BatteryProtector batteryProtector)
        {
            return !(batteryProtector.Temperature < temperatureMinimum || batteryProtector.Temperature > temperatureMaximum);
        }

        public BreachLevel GetBreachLevel(BatteryProtector batteryProtector)
        {
            if (batteryProtector.Temperature < temperatureMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryProtector.Temperature > temperatureMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
