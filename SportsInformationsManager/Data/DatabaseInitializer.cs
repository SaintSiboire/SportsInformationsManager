using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SportsInformationsManager.Models;

namespace SportsInformationsManager.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

			


			var athlete1 = new Athlete()
            {
                FirstName = "Bob",
                LastName = "Marley",               
            };
			context.Athletes.Add(athlete1);
			

            var athlete2 = new Athlete()
            {
                FirstName = "Jacques",
                LastName = "Plante",
            };
			context.Athletes.Add(athlete2);

			var athlete3 = new Athlete()
            {
                FirstName = "Yves",
                LastName = "Morissette",
            };
			context.Athletes.Add(athlete3);

			var athlete4 = new Athlete()
			{
				FirstName = "Elvis",
				LastName = "Presley",
			};
			context.Athletes.Add(athlete4);

			var athlete5 = new Athlete()
			{
				FirstName = "Chuck",
				LastName = "Noris",
			};
			context.Athletes.Add(athlete5);

			var sport1 = new Sport()
			{
				Name = "Athlétisme",
			};
			context.Sports.Add(sport1);
			

			var sport2 = new Sport()
			{
				Name = "Lutte",
			};
			context.Sports.Add(sport2);



			var competition1 = new Competition()
            {
                Location = "Stade Athlétisme",
                SportId = 1,				
                CompetitionDate = new DateTime(2018,3,1)
            };
			context.Competitions.Add(competition1);

			var competition2 = new Competition()
			{
				Location = "Amphithéatre",
				SportId = 2,
				CompetitionDate = new DateTime(2018,3,1)
			};
			context.Competitions.Add(competition2);

			var result1 = new Result()
			{
				Position = 1
			};
			context.Results.Add(result1);

			var result2 = new Result()
			{
				Position = 2
			};
			context.Results.Add(result2);

			var result3 = new Result()
			{
				Position = 3
			};
			context.Results.Add(result3);



			context.SaveChanges();
        }
    }
}
