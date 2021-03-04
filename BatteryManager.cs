namespace BatteryManagementSystem
{
    public class BatteryManager
    {
        public float Temperature { get; set; }

        public float StateOfCharge { get; set; }

        public float ChargeRate { get; set; }

        public BatteryManager(float temperature, float stateOfCharge, float chargeRate)
        {
            Temperature = temperature;
            StateOfCharge = stateOfCharge;
            ChargeRate = chargeRate;
        }

        //impure function. Not used at all
        public bool IsValid()
        {
            TemperatureValidator temperatureValidator = new TemperatureValidator();
            if (temperatureValidator.IsValid(this))
            {
                ChargeRateValidator chargeRateValidator = new ChargeRateValidator();
                if (chargeRateValidator.IsValid(this))
                {
                    StateOfChargeValidator stateOfChargeValidator = new StateOfChargeValidator();
                    return stateOfChargeValidator.IsValid(this);
                }
            }
            return false;
        }
    }
}
