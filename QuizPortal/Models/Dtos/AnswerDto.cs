using Microsoft.AspNetCore.Mvc;

namespace QuizPortal.Models.Dtos
{
    public class AnswerDto
    {
        public int QuestionId { get; set; }
        public string SelectedAnswer { get; set; }
    }

}
