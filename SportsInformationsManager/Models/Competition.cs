using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInformationsManager.Models
{
    public class Competition
    {
		public Competition()
		{
			Athletes = new List<Participation>();
		}
		

		public int Id { get; set; }
        public int SportId { get; set; }
        public string Location { get; set; }
        public DateTime CompetitionDate { get; set; }

		
		public ICollection<Participation> Athletes { get; set; }

		public void AddAthlete(Athlete athlete, Result result)
		{
			Athletes.Add(new Participation()
			{
				Athlete = athlete,
				Result = result
			});
		}


	}
}
