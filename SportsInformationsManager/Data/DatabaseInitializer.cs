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

			var result1 = new Result()
			{
				Rank = 1
			};
			context.Results.Add(result1);

			var result2 = new Result()
			{
				Rank = 2
			};
			context.Results.Add(result2);

			var result3 = new Result()
			{
				Rank = 3
			};
			context.Results.Add(result3);

			var result4 = new Result()
			{
				Rank = 4
			};
			context.Results.Add(result4);

			var result5 = new Result()
			{
				Rank = 5
			};
			context.Results.Add(result5);

			var result6 = new Result()
			{
				Rank = 6
			};
			context.Results.Add(result6);


			var athlete1 = new Athlete()
            {
                FirstName = "Bob",
                LastName = "Marley",
				Naissance = new DateTime(1990,02,01)
            };
			context.Athletes.Add(athlete1);
			

            var athlete2 = new Athlete()
            {
                FirstName = "Jacques",
                LastName = "Plante",
				Naissance = new DateTime(1990, 02, 01)
			};
			context.Athletes.Add(athlete2);

			var athlete3 = new Athlete()
            {
                FirstName = "Yves",
                LastName = "Morissette",
				Naissance = new DateTime(1990, 02, 01)
			};
			context.Athletes.Add(athlete3);

			var athlete4 = new Athlete()
			{
				FirstName = "Elvis",
				LastName = "Presley",
				Naissance = new DateTime(1990, 02, 01)
			};
			context.Athletes.Add(athlete4);

			var athlete5 = new Athlete()
			{
				FirstName = "Chuck",
				LastName = "Noris",
				Naissance = new DateTime(1990, 02, 01)
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
			competition1.AddAthlete(athlete4, result1);
			competition1.AddAthlete(athlete1, result2);
			competition1.AddAthlete(athlete5, result3);
			competition1.AddAthlete(athlete2, result4);
			context.Competitions.Add(competition1);

			var competition2 = new Competition()
			{
				Location = "Amphithéatre",
				SportId = 2,
				CompetitionDate = new DateTime(2018,3,1)
			};
			competition2.AddAthlete(athlete5, result1);
			competition2.AddAthlete(athlete3, result2);
			competition2.AddAthlete(athlete1, result3);
			competition2.AddAthlete(athlete2, result4);
			context.Competitions.Add(competition2);

			



			context.SaveChanges();
        }
    }
}
