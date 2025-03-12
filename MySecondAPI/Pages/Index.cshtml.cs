using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySecondAPI.Pages
{
    public class IndexModel : PageModel
    {
        public string Message {get; set;} ="";
        public void OnGet()
        {
            this.Message= "Hello World V1!";
        }
    }
}
