namespace Patterns.Domain.DecoratorPattern;

public class AmericanoDecorator: ICoffeeDescription
{
    private readonly ICoffeeDescription _coffee;
    
    public AmericanoDecorator(ICoffeeDescription coffee)
    {
        _coffee = coffee;
    }
    
    public async Task<string> GetCoffeeDescription()
    {
        var description = await _coffee.GetCoffeeDescription();
        
        description = $"{description} some additional Americano description";

        return description;
    }
}

// [HttpGet]
// public async Task<IActionResult> GetCoffeeDescriptionByName([FromQuery] string coffee)
// {
//     try
//     {
//         if (string.IsNullOrEmpty(coffee))
//         {
//             var message = "Invalid Target configuration. Missing NotificationType";
//             
//             _logger.LogError(message);
//             
//          //   return StatusCode(StatusCodes.Status422UnprocessableEntity, GenerateResponse(message));
//         }
//
//         await _coffeeProvider.GetCoffeeDescriptionByName(coffee);
//         
//         return Ok();
//     }
//     catch (Exception exception)
//     {
//         var message = $"Couldn't handle get targets verification request NotificationType {coffee}";
//         
//         // _logger.LogError(message, exception.Message);
//         //
//         // return StatusCode(StatusCodes.Status500InternalServerError, GenerateResponse(message));
//         return Ok();
//     }
// }
//