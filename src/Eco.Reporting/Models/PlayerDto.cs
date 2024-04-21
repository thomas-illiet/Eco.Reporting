using Eco.Gameplay.Players;

namespace Eco.Reporting.Models
{
    /// <summary>
    /// A Data Transfer Object (DTO) for Player.
    /// </summary>
    public class PlayerDto
    {
        /// <summary>
        /// Gets the Steam ID of the player.
        /// </summary>
        public string SteamId { get; }

        /// <summary>
        /// Gets the SLG ID of the player.
        /// </summary>
        public string SlgId { get; }

        /// <summary>
        /// Gets the name of the player.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a value indicating whether the player is abandoned.
        /// </summary>
        public bool IsAbandoned { get; }

        /// <summary>
        /// Gets a value indicating whether the player is active.
        /// </summary>
        public bool IsActive { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerDto"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public PlayerDto(User user)
        {
            SteamId = user.SteamId;
            SlgId = user.SlgId;
            Name = user.Name;
            IsActive = user.IsActive;
            IsAbandoned = user.IsAbandoned;
        }
    }
}