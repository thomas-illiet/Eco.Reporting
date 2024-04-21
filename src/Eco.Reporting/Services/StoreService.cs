using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Store;
using Eco.Mods.TechTree;
using Eco.Reporting.Models;
using Eco.Shared.Networking;

namespace Eco.Reporting.Services
{

    public static class StoreService
    {
        public static IEnumerable<StoreDto> GetStores()
        {
            var storeObjects = NetObjectManager.Default.GetNetObjectsOfType<StoreObject>();
            foreach (var storeObject in storeObjects)
            {
                if (storeObject.GetComponent<CreditComponent>().CreditData.Currency == null)
                    continue;
                
                yield return new StoreDto(storeObject);
            }
        }
        
        public static IEnumerable<TradeOfferDto> GetTradeOffers()
        {
            var offers = new List<TradeOfferDto>();
            var storeObjects = NetObjectManager.Default.GetNetObjectsOfType<StoreObject>();
            foreach (var storeObject in storeObjects)
            {
                if (storeObject.GetComponent<CreditComponent>().CreditData.Currency == null)
                    continue;

                var tradeOffers = storeObject.GetComponent<StoreComponent>().AllOffers;
                offers.AddRange(tradeOffers.Select(o => new TradeOfferDto(o, storeObject)).ToList());
            }
            return offers;
        }
    }
}