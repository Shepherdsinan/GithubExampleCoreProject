using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GithubExampleCoreProject.Areas.Admin.Models;


namespace GithubExampleCoreProject.Areas.Admin.Controllers;

[Area("Admin")]
[AllowAnonymous]
public class BookingHotelSearchController : Controller
{

    public async Task<IActionResult> Index()
    {
        
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id=-553173&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
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
            //var bodyReplace = body.Replace(".", "");
            var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
            return View(values.results);
        }

        #region eski api

        /*var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&dest_type=city&order_by=popularity&dest_id=-1456928&locale=en-gb&checkin_date=2023-01-27&filter_by_currency=EUR&checkout_date=2023-01-28&adults_number=2&units=metric&children_ages=5%2C0&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_number=2"),
            Headers =
            {
                { "X-RapidAPI-Key", "cb5ee15da1mshb46d59d679af3abp1fe84cjsn167590fdc0cc" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var bodyReplace = body.Replace(".", "");
            var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
            return View(values.result);
        }*/
        #endregion
    }
}