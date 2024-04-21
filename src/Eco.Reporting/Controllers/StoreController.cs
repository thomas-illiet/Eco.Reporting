using Eco.Core.Utils.Logging;
using Eco.Reporting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eco.Reporting.Controllers
{
    [AllowAnonymous]
    [Route("api/v1/reporting/stores")]
    [Produces("application/json")]
    public class StoreController : ControllerBase
    {
        private readonly NLogWriter _logger = NLogManager.GetLogWriter(nameof(Reporting));

        /// <summary>
        /// Retrieves a list of stores.
        /// </summary>
        [HttpGet]
        public IActionResult GetStores()
        {
            try
            {
                var result = StoreService.GetStores();
                return Ok(result.ToList());
            }
            catch (Exception ex)
            {
                _logger.WriteError("Unable to retrieve store list", ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieves a list of trade offers.
        /// </summary>
        [HttpGet("offers")]
        public IActionResult GetOffers()
        {
            try
            {
                var result = StoreService.GetTradeOffers();
                return Ok(result.ToList());
            }
            catch (Exception ex)
            {
                _logger.WriteError("Unable to retrieve trade offer list", ex);
                throw;
            }
        }
    }

}