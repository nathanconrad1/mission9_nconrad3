using Microsoft.AspNetCore.Mvc;
using mission9_nconrad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission9_nconrad3.Componets
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookRepository repo { get; set; }

        public TypesViewComponent (IBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookType"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
