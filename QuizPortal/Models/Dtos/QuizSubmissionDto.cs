using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace QuizPortal.Models.Dtos
{
    public class QuizSubmissionDto
    {
        public int QuizId { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
}
