using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsInformationsManager.Data;

namespace SportsInformationsManager.Models
{
	public class Participation
	{

		public int Id { get; set; }
		public int AthleteId { get; set; }
		public int CompetitionId { get; set; }
		public int ResultId { get; set; }

		public Athlete Athlete { get; set; }
		public Competition Competition { get; set; }
		public Result Result { get; set; }

	}
}
