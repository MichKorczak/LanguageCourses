using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LanguageCourses.Data.Model;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Repository.Repository.Interfaces;
using LanguageCourses.Service.Services.Interfaces;

namespace LanguageCourses.Service.Services.Implementations
{
    public class CourseUserMarkService : ICourseUserMarkService
    {
        private readonly IMapper _mapper;
        private readonly ICourseUserMarkRepository _courseUserMarkRepository;

        public CourseUserMarkService(IMapper mapper, ICourseUserMarkRepository courseUserMarkRepository)
        {
            _mapper = mapper;
            _courseUserMarkRepository = courseUserMarkRepository;
        }

        public async Task<List<CourseUserMarkForDisplay>> GetCourseUserMarkListAsync() =>
            _mapper.Map<List<CourseUserMarkForDisplay>>(await _courseUserMarkRepository.GetCourseUserMarkListAsync());

        public async Task<List<CourseUserMarkForDisplay>> GetCouseUserMarkByCourseUserListAsync(Guid courseUserId) =>
            _mapper.Map<List<CourseUserMarkForDisplay>>(await _courseUserMarkRepository.GetCouseUserMarkByCourseUserListAsync(courseUserId));

        public async Task<CourseUserMarkForDisplay> GetCourseUserMarkById(Guid id) =>
            _mapper.Map<CourseUserMarkForDisplay>(await _courseUserMarkRepository.GetCourseUserMarkById(id));

        public async Task<bool> AddCouseUserMarkAsync(CourseUserMarkForCreation courseUserMarkForCreation)
        {
            var courseUserMark = _mapper.Map<CourseUserMark>(courseUserMarkForCreation);
            await _courseUserMarkRepository.AddCouseUserMarkAsync(courseUserMark);
            return await _courseUserMarkRepository.SaveChanges();
        }

        public async Task<bool> DeleteCourseUserMarkAsync(Guid courseUserMarkId)
        {
            var courseUserMark = _courseUserMarkRepository.GetCourseUserMarkById(courseUserMarkId).Result;
            _courseUserMarkRepository.DeleteCourseAsync(courseUserMark);
            return await _courseUserMarkRepository.SaveChanges();
        }
    }
}
