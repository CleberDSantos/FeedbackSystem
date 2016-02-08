namespace Feedback.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public int VirtueId { get; set; }
        public int FormId { get; set; }

        public virtual Virtue Virtue { get; set; }
        public virtual Form Form { get; set; }
    }
}
