using Eco.Gameplay.Components;
using Eco.Mods.TechTree;

namespace Eco.Reporting.Models
{
    /// <summary>
    /// Represents a data transfer object for a trade offer.
    /// </summary>
    public class TradeOfferDto
    {
        /// <summary>
        /// Gets the unique identifier of the store object associated with the trade offer.
        /// </summary>
        public int StoreId { get; }

        /// <summary>
        /// Gets the quantity of items involved in the trade offer.
        /// </summary>
        public int Quantity { get; }

        /// <summary>
        /// Gets the price of the trade offer.
        /// </summary>
        public float Price { get; }

        /// <summary>
        /// Gets the name of the item involved in the trade offer.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a string indicating whether the trade offer is for buying or selling.
        /// </summary>
        public string Mode { get; }

        /// <summary>
        /// Initializes a new instance of the TradeOfferDto class.
        /// </summary>
        /// <param name="tradeOffer">The trade offer details.</param>
        /// <param name="store">The store object associated with the trade offer.</param>
        public TradeOfferDto(TradeOffer tradeOffer, StoreObject store)
        {
            StoreId = store.ID;
            Quantity = tradeOffer.Stack.Quantity;
            Price = tradeOffer.Price;
            Name = tradeOffer.Stack.Item!.Name;
            Mode = tradeOffer.Buying ? "Buying" : "Selling";
        }
    }
}