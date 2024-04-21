using Eco.Gameplay.Economy;
using Eco.Shared.Items;

namespace Eco.Reporting.Models
{
    /// <summary>
    /// A Data Transfer Object (DTO) for Currency.
    /// </summary>
    public class CurrencyDto
    {
        /// <summary>
        /// Gets the name of the currency.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the circulation of the currency.
        /// </summary>
        public float Circulation { get; }

        /// <summary>
        /// Gets the total currency.
        /// </summary>
        public float TotalCurrency { get; }

        /// <summary>
        /// Gets a value indicating whether this currency is a player credit.
        /// </summary>
        public bool IsPlayerCredit { get; }

        /// <summary>
        /// Gets the type of the currency.
        /// </summary>
        public CurrencyType CurrencyType { get; }

        /// <summary>
        /// Gets a value indicating whether this currency is backed.
        /// </summary>
        public bool Backed { get; }

        /// <summary>
        /// Gets the name of the item backing this currency.
        /// </summary>
        public string? BackingItem { get; }

        /// <summary>
        /// Gets the number of coins per backing item.
        /// </summary>
        public float CoinsPerItem { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDto"/> class.
        /// </summary>
        /// <param name="currency">The currency.</param>
        public CurrencyDto(Currency currency)
        {
            Name = currency.Name;
            Circulation = currency.Circulation;
            TotalCurrency = currency.TotalCurrency;
            IsPlayerCredit = currency.IsPlayerCredit;
            CurrencyType = currency.CurrencyType;

            if (currency.Backed)
            {
                Backed = currency.Backed;
                BackingItem = currency.BackingItem?.Name;
                CoinsPerItem = currency.CoinsPerItem;
            }
        }
    }
}