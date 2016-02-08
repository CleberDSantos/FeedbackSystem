using System;
using System.Collections.Generic;

namespace Feedback.Domain.Response
{
    public class FormResponse
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<QuestionResponse> QuestionResponses { get; set; }
        public virtual Form Form { get; set; }
    }
}
