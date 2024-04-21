using Eco.Core.Utils.Logging;
using Eco.Reporting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eco.Reporting.Controllers
{   
    [AllowAnonymous]
    [Route("api/v1/reporting/players")]
    [Produces("application/json")]
    public class PlayerController : ControllerBase
    {
        private readonly NLogWriter _logger = NLogManager.GetLogWriter(nameof(Reporting));
        
        /// <summary>
        /// Gets the list of players.
        /// </summary>
        [HttpGet]
        public IActionResult GetPlayers()
        {
            try { return Ok(PlayerService.GetPlayers()); }
            catch (Exception ex)
            {
                _logger.WriteError("Unable to retrieve player list", ex);
                throw;
            }
        }
    }
}