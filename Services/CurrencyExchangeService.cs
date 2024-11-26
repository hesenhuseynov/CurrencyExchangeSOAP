namespace CurrencyExchangeSOAP.Services
{

    public class CurrencyExchangeService : ICurrencyExchangeService
    {
        private static readonly Dictionary<string, double> ExchangeRates = new()
        {
             { "USD", 1.0 },
        { "EUR", 0.9 },
        { "TRY", 27.5 },
        { "GBP", 0.8 },
        { "JPY", 140.0 }
        };

        public double ConvertCurrency(string fromCurrency, string toCurrency, double amount)
        {
            if (!ExchangeRates.ContainsKey(fromCurrency) || !ExchangeRates.ContainsKey(toCurrency))
                throw new ArgumentException("UnSupported Currency ");


            var fromRate = ExchangeRates[fromCurrency];
            var toRate= ExchangeRates[toCurrency];

            return (amount / fromRate) * toRate;


        }

        public string[] GetSupportedCurrencies()
        {
            return ExchangeRates.Keys.ToArray();
        }
    }
}
