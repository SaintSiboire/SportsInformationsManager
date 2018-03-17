﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInformationsManager.Models
{
	public class Result
	{

	
		public int Id { get; set; }
		public Athlete Athlete { get; set; }
		public Competition Competition { get; set; }
		public int Position { get; set; }


	}
}
