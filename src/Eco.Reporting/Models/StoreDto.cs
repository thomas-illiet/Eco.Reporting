using System.Text.RegularExpressions;
using Eco.Gameplay.Components;
using Eco.Mods.TechTree;

namespace Eco.Reporting.Models
{
    /// <summary>
    /// A Data Transfer Object (DTO) for Store.
    /// </summary>
    public partial class StoreDto
    {
        /// <summary>
        /// Gets the ID of the store.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the store.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the currency of the store.
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Gets the name of the store owner.
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// Gets a value indicating whether the store is operating.
        /// </summary>
        public bool Operating { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDto"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public StoreDto(StoreObject store)
        {
            Id = store.ID;
            Name = NameRegex().Replace(store.Name, "");
            Currency = store.GetComponent<CreditComponent>().CreditData.Currency.Name;
            Owner = store.Owners.Name;
            Operating = store.Operating;
        }

        /// <summary>
        /// A regular expression pattern to remove HTML tags from the store name.
        /// </summary>
        [GeneratedRegex("<color[^>]*>")]
        private static partial Regex NameRegex();
    }
}