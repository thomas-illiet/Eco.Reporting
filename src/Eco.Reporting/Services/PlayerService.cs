using Eco.Gameplay.Players;
using Eco.Reporting.Models;

namespace Eco.Reporting.Services
{
    /// <summary>
    /// Provides methods for retrieving player data.
    /// </summary>
    public static class PlayerService
    {
        /// <summary>
        /// Retrieves a collection of currency objects, representing all currencies in the system.
        /// </summary>
        public static IEnumerable<PlayerDto> GetPlayers()
            => UserManager.Users.Select(player => new PlayerDto(player));
    }
}