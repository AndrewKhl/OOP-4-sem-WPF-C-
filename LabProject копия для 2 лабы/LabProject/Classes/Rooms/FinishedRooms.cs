using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	class RoomBar : EntertaimentRoom, INotifyPropertyChanged
	{
		protected string[] menu;

		public string[] Menu
		{
			get
			{
				return menu;
			}
			set
			{
				menu = value;
				OnPropertyChanged("Menu");
			}
		}

		public RoomBar(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
		}
	}

	class SportRoom: EntertaimentRoom
	{
		public SportRoom(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
		}
	}
	

}
