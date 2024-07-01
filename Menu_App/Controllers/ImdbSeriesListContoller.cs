using Menu_App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Menu_App.Controllers
{
    public class ImdbSeriesListContoller : Controller
    {
        public async Task<IActionResult> ImdbSeriesList()
        {

            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),
                Headers =
    {
        { "x-rapidapi-key", "dc24b80c66msh211254ea2ddeb6dp148629jsn97c9e085b1f8" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                var values = JsonConvert.DeserializeObject<List<ImdbSeriesListViewModel>>(body);
                return View(values.ToList());
            }




            return View();
        }
    }
}
