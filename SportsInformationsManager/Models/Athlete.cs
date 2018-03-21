using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInformationsManager.Models
{
    public class Athlete
    {
		public Athlete()
		{
			Competitions = new List<Participation>();
		}


		public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
		public DateTime Naissance { get; set; }


		public ICollection<Participation> Competitions { get; set; }


	}
}
