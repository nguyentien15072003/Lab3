using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab_1.ViewComponents
{

    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();
        public RenderViewComponent()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() {Id =1, Name = "Branches", Link = "Branches/List" },
                new MenuItem() {Id =2, Name = "Students", Link = "Students/List" },
                new MenuItem() {Id =3, Name = "Courses", Link = "Courses/List" }
            };

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }


    }
}
