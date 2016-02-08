using System.Collections.Generic;

namespace Feedback.Domain
{
    public class Virtue
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Question> Questions {get;set;}
    }
}
