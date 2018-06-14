using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Data.Model;
using LanguageCourses.Repository.Repository.Interfaces;
using LanguageCourses.Services.Services.Interfaces;

namespace LanguageCourses.Service.Services.Implementations
{
    public class CourseUserService : ICourseUserService
    {
        private readonly IMapper _mapper;
        private readonly ICourseUserRepository _courseUserRepository;

        public CourseUserService(IMapper mapper, ICourseUserRepository courseUserRepository)
        {
            _mapper = mapper;
            _courseUserRepository = courseUserRepository;
        }

        public async Task<List<CourseUser>> GetCourseUserListAsync() => 
            await _courseUserRepository.GetCourseUserListAsync();

        public async Task<List<CourseForDisplay>> GetCouseUserByCourseListAsync(Guid courseId) =>
            _mapper.Map<List<CourseForDisplay>>(await _courseUserRepository.GetCouseUserByCourseListAsync(courseId));

        public async Task<List<UserForDisplay>> GetCouseUserByUserListAsync(Guid userId) =>
            _mapper.Map<List<UserForDisplay>>(await _courseUserRepository.GetCouseUserByUserListAsync(userId));

        public async Task<CourseUser> GetCourseUserById(Guid id) => await _courseUserRepository.GetCourseUserById(id);

        public async Task<bool> AddCouseUserAsync(CourseUserForCreation courseUserForCreation)
        {
            var courseUser = _mapper.Map<CourseUser>(courseUserForCreation);
            await _courseUserRepository.AddCouseUserAsync(courseUser);
            return await _courseUserRepository.SaveChanges();
        }

        public async Task<bool> DeleteCourseAsync(Guid courseUserId)
        {
            var courseUser = await _courseUserRepository.GetCourseUserById(courseUserId);
            _courseUserRepository.DeleteCourseAsync(courseUser);
            return await _courseUserRepository.SaveChanges();
        }
    }
}
