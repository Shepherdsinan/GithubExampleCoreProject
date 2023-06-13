using System.Text;
using GithubExampleCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

[Area("Admin")]
public class VisitorApiController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public VisitorApiController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var reponseMessage = await client.GetAsync("http://localhost:5128/api/Visitor");
        if (reponseMessage.IsSuccessStatusCode)
        {
            var jsondata = await reponseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<VisitorViewModel>>(jsondata);
            return View(values);
        }

        return View();
    }

    [HttpGet]
    public IActionResult CreateVisitor()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateVisitor(VisitorViewModel p)
    {
        var client = _httpClientFactory.CreateClient();
        var jsondata = JsonConvert.SerializeObject(p);
        StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("http://localhost:5128/api/Visitor", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> DeleteVisitor(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"http://localhost:5128/api/Visitor/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> UpdateVisitor(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"http://localhost:5128/api/Visitor/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsondata = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<VisitorViewModel>(jsondata);
            return View(values);
        }

        return View();
    }

[HttpPost]
    public async Task<IActionResult> UpdateVisitor(VisitorViewModel p)
    {
        var client = _httpClientFactory.CreateClient();
        var jsondata = JsonConvert.SerializeObject(p);
        StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("http://localhost:5128/api/Visitor", content);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}