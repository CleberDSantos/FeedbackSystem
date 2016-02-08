using Feedback.Domain;
using Feedback.Domain.Response;
using Microsoft.Data.Entity;

namespace Feedback.ORM
{
    public class Context : DbContext
    {
        public DbSet<Virtue> Virtues { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Form> Forms { get; set; }

        public DbSet<FormResponse> FormResponses { get; set; }

        public DbSet<QuestionResponse> QuestionResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=feedbackdb;Trusted_Connection=True");

        }
    }
}
