using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.ViewComponents
{
    public class PopularPosts: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(viewName: "PopularPosts");
            //return View(viewName: "Search", _getCategoryService.Execute().Data);
        }
    }
}
