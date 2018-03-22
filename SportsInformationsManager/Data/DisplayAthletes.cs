using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Models;

namespace SportsInformationsManager.Data
{
	public static class DisplayAthletes
	{
		static Context GetContext()
		{
			var context = new Context();
			//Database.Log
			return context;
		}

		public static List<Athlete> GetAthletes()
		{
			using (Context context = GetContext())
			{
				return context.Athletes.ToList();
			}
		}
	}
}
