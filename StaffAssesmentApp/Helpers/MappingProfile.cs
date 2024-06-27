using AutoMapper;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
 
            CreateMap<Test, TestDto>()
                .ForMember(dest => dest.Id, opt=>opt.MapFrom(src=>src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Questions, opt => opt.MapFrom(src => src.Questions));


            CreateMap<Question, QuestionDto>()
                .ForMember(dest=>dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.QuestionText, opt => opt.MapFrom(src => src.QuestionText))
                .ForMember(dest => dest.QuestionType, opt => opt.MapFrom(src => src.QuestionType))
                .ForMember(dest => dest.Answers, opt => opt.MapFrom(src => src.Answers));


            CreateMap<Answer, AnswerDto>()
                .ForMember(dest => dest.AnswerText, opt => opt.MapFrom(src => src.AnswerText))
                .ForMember(dest => dest.IsCorrect, opt => opt.MapFrom(src => src.IsCorrect));


            CreateMap<TestDto, Test>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Questions, opt => opt.MapFrom(src => src.Questions));


            CreateMap<QuestionDto, Question>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.QuestionText, opt => opt.MapFrom(src => src.QuestionText))
                .ForMember(dest => dest.QuestionType, opt => opt.MapFrom(src => src.QuestionType))
                .ForMember(dest => dest.Answers, opt => opt.MapFrom(src => src.Answers));


            CreateMap<AnswerDto, Answer>()
                .ForMember(dest=>dest.Id, opt=>opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AnswerText, opt => opt.MapFrom(src => src.AnswerText))
                .ForMember(dest => dest.IsCorrect, opt => opt.MapFrom(src => src.IsCorrect));

            CreateMap<Test, UserTestDto>()
                .ForMember(dest => dest.TestId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Test, opt => opt.MapFrom(src => src));

            CreateMap<UserTest,UserTestDto>().ReverseMap();
                
        }

    }
}
