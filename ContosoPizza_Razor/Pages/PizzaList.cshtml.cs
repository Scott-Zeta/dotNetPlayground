using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        [BindProperty] //This attribute is essential when dealing with POST requests
        public Pizza NewPizza { get; set; } = default!;
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewPizza == null)
            {
                // validation check by the class defined in Model file Pizza.cs
                return Page();
            }

            _service.AddPizza(NewPizza);

            return RedirectToAction("Get");
        }

        private readonly PizzaService _service;
        public IList<Pizza> PizzaList { get; set; } = default!;

        public PizzaListModel(PizzaService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            PizzaList = _service.GetPizzas();
        }
    }
}
