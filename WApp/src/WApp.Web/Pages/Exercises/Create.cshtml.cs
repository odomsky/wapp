using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WApp.EntityFrameworkCore;
using WApp.Exercises;

namespace WApp.Web.Pages.Exercises
{
    public class CreateModel : WAppPageModel
    {
        [BindProperty]
        public CreateUpdateExerciseDto exerciseDto { get; set; }
        private readonly IExerciseAppService _exerciseAppService;


        public CreateModel(IExerciseAppService exerciseAppService)
        {
            _exerciseAppService = exerciseAppService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Exercise Exercise { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _exerciseAppService.CreateAsync(exerciseDto);
            return RedirectToPage("Index"); // Or wherever you want to redirect after creation
        }
    }
}
