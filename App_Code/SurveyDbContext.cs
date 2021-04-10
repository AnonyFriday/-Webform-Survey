using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SurveyWebform.App_Code
{
    public partial class SurveyDbContext : DbContext
    {
        public SurveyDbContext()
            : base("name=SurveyDbContextEntityModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
