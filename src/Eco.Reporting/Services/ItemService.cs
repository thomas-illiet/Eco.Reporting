using Eco.Gameplay.Items;
using Eco.Reporting.Models;

namespace Eco.Reporting.Services
{
    /// <summary>
    /// Provides methods for retrieving item data.
    /// </summary>
    public static class ItemService
    {
        /// <summary>
        /// Retrieves a collection of item objects, optionally including hidden items.
        /// </summary>
        /// <param name="includeHidden">A boolean indicating whether to include hidden items in the result set.
        /// The default value is false, which means only non-hidden items are returned.</param>
        public static IEnumerable<ItemDto> GetItems(bool includeHidden = false)
        {
            // Selects the appropriate list of items based on whether hidden items should be included.
            var items = includeHidden
                ? Item.AllItemsIncludingHidden
                : Item.AllItemsExceptHidden;

            // Iterates over the items and projects each one into a new ItemDto object.
            foreach (var item in items)
                yield return new ItemDto(item);
        }
        
        /// <summary>
        /// Retrieves an item object.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        public static ItemDto? GetItem(string name)
        {
            var result = Item.AllItemsIncludingHidden.FirstOrDefault(x => x.Name == name);
            return result == default ? default : new ItemDto(result);
        }
    }
}