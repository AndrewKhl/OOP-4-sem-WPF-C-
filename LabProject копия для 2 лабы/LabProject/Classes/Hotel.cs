using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	class Hotel: INotifyPropertyChanged
	{
		public Dictionary<string, IServiseRooms> Entertaiment_Room;
		public ObservableCollection<Room> All_Servise_Room { get; set; }
		public ObservableCollection<Apartament> Living_Rooms { get; set; }
		public ObservableCollection<Apartament> Free_Rooms { get; set; }
		public ObservableCollection<Personal> Staff { get; set; }
		public ObservableCollection<Guest> List_Guest { get; set; }
		public IServiseRooms IsRoom { get; set; }
		public Apartament IsApartament { get; set; }
		public Personal IsPerson { get; set; }
		public Guest IsHost { get; set; }
		protected Personal NewPers;
		

		public Hotel()
		{
			Entertaiment_Room = new Dictionary<string, IServiseRooms>
			{
				{"Bar", new RoomBar("Bar", 1, "Немножко подбухнуть") },
				{"Pool", new SportRoom("Pool", 2, "Ныр ныр") },
				{"Gym", new SportRoom("Gym", 2, "Ко-ко-ко") },
			};

			Living_Rooms = new ObservableCollection<Apartament>
			{
				new Apartament(101, 1, "Common", 100),
				new Apartament(102, 1, "Common", 100),
				new Apartament(201, 2, "Pre-Luxs", 300),
				new Apartament(301, 3, "Luxs", 500)
			};

			Staff = new ObservableCollection<Personal>
			{
				new Personal("Дядя Боря", 300),
				new Personal("Виктор Баринов", 1000),
				new Personal("Костя", 400)
			};

			All_Servise_Room = new ObservableCollection<Room>();
			Free_Rooms = new ObservableCollection<Apartament>();
			List_Guest = new ObservableCollection<Guest>
			{
				new Guest("White", 101)
			};

			foreach(var r in Entertaiment_Room)
			{
				All_Servise_Room.Add(r.Value as Room);
			}

			Guest newG = new Guest("Red", 301);
			List_Guest.Add(newG);
			Living_Rooms[3].Host = newG;
			Living_Rooms[3].use = true;
			ThisIsApart(301);
		}

		public void ThisIsApart(int num)
		{
			var Apart = Living_Rooms.Where(x => x.Number == num);
			Apartament[] a = Apart.ToArray();
			IsApartament = a[0];
		}

		public bool FindHost(string name,int number)
		{
			foreach(Apartament ap in Living_Rooms)
			{
				if (ap.Number == number && ap.Host.Name.ToLower() == name.ToLower())
				{
					ThisIsApart(number);
					return true;
				}
			}

			return false;
		}

		public void ViewFreeRooms()
		{
			Free_Rooms.Clear();
			var frooms = Living_Rooms.Where(x => !x.use);
			foreach (var r in frooms)
				Free_Rooms.Add(r);
		}

		public void ThisIsRoom(string str)
		{
			IsRoom = Entertaiment_Room[str];
		}

		public void NewStaff()
		{
			NewPers = new Personal();
			IsPerson = NewPers;
		}

		public void AddStaff()
		{
			Staff.Add(NewPers);
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
