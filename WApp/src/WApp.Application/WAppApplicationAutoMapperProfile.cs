using AutoMapper;
using WApp.Exercises;

namespace WApp;

public class WAppApplicationAutoMapperProfile : Profile
{
    public WAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Exercise, ExerciseDto>();
        CreateMap<CreateUpdateExerciseDto, Exercise>();
    }
}
