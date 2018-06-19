using AutoMapper;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;

namespace LanguageCourses.Service
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseForDisplay>().ForMember(dest => dest.TeacherName,
                opt => opt.MapFrom(src => $"{src.FirstNameTeacher} {src.LastNameTeacher}"));
            CreateMap<CourseForCreation, Course>();
            CreateMap<CourseForUpdate, Course>();

            CreateMap<Mark, MarkForDisplay>();
            CreateMap<MarkForCreation, Mark>();

            CreateMap<CourseUser, CourseUserForDisplay>();
            CreateMap<CourseUserForCreation, CourseUser>();
            CreateMap<CourseUserForUpdate, CourseUser>();

            CreateMap<User, UserForLogin>();
            CreateMap<User, UserForDisplay>();
            CreateMap<UserForRegister, User>();
        }
    }
}
