using CurrencyExchangeSOAP.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyExchangeSOAP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyExchangeController:ControllerBase
    {
        private readonly ICurrencyExchangeService _service;


        public CurrencyExchangeController(ICurrencyExchangeService service)
        {
            _service = service;
        }

        [HttpGet("convert")]
        public IActionResult ConvertCurrency(string fromCurrency, string toCurrency, double amount)
        {
            try
            {
                var result = _service.ConvertCurrency(fromCurrency, toCurrency, amount);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
         


        [HttpGet("currencies")]
        public IActionResult GetSupportedCurrencies()
        {
            return Ok(_service.GetSupportedCurrencies());
        }


    }
}
