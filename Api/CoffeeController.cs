using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Patterns.Domain;
using Patterns.Domain.VisitorPattern;

namespace Patterns.Api;

[Route("[controller]/[action]")]
public class CoffeeController : ControllerBase
{
    private readonly ICoffeeProvider _coffeeProvider;
    private readonly IDiscountProvider _discountProvider;
    private readonly ILogger<CoffeeController> _logger;
    
     public CoffeeController(ICoffeeProvider coffeeProvider, IDiscountProvider discountProvider, ILogger<CoffeeController> logger)
    {
        _coffeeProvider = coffeeProvider;
        _discountProvider = discountProvider;
        _logger = logger;
    }
    [HttpGet]
    public async Task<IActionResult> GetMembershipDiscount()
    {
        try
        {
            // just for example 
            var coffeesList = new List<IVisitable>
            {
                new CappuccinoCoffee { Name = "Cappuccino", Price = 1.0m },
                new AmericanoCoffee { Name = "Americano", Price = 100.0m }
            };
            
            foreach (var coffee in coffeesList)
            {
                await _discountProvider.GetMembershipDiscount(coffee);
            }
            
            return Ok(coffeesList.Select(x => new{ ((dynamic)x).Name , ((dynamic)x).Price} ));
        }
        catch (Exception exception)
        {
            var message = "Couldn't handle get coffees discount";
            
            _logger.LogError(message, exception.Message);
            
             return StatusCode(StatusCodes.Status500InternalServerError, message);
      
        }
    }
    
    [HttpGet]
    public async Task<IActionResult> GetCoffeeByName([FromQuery] string coffeeType)
    {
        try
        {
            if (string.IsNullOrEmpty(coffeeType))
            {
                var message = "Invalid Target configuration. Missing NotificationType";
                
                _logger.LogError(message);
                
                //   return StatusCode(StatusCodes.Status422UnprocessableEntity, GenerateResponse(message));
            }
    
            var coffee = await _coffeeProvider.MakeCoffeeByName(coffeeType);
            
            return Ok(coffee);
        }
        catch (Exception exception)
        {
            var message = $"Couldn't handle get targets verification request NotificationType {coffeeType}";
            
            // _logger.LogError(message, exception.Message);
            //
            // return StatusCode(StatusCodes.Status500InternalServerError, GenerateResponse(message));
            return Ok();
        }
    }
}