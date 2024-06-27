using AutoMapper;
using StaffAssesmentApp.Interfaces.Services;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;

        private readonly IQestionRepository _qestionRepository;

        public TestService(ITestRepository testRepository, IMapper mapper, IQestionRepository qestionRepository)
        {
            _testRepository = testRepository;
            _mapper = mapper;
            _qestionRepository = qestionRepository;
                
        }
        public async Task AddTestAsync(TestDto testDto)
        {
            var test = _mapper.Map<Test>(testDto);
            await _testRepository.AddAsync(test);
        }

        public async Task DeleteTestAsync(int id)
        {
            await _testRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TestDto>> GetAllTestsAsync()
        {
            var tests = await _testRepository.ListAllAsync();
            return _mapper.Map<IEnumerable<TestDto>>(tests);
        }

        public async Task<TestDto> GetTestByIdAsync(int id)
        {
            var resultTest = await _testRepository.GetByIdWithIncludes(id);
            // TODO get all question where TestId is resultTest.Data.Id
            
            return _mapper.Map<TestDto>(resultTest.Data);
        }

        public async Task UpdateTestAsync(TestDto test)
        {
            var existingTest = await _testRepository.GetByIdWithIncludes(test.Id);
            if (existingTest == null)
            {
                throw new ArgumentException("Book not found.");
            }
            _mapper.Map(test, existingTest.Data);
            await _testRepository.UpdateAsync(existingTest.Data);
        }

        public async Task<UserTestDto> GetUserTestDtoByTest()
        {
            //TODO get and pass available Tests

            var resultTest = await _testRepository.GetByIdWithIncludes(2);
            var userTest = _mapper.Map<UserTestDto>(resultTest.Data);
            return userTest;
        }
    }
}
