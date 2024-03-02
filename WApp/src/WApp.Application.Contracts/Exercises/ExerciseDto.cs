using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging;

namespace WApp.Exercises
{
    public class ExerciseDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
