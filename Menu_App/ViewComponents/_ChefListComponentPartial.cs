using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menu_App.Context;
using Microsoft.AspNetCore.Mvc;

namespace Menu_App.Views.Shared.Components
{
    public class _ChefListComponentPartial : ViewComponent

    {

        MenuContext context = new MenuContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Chefs.Where(x => x.Status == true).ToList();
            return View(values);

        }
    }
}
