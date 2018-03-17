using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInformationsManager.Models
{
    public class Participation
    {
        public int Id { get; set; }
        public int AthleteId { get; set; }


        public Athlete Athlete { get; set; }



    }
}
