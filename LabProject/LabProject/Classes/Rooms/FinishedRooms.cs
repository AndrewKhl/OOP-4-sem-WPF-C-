using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	[Serializable]
	public class RoomKitchen : EntertaimentRoom, INotifyPropertyChanged
	{
		public RoomKitchen(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
			Status = true;
		}

		public RoomKitchen()
		{
			Name = "";
			Floor = 0;
			Comment = "";
			Status = true;
		}
	}

	[Serializable]
	public class SportRoomAndHoll : EntertaimentRoom
	{
		public SportRoomAndHoll(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
			Status = true;
		}

		public SportRoomAndHoll()
		{
			Name = "";
			Floor = 0;
			Comment = "";
			Status = true;
		}
	}

	[Serializable]
	public class SpesRoom : EntertaimentRoom
	{
		public SpesRoom(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
			Status = false;
		}

		public SpesRoom()
		{
			Name = "";
			Floor = 0;
			Comment = "";
			Status = false;
		}
	}

	[Serializable]
	[System.Xml.Serialization.XmlInclude(typeof(ObservableCollection<string>))]
	public class RoomRestAndBar: EntertaimentRoom, INotifyPropertyChanged
	{
		public ObservableCollection<string> Menu { get; set; }

		public RoomRestAndBar(string name, int floor, string comment)
		{
			Name = name;
			Floor = floor;
			Comment = comment;
			Status = true;
		}

		public RoomRestAndBar()
		{
			Name = "";
			Floor = 0;
			Comment = "";
			Status = true;
		}
	}


}
