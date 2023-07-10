using GithubExampleCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

public class ApiMovieController : Controller
{
    [Area("Admin")]
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
            Headers =
            {
                { "X-RapidAPI-Key", "0ea86332bemsh96921789a8a3591p1de5a2jsn4af32eed2961" },
                { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
        }

        return View(apiMovieViewModels);
    }
}