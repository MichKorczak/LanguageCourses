using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;
using LanguageCourses.Services.Services.Interfaces;

namespace LanguageCourses.Service.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;

        public CourseService(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }

        public async Task<List<CourseForDisplay>> GetCourseListAsync()
        {
            var course = _mapper.Map<List<CourseForDisplay>>(await _courseRepository.GetCourseListAsync());
            return course;
        }

        public async Task<CourseForDisplay> GetCourseById(Guid courseId)
        {
            var course = _mapper.Map<CourseForDisplay>(await _courseRepository.GetCourseById(courseId));
            return course;
        }

        public async Task<List<CourseForDisplay>> GetCourseByLanguage(string language)
        {
            var course = _mapper.Map<List<CourseForDisplay>>(await _courseRepository.GetCourseByLanguage(language));
            return course;
        }

        public async Task<List<CourseForDisplay>> GetCourseByCourseLevel(int courseLevel)
        {
            var course = _mapper.Map<List<CourseForDisplay>>(await _courseRepository.GetCourseByCourseLevel(courseLevel));
            return course;
        }

        public async Task<bool> AddCourseAsync(CourseForCreation courseForCreation)
        {
            var courseToAdd = _mapper.Map<Course>(courseForCreation);
            await _courseRepository.AddCourseAsync(courseToAdd);
            return await _courseRepository.SaveChanges();
        }

        public async Task<bool> DeleteCourseAsync(Guid courseId)
        {
            var course = await _courseRepository.GetCourseById(courseId);
            _courseRepository.DeleteCourseAsync(course);
            return await _courseRepository.SaveChanges();

        }
    }
}
