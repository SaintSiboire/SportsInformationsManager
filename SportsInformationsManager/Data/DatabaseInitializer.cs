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
			

            var athlete2 = new Athlete()
            {
                FirstName = "Jacques",
                LastName = "Plante",
            };

            var athlete3 = new Athlete()
            {
                FirstName = "Yves",
                LastName = "Morissette",
            };

			var athlete4 = new Athlete()
			{
				FirstName = "Elvis",
				LastName = "Presley",
			};

			var athlete5 = new Athlete()
			{
				FirstName = "Chuck",
				LastName = "Noris",
			};

			var sport1 = new Sport()
			{
				Name = "Athlétisme",
			};
			sport1.AddAthlete(athlete1);
			sport1.AddAthlete(athlete2);
			sport1.AddAthlete(athlete3);

			var sport2 = new Sport()
			{
				Name = "Lutte",
			};
			sport2.AddAthlete(athlete4);
			sport2.AddAthlete(athlete5);


			var competition1 = new Competition()
            {
                Place = "Stade Athlétisme",
                Sport = sport1,				
                CompetitionDate = new DateTime(2018,3,1)
            };
			context.Competitions.Add(competition1);

			var competition2 = new Competition()
			{
				Place = "Amphithéatre",
				Sport = sport2,
				CompetitionDate = new DateTime(2018,3,1)
			};
			context.Competitions.Add(competition2);

			var result1 = new Result()
			{
				Athlete = athlete1,
				Competition = competition1,
				Position = 1
			};
			context.Results.Add(result1);

			var result2 = new Result()
			{
				Athlete = athlete2,
				Competition = competition1,
				Position = 2
			};
			context.Results.Add(result2);

			var result3 = new Result()
			{
				Athlete = athlete3,
				Competition = competition1,
				Position = 3
			};
			context.Results.Add(result3);



			context.SaveChanges();
        }
    }
}
