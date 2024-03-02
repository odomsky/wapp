using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using WApp.Exercises;

namespace WApp.EntityFrameworkCore.Exercises
{
    public class ExerciseRepository : EfCoreRepository<WAppDbContext, Exercise, int>
    {
        public ExerciseRepository(IDbContextProvider<WAppDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
