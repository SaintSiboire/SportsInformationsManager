using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Models;
using System.Data.Entity;

namespace SportsInformationsManager.Data
{
	public static class DisplayCompetitionAthletes
	{
		static void Display(int compId)
		{
			using (var context = new Context())
			{
				var compet = context.Competitions.FirstOrDefault(c => c.Id == compId);

					Console.WriteLine("Emplacement : {0}", compet.Location);
					Console.WriteLine("Date : {0}", compet.CompetitionDate );
					Console.WriteLine("Compétition de {0}", context.Sports.FirstOrDefault(s => s.Id == compet.SportId).Name);
					Console.WriteLine();
					Console.WriteLine("Athlètes :");

					var ac = compet.Athletes.ToList();

					foreach (var a in ac)
					{
						Console.WriteLine("Nom = {0} {1}", context.Athletes.FirstOrDefault(at => at.Id == a.AthleteId).FirstName, context.Athletes.FirstOrDefault(at => at.Id == a.AthleteId).LastName);
						Console.WriteLine();
					}


				



				Console.ReadLine();
			}
		}
	}
}
