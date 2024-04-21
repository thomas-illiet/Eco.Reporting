using Eco.Gameplay.Economy;
using Eco.Reporting.Models;

namespace Eco.Reporting.Services
{
    /// <summary>
    /// Provides methods for retrieving currency data.
    /// </summary>
    public static class CurrencyService
    {
        /// <summary>
        /// Retrieves a collection of currency objects, representing all currencies in the system.
        /// </summary>
        public static IEnumerable<CurrencyDto> GetCurrencies()
            => CurrencyManager.Currencies.Select(currency => new CurrencyDto(currency));
    }
}