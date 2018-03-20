using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInformationsManager.Models
{
    public class Competition
    {
		

		public int Id { get; set; }
        public int SportId { get; set; }
        public string Location { get; set; }
        public DateTime CompetitionDate { get; set; }

		
		


	}
}
