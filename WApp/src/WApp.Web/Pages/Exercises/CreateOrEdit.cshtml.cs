using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.ObjectMapping;
using WApp.EntityFrameworkCore;
using WApp.Exercises;

namespace WApp.Web.Pages.Exercises
{
    public class CreateOrEditModel : WAppPageModel
    {
        [BindProperty]
        public CreateUpdateExerciseDto CreateUpdateExerciseDto { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? ExerciseId { get; set; }

        private readonly IExerciseAppService _exerciseAppService;

        public CreateOrEditModel(IExerciseAppService exerciseAppService)
        {
            _exerciseAppService = exerciseAppService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //ExerciseDto exercise;
            if (id.HasValue)
            {
                var exercise = await _exerciseAppService.GetAsync(id.Value);
                if (exercise == null)
                {
                    return NotFound();
                }
               ExerciseId = id;
               CreateUpdateExerciseDto = ObjectMapper.Map<ExerciseDto, CreateUpdateExerciseDto>(exercise);
            }

            // For 'create', we just display an empty form.
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ExerciseId.HasValue)
            {
                CreateUpdateExerciseDto.Id = ExerciseId.Value;
                await _exerciseAppService.UpdateAsync(ExerciseId.Value, CreateUpdateExerciseDto);
            }
            else
            {
                await _exerciseAppService.CreateAsync(CreateUpdateExerciseDto);
            }
            return RedirectToPage("Index");
        }


    }
}
