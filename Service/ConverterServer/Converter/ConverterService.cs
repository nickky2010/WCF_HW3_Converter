using System.ServiceModel;

namespace Converter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ConverterService : IConverterContract
    {
        const double footToMetrKoef = 3.28084;
        const double inchToMetrKoef = 39.3701;
        const double yardToMetrKoef = 1.09361;
        public ConvertedUnits CelsiusToFahrenheit(double c)
        {
            return new ConvertedUnits { Fahrenheit = (c * (9 / 5)) + 32 };
        }

        public ConvertedUnits FahrenheitToCelsius(double f)
        {
            return new ConvertedUnits { Celsius = (f - 32) * 5 / 9 };
        }

        public ConvertedUnits LinearMeasure(double meters)
        {
            return new ConvertedUnits
            {
                Foot = meters * footToMetrKoef,
                Inch = meters * inchToMetrKoef,
                Yard = meters * yardToMetrKoef
            };
        }
    }
}
