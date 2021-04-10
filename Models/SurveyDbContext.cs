using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using SurveyWebform.Models.Account_Group;
using SurveyWebform.Models.Question_Group;
using SurveyWebform.Models.Session_Group;

namespace SurveyWebform.Models
{
    public partial class SurveyDbContext : DbContext
    {
        public SurveyDbContext()
            : base("name=SurveyDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
