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

        public Exercise Exercise { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(CreateUpdateExerciseDto exerciseDto)
        {
           
            if (!ModelState.IsValid)
            {
                foreach (var modelStateKey in ViewData.ModelState.Keys)
                {
                    var value = ViewData.ModelState[modelStateKey];
                    foreach (var error in value.Errors)
                    {
                        var errorMessage = error.ErrorMessage;
                    }
                }
                return Page();
            }

            await _exerciseAppService.CreateAsync(exerciseDto);
            return RedirectToPage("Index");
        }
    }
}
