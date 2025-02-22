using Assessment.Application.Common.Mappings;
using Assessment.Domain.Entities;

namespace Assessment.Application.Questions.Commands.UpdateQuestion;

public class UpdateQuestionVm : IMapFrom<Question>
{
    public int Id { get; set; }
    public int CategoryId { get; init; }
    public string QuestionText { get; set; }
    public string Answer { get; set; }
}