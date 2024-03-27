using Microsoft.AspNetCore.Mvc.RazorPages;
using FruitWebApp.Models;
using System.Text.Json;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace FruitWebApp.Pages
{
    public class IndexModel : PageModel
    {
        // IHttpClientFactory set using dependency injection 
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // Add the data model and bind the form data to the page model properties
        // Enumerable since an array is expected as a response
        [BindProperty]
        public IEnumerable<FruitModel> FruitModels { get; set; }

        // Begin GET operation code
        public async Task onGet()
        {
            // Create the HTTP client using the FruitAPI named factory set in the Program.cs file
            var httpClient = _httpClientFactory.CreateClient("FruitAPI");

            // Perform the GET request and store the response.
            // This step is like Fetch in JavaScript.
            // Empty string means the base URL is used.
            // Can be replaced with other specific endpoints.
            using HttpResponseMessage response = await httpClient.GetAsync("");


            // Check the response by the status code
            if (response.IsSuccessStatusCode)
            {
                using var contentStream = await response.Content.ReadAsStreamAsync();
                FruitModels = await JsonSerializer.DeserializeAsync<IEnumerable<FruitModel>>(contentStream);
            }
        }
        // End GET operation code
    }
}

