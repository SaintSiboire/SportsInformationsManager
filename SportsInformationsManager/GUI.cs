using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsInformationsManager
{
	public partial class GUI : Form
	{
		public GUI()
		{
			InitializeComponent();
		}

		public Data.AddCompetition AddCompetition
		{
			get => default(Data.AddCompetition);
			set
			{
			}
		}
	}
}
