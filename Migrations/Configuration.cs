﻿namespace SurveyWebform.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SurveyWebform.Models.SurveyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SurveyWebform.Models.SurveyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
