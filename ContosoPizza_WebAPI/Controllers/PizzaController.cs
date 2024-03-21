using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
// This line define the route for the controller, it will be used as the base route for all the actions in the controller
public class PizzaController : ControllerBase
{
  public PizzaController()
  {
  }

  // GET all action
  [HttpGet]
  public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

  // GET by Id action
  [HttpGet("{id}")] // This line define what type of request this action will handle,
  // and the parameter will be passed to the action method
  public ActionResult<Pizza> Get(int id)
  {
    var pizza = PizzaService.Get(id);

    if (pizza == null)
    {
      return NotFound();
    }
    // ActionResult<T> implements IActionResult, it can return the data direclty, automatically with 200 status code
    return pizza;
  }
  // POST action
  [HttpPost]
  // IActionResult can provide feedback to user to let them know if the action was successful or not
  // Needs more config than ActionResult<T>
  public IActionResult Create(Pizza pizza)
  {
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    // Returne Status Code(201), description("Creat") and url notation(/pizza/3) in header, then the object(pizza) in the body
  }
  // PUT action
  [HttpPut("{id}")]
  public IActionResult Update(int id, Pizza pizza)
  {
    if (id != pizza.Id)
    {
      return BadRequest();
    }

    var existingPizza = PizzaService.Get(id);
    if (existingPizza is null)
    {
      return NotFound();
    }

    PizzaService.Update(pizza);

    return NoContent();
  }

  // DELETE action
  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var pizza = PizzaService.Get(id);

    if (pizza is null)
    {
      return NotFound();
    }

    PizzaService.Delete(id);

    return NoContent();
  }
  // Remember to return NoContent() when update or deletion is successful
}