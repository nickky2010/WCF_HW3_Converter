using System.ServiceModel;

namespace Converter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IConverterContract
    {
        [OperationContract]
        ConvertedUnits LinearMeasure(double meters);
        [OperationContract]
        ConvertedUnits CelsiusToFahrenheit(double c);
        [OperationContract]
        ConvertedUnits FahrenheitToCelsius(double f);
    }
}
