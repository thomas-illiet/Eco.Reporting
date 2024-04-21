using Eco.Gameplay.Items;

namespace Eco.Reporting.Models
{
    /// <summary>
    /// A Data Transfer Object (DTO) for Item.
    /// </summary>
    public partial class ItemDto
    {
        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the display name of the item.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Gets the description of the item.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the category of the item.
        /// </summary>
        public string? Category { get; }

        /// <summary>
        /// Gets the weight of the item.
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Gets the group of the item.
        /// </summary>
        public string Group { get; }

        /// <summary>
        /// Gets a value indicating whether the item is hidden.
        /// </summary>
        public bool Hidden { get; }

        /// <summary>
        /// Gets the maximum stack size of the item.
        /// </summary>
        public int MaxStackSize { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDto"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public ItemDto(Item item)
        {
            // Default mapping
            Name = item.Name;
            DisplayName = item.DisplayName;
            Description = DescriptionRegex().Replace(item.GetDescription, "");
            Weight = item.Weight;
            Group = item.Group;
            Hidden = item.Hidden;
            MaxStackSize = item.MaxStackSize;
            
            // Category Mapping
            if (!string.IsNullOrEmpty(item.Category) && item.Category != "_None")
                Category = item.Category;
        }

        /// <summary>
        /// A regular expression pattern to remove HTML tags from the item description.
        /// </summary>
        [System.Text.RegularExpressions.GeneratedRegex("<i>*<\\/i>")]
        private static partial System.Text.RegularExpressions.Regex DescriptionRegex();
    }
}