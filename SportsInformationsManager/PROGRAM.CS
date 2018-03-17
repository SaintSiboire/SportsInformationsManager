using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Data;
using SportsInformationsManager.Models;
using System.Data.Entity;

namespace SportsInformationsManager
{
    class Program
    {
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				var competitions = context.Competitions
					.Include(c => c.Sport)
					.ToList();

				foreach(var competition in competitions)
				{
					var lieu = competition.Place;
					var sport = competition.Sport.Name;
					var date = competition.CompetitionDate;

					Console.WriteLine("Emplacement : {0}", lieu);
					Console.WriteLine("Date : {0}", date);
					Console.WriteLine("Compétition de {0}", sport);
					Console.WriteLine();

				}

				IList<Athlete> participants = context.Athletes.OrderBy(a => a.FirstName)
					.ThenBy(a => a.LastName).ToList();

				foreach(Athlete a in participants)
				{
					Console.WriteLine("Name = {0} {1}", a.FirstName, a.LastName);
					Console.WriteLine();
				}

				
				
				

				Console.ReadLine();
			}
		}
    }
}
