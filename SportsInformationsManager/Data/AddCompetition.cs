﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Models;

namespace SportsInformationsManager.Data
{
	public static class AddCompetition
	{
		/// <summary>Private method to return database context.</summary>
		/// <return>Instance of Context class</return>
		static Context GetContext()
		{
			var context = new Context();
			//context.Database.Log = (message) => Debug.WriteLine(message);
			return context;
		}


	}
}
