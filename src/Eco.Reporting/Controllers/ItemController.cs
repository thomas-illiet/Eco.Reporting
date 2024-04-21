using Eco.Core.Utils.Logging;
using Eco.Reporting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eco.Reporting.Controllers
{
    [AllowAnonymous]
    [Route("api/v1/reporting/items")]
    [Produces("application/json")]
    public class ItemController : ControllerBase
    {
        private readonly NLogWriter _logger = NLogManager.GetLogWriter(nameof(Reporting));
        
        /// <summary>
        /// Gets the list of items.
        /// </summary>
        [HttpGet]
        public IActionResult GetItems([FromQuery] bool includeHidden)
        {
            try { return Ok(ItemService.GetItems(includeHidden)); }
            catch (Exception ex)
            {
                _logger.WriteError("Unable to retrieve item list", ex);
                throw;
            }
        }
    }
}