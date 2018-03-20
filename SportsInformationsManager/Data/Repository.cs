using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Models;
using System.Data.Entity;
using System.Diagnostics;

namespace SportsInformationsManager.Data
{
	public class Repository
	{
		/// <summary>Private method to return database context.</summary>
		/// <return>Instance of Context class</return>
		static Context GetContext()
		{
			var context = new Context();
			context.Database.Log = (message) => Debug.WriteLine(message);
			return context;
		}

		/// <summary>Add an Athlete.</summary>
		/// <param name="athlete">Atlete entity instance to add</param>
		public static void AddAthlete(Athlete athlete)
		{
			using (Context context = GetContext())
			{
				context.Athletes.Add(athlete);
				context.SaveChanges();
			}
		}

	}
}
