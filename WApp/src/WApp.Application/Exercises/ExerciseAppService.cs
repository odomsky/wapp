﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace WApp.Exercises
{
    public class ExerciseAppService :
        CrudAppService<
            Exercise, 
            ExerciseDto, 
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateExerciseDto>,
        IExerciseAppService
    {
        // private readonly IExerciseAppService exercises;
        public ExerciseAppService(IRepository<Exercise, int> repository) : base(repository)
        {
        }
    }
}
