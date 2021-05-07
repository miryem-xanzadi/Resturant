using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers.Article
{
    public class ArticleController : Controller
    {
        public IActionResult Single_Post(long Id)
        {
            return View();
        }

    }
}
