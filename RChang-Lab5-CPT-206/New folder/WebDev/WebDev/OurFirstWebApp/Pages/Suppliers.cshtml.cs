//what is this codebehind????
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OurFirstWebApp.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string>? Suppliers { get; set; }
        public void OnGet()
        {
            //method gets called when page is requested
            ViewData["Title"] = "CPT-206-Web Project";
            //create a suppliers array to be viewed on the page
            Suppliers = new[] { "Alpha Co", "Beta Limited", "Gamma Corp" };
        }
    }
}
