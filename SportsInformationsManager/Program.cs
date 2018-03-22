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
					Console.WriteLine("Participants:");
					Console.WriteLine();

					var at = c.Athletes.ToList();

					foreach(var i in at)
					{
						
						Console.WriteLine("Nom : {0} {1}",context.Athletes.FirstOrDefault(a => a.Id == i.AthleteId).FirstName,
														  context.Athletes.FirstOrDefault(a => a.Id == i.AthleteId).LastName);
						Console.WriteLine();
					}

				}

				var athletes = context.Athletes.ToList();

				Console.WriteLine("Tous les athlètes");
				Console.WriteLine();

				foreach (var a in athletes)
				{
					

					Console.WriteLine("Nom : {0} {1}", a.FirstName, a.LastName);
					Console.WriteLine("Date de naissance : {0}", a.Naissance);
					Console.WriteLine();
				}

				Console.ReadLine();
			}
		}
    }
}
