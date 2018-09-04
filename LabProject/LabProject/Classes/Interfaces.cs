using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	interface IWorkingRooms
	{
		//List<Person> Staff { get; set; }
		int Upkeep { get; set; }
		string Name { get; set; }
	}

	interface IServiseRooms
	{
		string Comment { get; set; }
		string Working_hours { get; set; }
		Personal Main { get; set; }
		int Profit { get; set; }
		int Rating { get; set; }
		string Name { get; set; }
	}
}
