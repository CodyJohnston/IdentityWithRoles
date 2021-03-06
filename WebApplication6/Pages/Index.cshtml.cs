﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    using Areas.Identity.Data;
    using Microsoft.AspNetCore.Identity;

    public class IndexModel : PageModel
    {
        private readonly UserManager<WebApplication6User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IndexModel(UserManager<WebApplication6User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> OnGet()
        {
            if (User.IsInRole("Admin"))
            {
                // You can set a breakpoint here to verify this is working
                Console.WriteLine("Success");
            }

            return Page();
        }
    }
}
