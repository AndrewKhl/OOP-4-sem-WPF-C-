using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	[Serializable]
	public abstract class Room
	{
		protected string image;
		protected bool status;
		protected int floor;
	}

	[Serializable]
	[System.Xml.Serialization.XmlInclude(typeof(RoomKitchen))]
	[System.Xml.Serialization.XmlInclude(typeof(SportRoomAndHoll))]
	[System.Xml.Serialization.XmlInclude(typeof(RoomRestAndBar))]
	[System.Xml.Serialization.XmlInclude(typeof(SpesRoom))]
	[System.Xml.Serialization.XmlInclude(typeof(Personal))]
	[System.Xml.Serialization.XmlInclude(typeof(ObservableCollection<string>))]
	public abstract class EntertaimentRoom: Room, IServiseRooms, IWorkingRooms, INotifyPropertyChanged
	{
		protected string comment;
		protected string work_hours;
		protected int profit;
		protected int rating;
		protected int upkeep;
		protected string name;
		public ObservableCollection<string> Service { get; set; }
		public ObservableCollection<Personal> Staff { get; set; }
		public Personal Main { get; set; }
		public bool Status { get; set; }

		public string Comment
		{
			get
			{
				return comment;
			}
			set
			{
				comment = value;
				OnPropertyChanged("Comments");
			}
		}

		public string Working_hours
		{
			get
			{
				return work_hours;
			}
			set
			{
				work_hours = value;
				OnPropertyChanged("Working_hours");
			}
		}

		public string Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				OnPropertyChanged("Image");
			}
		}

		public int Profit
		{
			get
			{
				return profit;
			}
			set
			{
				profit = value;
				OnPropertyChanged("Profit");
			}
		}

		public int Floor
		{
			get
			{
				return floor;
			}
			set
			{
				floor = value;
				OnPropertyChanged("Floor");
			}
		}

		public int Rating
		{
			get
			{
				return rating;
			}
			set
			{
				rating = value;
				OnPropertyChanged("Rating");
			}
		}

		public int Upkeep
		{
			get
			{
				return upkeep;
			}
			set
			{
				upkeep = value;
				OnPropertyChanged("Upkeep");
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				OnPropertyChanged("Name");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}

	[Serializable]
	[System.Xml.Serialization.XmlInclude(typeof(ObservableCollection<string>))]
	[System.Xml.Serialization.XmlInclude(typeof(Guest))]
	public class Apartament: Room, INotifyPropertyChanged
	{
		protected int price;
		protected int number;
		protected int capacity;
		protected new string status;
		public bool use;
		public ObservableCollection<string> Service { get; set; }
		Guest host;

		public Guest Host
		{
			get
			{
				return host;
			}
			set
			{
				host = value;
				OnPropertyChanged("Host");
			}
		}

		public int Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
				OnPropertyChanged("Price");
			}
		}

		public int Number
		{
			get
			{
				return number;
			}
			set
			{
				number = value;
				OnPropertyChanged("Number");
			}
		}

		public int Capacity
		{
			get
			{
				return capacity;
			}
			set
			{
				capacity = value;
				OnPropertyChanged("Capacity");
			}
		}

		public int Floor
		{
			get
			{
				return floor;
			}
			set
			{
				floor = value;
				OnPropertyChanged("Floor");
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set
			{
				status = value;
				OnPropertyChanged("Status");
			}
		}

		public string Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				OnPropertyChanged("Image");
			}
		}

		public Apartament(int number, int floor, string status, int price, int capacity)
		{
			Number = number;
			Floor = floor;
			Status = status;
			Price = price;
			Capacity = capacity;
			use = false;
		}

		public Apartament()
		{
			Number = 0;
			Image = "";
			Status = "";
			Floor = 0;
			Capacity = 0;
			Price = 0;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
