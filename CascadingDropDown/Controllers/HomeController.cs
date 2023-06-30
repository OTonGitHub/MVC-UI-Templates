using CascadingDropDown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CascadingDropDown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // You'd only need to populate root list only on init, ideally
            // if not init, and on edit instead, then, use models with prepopulated lists and id fields
            // for ajax calls to puplate lists, keep select tag disabled, until data retreived, for better user experience.

            PopulateViewBags();

            return View(new HolderModel());
        }

        public void PopulateViewBags()
        {
            ViewBag.ParentList = new SelectList( new List<SelectListItem> {
                new SelectListItem { Value="1", Text="Countries"},
                new SelectListItem { Value="2", Text="Foods"},
            },
            dataValueField: "Value",
            dataTextField: "Text"
            );

            ViewBag.Countries = new SelectList(new List<SelectListItem> {
                new SelectListItem { Value="3", Text="Maldives"},
                new SelectListItem { Value="4", Text="India"},
            },
            dataValueField: "Value",
            dataTextField: "Text"
            );

            ViewBag.Food = new SelectList(new List<SelectListItem> {
                new SelectListItem { Value="5", Text="Chicken"},
                new SelectListItem { Value="6", Text="Indian"},
            },
            "Value",
            "Text"
            );
        }

        public JsonResult GetGrandChildrenList(int childID)
        {
            // ideally a link .where() would be used here, instead of a fallout as below
            switch (childID)
            {
                case 3: // if 3, 4 all in childList, then move function to parent, as called twice
                case 4:
                    // OR Typle OR KeyValuePair
                    return Json(new Dictionary<string, string>()
                    {
                        { "7", "Resident" },
                        { "8", "Foreigner" }
                    }
                    .Select(col => new
                    {
                        value = col.Key,
                        text = col.Value
                    })
                    .ToList());

                case 5:
                    return Json(new Dictionary<string, string>()
                    {
                        { "9", "Breast" },
                        { "10", "Legs" },
                        { "11", "BBQ" },
                        { "12", "Roasted" },
                        { "13", "Whole" },
                    }
                    .Select(col => new
                    {
                        value = col.Key,
                        text = col.Value
                    })
                    .ToList());

                case 6:
                    return Json(new Dictionary<string, string>()
                    {
                        { "14", "Paani Poori" },
                        { "15", "Tandoor Special" },
                        { "16", "Masala" },
                    }
                   .Select(col => new
                   {
                       value = col.Key,
                       text = col.Value
                   })
                   .ToList());

                default:
                    return Json(Error);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}