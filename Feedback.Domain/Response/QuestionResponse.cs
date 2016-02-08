
namespace Feedback.Domain.Response
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int Percent { get; set; }

        public string Evidencie { get; set; }

        public Question Question { get; set; }
    }
}
