using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    using Microsoft.AspNetCore.Authorization;

    [Authorize(Roles = "Test")]
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
