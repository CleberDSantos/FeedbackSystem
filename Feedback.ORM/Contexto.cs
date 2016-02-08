using Feedback.Domain;
using System.Data.Entity;
namespace Feedback.ORM
{
    public class Context : DbContext
    {

        public Context()
        : base("entityConn") 
        {

        }
     
        public DbSet<Virtue> Virtues { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Form> Forms { get; set; }

        public DbSet<QuestionForm> QuestionsForms { get; set; }
    }
}
