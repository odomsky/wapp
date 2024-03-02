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
    public class IndexModel : PageModel
    {
        private readonly WApp.EntityFrameworkCore.WAppDbContext _context;

        public IndexModel(WApp.EntityFrameworkCore.WAppDbContext context)
        {
            _context = context;
        }

        public IList<Exercise> Exercise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Exercise = await _context.Exercises.ToListAsync();
        }
    }
}
