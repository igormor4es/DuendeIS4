using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuendeIS4.Pages.Device
{
    [SecurityHeaders]
    [Authorize]
    public class SuccessModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}