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

				var competitions = context.Competitions.ToList();

				foreach (var c in competitions)
				{


					Console.WriteLine("Emplacement : {0}", c.Location);
					Console.WriteLine("Date : {0}", c.CompetitionDate);
					Console.WriteLine("Compétition de {0}", context.Sports.FirstOrDefault(s => s.Id == c.SportId).Name);
					Console.WriteLine();
					Console.WriteLine("Athlètes :");

					var ac = c.Athletes.ToList();

					foreach (var a in ac)
					{
						Console.WriteLine("Nom = {0} {1}", context.Athletes.FirstOrDefault(at => at.Id == a.AthleteId).FirstName, context.Athletes.FirstOrDefault(at => at.Id == a.AthleteId).LastName);
						Console.WriteLine();
					}


				}



				Console.ReadLine();
			}
		}
    }
}
