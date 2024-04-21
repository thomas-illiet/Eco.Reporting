using Eco.Core.Utils.Logging;
using Eco.Reporting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eco.Reporting.Controllers
{
    [AllowAnonymous]
    [Route("api/v1/reporting/currencies")]
    [Produces("application/json")]
    public class CurrencyController : ControllerBase
    {
        private readonly NLogWriter _logger = NLogManager.GetLogWriter(nameof(Reporting));

        /// <summary>
        /// Gets the list of currencies.
        /// </summary>
        [HttpGet]
        public IActionResult GetCurrencies()
        {
            try { return Ok(CurrencyService.GetCurrencies()); }
            catch (Exception ex)
            {
                _logger.WriteError("Unable to retrieve currency list", ex);
                throw;
            }
        }
    }
}