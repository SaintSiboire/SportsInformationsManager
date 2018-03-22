using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Models;
using System.Data.Entity;

namespace SportsInformationsManager.Data
{
	public static class DisplayCompetitions
	{
		static Context GetContext()
		{
			var context = new Context();
			//Database.Log
			return context;
		}
		public static List<Competition> GetCompetitions()
		{

			using (Context context = GetContext())
			{
				return context.Competitions.ToList();
			}

		}
	}
}
