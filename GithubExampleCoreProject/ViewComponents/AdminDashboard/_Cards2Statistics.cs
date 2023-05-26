using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubExampleCoreProject.ViewComponents.AdminDashboard;

public class _Cards2Statistics : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}