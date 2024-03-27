using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitWebApp.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Diagnostics;


namespace FruitWebApp.Pages
{
    public class AddModel : PageModel
    {
        // IHttpClientFactory set using dependency injection 
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<AddModel> _logger;
        public AddModel(IHttpClientFactory httpClientFactory, ILogger<AddModel> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        // Add the data model and bind the form data to the page model properties
        [BindProperty]
        public FruitModel FruitModels { get; set; }

        /* By this section, browser user doesn't directly interact with the api endpoint
        But the Page server send the POST request to the api endpoint */

        // Begin POST operation code
        public async Task<IActionResult> OnPost()
        {
            //parsing the content
            var jsonContent = new StringContent(JsonSerializer.Serialize(FruitModels),
                            Encoding.UTF8, "application/json");
            _logger.LogInformation($"JSON content: {jsonContent.ReadAsStringAsync().Result}");

            // Sending the POST request to the API
            var httpClient = _httpClientFactory.CreateClient("FruitAPI");
            using HttpResponseMessage response = await httpClient.PostAsync("", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                TempData["success"] = "Data was added successfully.";
                return RedirectToPage("Index");
            }
            else
            {
                TempData["failure"] = "Operation was not successful";
                return RedirectToPage("Index");
            }
        }
        // End POST operation code
    }
}

