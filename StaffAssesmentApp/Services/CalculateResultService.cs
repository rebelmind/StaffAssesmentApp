using StaffAssesmentApp.Interfaces.Services;
using StaffAssessmentApp.Helpers.Enums;
using StaffAssessmentApp.Models.DTOs;

namespace StaffAssesmentApp.Services
{
    public class CalculateResultService : ICalculateResultService
    {
        private readonly IAnswerService _answerService;
        private readonly ITestService _testService;

        public CalculateResultService(IAnswerService answerService, ITestService testService)

        {
            _answerService = answerService;
            _testService = testService;
        }
        public async Task<int> CalculateScore(UserTestDto model)
        {
            int score = 0;
            var testOrigin = await _testService.GetTestByIdAsync(model.TestId);
            int countCorrectAnswers = 0;
            foreach (var question in testOrigin.Questions)
            {
                countCorrectAnswers += question.Answers.Where(a => a.IsCorrect == true).Count();
            }

            
            foreach (var question in model.Test.Questions)
            {

                var correctAnswer = _answerService.GetAllAnswers().Result;
                var ansId = correctAnswer.Where(a => a.IsCorrect == true).Select(a => a.Id).ToList(); 
           
                foreach (var id in ansId)
                {
                    if (question.SelectedAnswerIds.Count == 0 && question.AnswerText == null && question.SelectedAnswerId == id)
                    {
                        score++;
                    }
                    else if (question.SelectedAnswerIds.Count > 0 && question.AnswerText == null && question.SelectedAnswerIds.Contains(id))
                    {
                        score++;

                    }

                }


               

            }

            return (score * 100) / countCorrectAnswers;
        }

 
    }
}
