using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsInformationsManager.Data;
using SportsInformationsManager.Models;

namespace SportsInformationsManager
{
	public interface ICompetitions
	{
		List<Competition> GetCompetitions();
	}
}