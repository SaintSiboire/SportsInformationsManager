using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SportsInformationsManager.Models;

namespace SportsInformationsManager.Data
{
    public class Context : DbContext
    {
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
		public DbSet<Result> Results { get; set; }
		public DbSet<Participation> Participations { get; set; }

        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
