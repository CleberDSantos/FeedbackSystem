using System;
using System.Collections.Generic;

namespace Feedback.Domain
{
    public class Form
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public bool Status
        {
            get
            {
                DateTime today = DateTime.Today;
                bool result = StartDate >= today && ExpirationDate < today;

                return result;
            }
        }

        public virtual ICollection<Question> Questions {get;set;}
    }
}
