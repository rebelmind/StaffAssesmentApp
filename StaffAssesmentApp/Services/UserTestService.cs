using AutoMapper;
using StaffAssesmentApp.Interfaces.Services;
using StaffAssesmentApp.Models.DTOs;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;
using System.Security.Claims;

namespace StaffAssesmentApp.Services
{
    public class UserTestService : IUserTestService
    {
        private readonly IUserTestRepository _userTestRepository;
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly ICalculateResultService _calculateResultService;
        private readonly IMapper _mapper;

        public UserTestService(IUserTestRepository userTestRepository, IMapper mapper, IUserAnswerRepository userAnswerRepository, ICalculateResultService calculateResultService)
        {
            _userTestRepository = userTestRepository;
            _mapper = mapper;
            _userAnswerRepository = userAnswerRepository;
            _calculateResultService = calculateResultService;

        }

        public async Task<TestResultDto> CreateUserTestAsync(UserTestDto userTestDto)
        {
            
            var userTest = new UserTest
            {
                AppUserId = userTestDto.UserId,
                TestId = userTestDto.TestId,
                EndTime = DateTime.Now
            };
            await _userTestRepository.AddAsync(userTest);
            userTest.Score = _calculateResultService.CalculateScore(userTestDto).Result;

            foreach (var question in userTestDto.Test.Questions)
            {
                foreach (var answer in question.Answers)
                {
                    var userAnswer = new UserAnswer
                    {
                        UserTestId = userTest.Id,
                        QuestionId = question.Id,
                        AnswerId = answer.Id,
                        AnswerText = answer.AnswerText
                    };
                    await _userAnswerRepository.AddAsync(userAnswer);
                    
                }
            }

 
            await _userTestRepository.UpdateAsync(userTest);


            TestResultDto result = new TestResultDto()
            {
                Score = userTest.Score,
                StartTime = userTestDto.StartTime,
                EndTime = userTest.EndTime,
                TestName = userTestDto.Test.Title,
                Descr = userTestDto.Test.Description

                
            };

            return result;
        }

    

        public Task DeleteUserTestAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserTestDto>> GetAllUserTestsAsync()
        {
            var ut = await _userTestRepository.ListAllAsync();
            return _mapper.Map<IEnumerable<UserTestDto>>(ut);
           
        }

        public async Task<UserTestDto> GetUserTestByIdAsync(int id)
        {
            var ut = await _userTestRepository.GetByIdWithIncludes(id);
            return _mapper.Map<UserTestDto>(ut.Data);
        }

        public Task UpdateUserTestAsync(UserTestDto testDto)
        {
            throw new NotImplementedException();
        }
    }
}
