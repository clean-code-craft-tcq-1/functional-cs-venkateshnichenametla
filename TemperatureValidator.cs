namespace BatteryManagementSystem
{
    public class TemperatureValidator : IValidator<BatteryManager>
    {
        private static readonly float temperatureMinimum = 0;

        private static readonly float temperatureMaximum = 45;

        public bool IsValid(BatteryManager batteryManager)
        {
            return !(batteryManager.Temperature < temperatureMinimum || batteryManager.Temperature > temperatureMaximum);
        }

        public BreachLevel GetBreachLevel(BatteryManager batteryManager)
        {
            if (batteryManager.Temperature < temperatureMinimum)
            {
                return BreachLevel.Low;
            }
            else if (batteryManager.Temperature > temperatureMaximum)
            {
                return BreachLevel.High;
            }
            return BreachLevel.Normal;
        }
    }
}
