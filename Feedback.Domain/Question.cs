namespace Feedback.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public int IdVirtue { get; set; }
        public virtual Virtue Virtue { get; set; }
    }
}
