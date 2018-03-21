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
				var participations = context.Participations
					.ToList();



				//foreach (var participation in participations)
				//{
				var competitions = context.Competitions.ToList();

				foreach (var c in competitions)
				{
					//var sport = from s in context.Sports
					//			join comp in c 
					//			on s.Id equals c.SportId
					//			into compet
					//			select compet;

					//context.Sports.Where(s => s.Id == c.SportId);


					Console.WriteLine("Emplacement : {0}", c.Location);
					Console.WriteLine("Date : {0}", c.CompetitionDate);
					Console.WriteLine("Compétition de {0}", context.Sports.Where(s => s.Id == c.SportId).Select(s => s.Name));
					Console.WriteLine();
				}


				var athletes = context.Athletes.ToList();
				//Console.WriteLine("Athlètes participants à la compétition :");
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
