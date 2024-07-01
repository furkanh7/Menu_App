using Menu_App.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.ViewComponents
{
    public class _MenuListComponentPartial : ViewComponent
    {

        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Products.ToList();
            return View(values);

        }



    }
}
