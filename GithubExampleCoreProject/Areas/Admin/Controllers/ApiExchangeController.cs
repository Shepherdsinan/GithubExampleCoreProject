using GithubExampleCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

public class ApiExchangeController : Controller
{
    [Area("Admin")]
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        List<BookingExchangeViewModel2> bookingExchangeViewModels = new List<BookingExchangeViewModel2>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
            Headers =
            {
                { "X-RapidAPI-Key", "0ea86332bemsh96921789a8a3591p1de5a2jsn4af32eed2961" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
            return View(values.exchange_rates);
        }
        
    }
}