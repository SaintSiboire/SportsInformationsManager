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
        public Sport Sport { get; set; }
        public string Place { get; set; }
        public DateTime CompetitionDate { get; set; }

		

        
    }
}
