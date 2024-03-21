using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
  public PizzaController()
  {
  }

  // GET all action
  [HttpGet]
  public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

  // GET by Id action
  [HttpGet("{id}")]
  public ActionResult<Pizza> Get(int id)
  {
    var pizza = PizzaService.Get(id);

    if (pizza == null)
    {
      return NotFound();
    }
    return pizza;
  }
  // POST action
  [HttpPost]
  // IActionResult can provide feedback to user to let them know if the action was successful or not
  public IActionResult Create(Pizza pizza)
  {
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    // Returne Status Code(201), description("Creat") and url notation(/pizza/3) in header, then the object(pizza) in the body
  }
  // PUT action
  // [HttpPut("{id}")]
  // public IActionResult Update(int id, Pizza pizza)
  // {

  // }

  // DELETE action
  // [HttpDelete("{id}")]
  // public IActionResult Delete(int id)
  // {

  // }
}