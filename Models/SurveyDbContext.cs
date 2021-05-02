using SurveyWebform.Models.Account_Group;
using SurveyWebform.Models.Question_Group;
using SurveyWebform.Models.Session_Group;
using System.Data.Entity;

namespace SurveyWebform.Models
{
    public partial class SurveyDbContext : DbContext
    {
        public SurveyDbContext()
            : base("name=SurveyDbContextEntityModel")
        {
        }

        #region Database Context
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QOption> QOptions { get; set; }
        public DbSet<QType> QTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Respondent> Respondents { get; set; }
        #endregion


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
