namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Car
    {
        public string CarName;
        public double CarNettoPrice;
        public double AluWheels;
        public double AutomaticWindows;
        public double AutomaticTransmision;
        public double LeatherSeats;
        public int VATRate;

        public Car(string carName, double carNettoPrice, double aluWheels, double automaticWindows, double automaticTransmision, double leatherSeats, int vATRate)
        {

            CarName = carName;
            CarNettoPrice = carNettoPrice;
            AluWheels = aluWheels;
            AutomaticWindows = automaticWindows;
            AutomaticTransmision = automaticTransmision;
            LeatherSeats = leatherSeats;
            VATRate = vATRate;
        }

        public Car(string carName, double carNettoPrice, int vatRate)
        {
            CarName = carName;
            CarNettoPrice = carNettoPrice;
            VATRate = vatRate;
        }

        public void ValueOfAdditions()
        {
            double valueOfAdditions = AluWheels + AutomaticWindows + AutomaticTransmision + LeatherSeats;
            double taxAmount = Math.Round(valueOfAdditions * VATRate / 100, 2);
            Console.WriteLine($"Value of {CarName} additions: {valueOfAdditions} + {taxAmount} VAT = {valueOfAdditions + taxAmount}");
        }
    }
}
