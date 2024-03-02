using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace WApp.Exercises
{
    public interface IExerciseAppService :
        ICrudAppService<
            ExerciseDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateExerciseDto
            >
    {

    }
}
