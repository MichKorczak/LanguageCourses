using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using LanguageCourses.Data.Model;
using LanguageCourses.Data.DataTransfetObject;
using LanguageCourses.Repository.Repository.Interfaces;
using LanguageCourses.Service.Services.Interfaces;

namespace LanguageCourses.Service.Services.Implementations
{
    public class MarkService : IMarkService
    {
        private readonly IMapper _mapper;
        private readonly IMarkRepository _markRepository;

        public MarkService(IMapper mapper, IMarkRepository markRepository)
        {
            _mapper = mapper;
            _markRepository = markRepository;
        }

        public async Task<List<MarkForDisplay>> GetMarkListAsync() =>
            _mapper.Map<List<MarkForDisplay>>(await _markRepository.GetMarkListAsync());

        public async Task<List<MarkForDisplay>> GetMarkByCourseUserListAsync(Guid courseUserId) =>
            _mapper.Map<List<MarkForDisplay>>(await _markRepository.GetMarkByCourseUserListAsync(courseUserId));

        public async Task<MarkForDisplay> GetMarkById(Guid id) =>
            _mapper.Map<MarkForDisplay>(await _markRepository.GetMarkById(id));

        public async Task<bool> AddMarkAsync(MarkForCreation courseUserMarkForCreation)
        {
            var courseUserMark = _mapper.Map<Mark>(courseUserMarkForCreation);
            await _markRepository.AddMarkAsync(courseUserMark);
            return await _markRepository.SaveChanges();
        }

        public async Task<bool> DeleteMarkAsync(Guid courseUserMarkId)
        {
            var courseUserMark = _markRepository.GetMarkById(courseUserMarkId).Result;
            _markRepository.DeleteMarkAsync(courseUserMark);
            return await _markRepository.SaveChanges();
        }
    }
}
