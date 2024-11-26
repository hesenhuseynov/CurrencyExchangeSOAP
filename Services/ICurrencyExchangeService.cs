using System.ServiceModel;

namespace CurrencyExchangeSOAP.Services
{
    [ServiceContract]
    public interface ICurrencyExchangeService
    {
        [OperationContract]
        double ConvertCurrency(string fromCurrency, string toCurrency, double amount);

        [OperationContract]
        string[] GetSupportedCurrencies();
    }
}
