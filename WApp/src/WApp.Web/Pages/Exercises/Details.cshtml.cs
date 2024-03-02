using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WApp.EntityFrameworkCore;
using WApp.Exercises;

namespace WApp.Web.Pages.Exercises
{
    public class DetailsModel : PageModel
    {
        private readonly WApp.EntityFrameworkCore.WAppDbContext _context;

        public DetailsModel(WApp.EntityFrameworkCore.WAppDbContext context)
        {
            _context = context;
        }

        public Exercise Exercise { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FirstOrDefaultAsync(m => m.Id == id);
            if (exercise == null)
            {
                return NotFound();
            }
            else
            {
                Exercise = exercise;
            }
            return Page();
        }
    }
}
