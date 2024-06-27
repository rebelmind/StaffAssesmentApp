using AutoMapper;
using StaffAssesmentApp.Interfaces.Services;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Services
{
    public class UserAnswereService : IUserAnswereService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IMapper _mapper;

        public UserAnswereService(IUserAnswerRepository userAnswerRepository)
        {
            _userAnswerRepository = userAnswerRepository;
        }

        public Task AddUserAnswerAsync(AnswerDto userAnswerDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAnswerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserAnswerDto>> GetAllUserAnswerAsync()
        {
            var answers = await _userAnswerRepository.ListAllAsync();
            return _mapper.Map<IEnumerable<UserAnswerDto>>(answers);
        }

        public Task<UserAnswerDto> GetUserAnswerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAnswerAsync(UserAnswerDto userAnswerDto)
        {
            throw new NotImplementedException();
        }
    }
}
