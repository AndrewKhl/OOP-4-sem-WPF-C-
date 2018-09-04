using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace LabProject
{
	class Hotel: INotifyPropertyChanged
	{
		public Dictionary<string, EntertaimentRoom> Entertaiment_Room;
		public ObservableCollection<EntertaimentRoom> All_Servise_Room { get; set; }
		public ObservableCollection<Apartament> Living_Rooms { get; set; }
		public ObservableCollection<Apartament> Free_Rooms { get; set; }
		public ObservableCollection<Personal> Staff { get; set; }
		public ObservableCollection<Guest> List_Of_Order { get; set; }
		public ObservableCollection<Guest> List_Guest { get; set; }
		public EntertaimentRoom IsRoom { get; set; }
		public Apartament IsApartament { get; set; }
		public Apartament IsFreeApart { get; set; }
		public Personal IsPerson { get; set; }
		public Personal Delete { get; set; }
		public Guest IsHost { get; set; }
		public Guest NewHost { get; set; }
		public RoomRestAndBar IsEat { get; set; }
		public string Serv { get; set; }
		public string Dish { get; set; }
		protected Personal NewPers;


		public Hotel()
		{
			List_Of_Order = new ObservableCollection<Guest>();
			List_Guest = new ObservableCollection<Guest>();
			All_Servise_Room = new ObservableCollection<EntertaimentRoom>();
			Free_Rooms = new ObservableCollection<Apartament>();
			Entertaiment_Room = new Dictionary<string, EntertaimentRoom>();
			Living_Rooms = new ObservableCollection<Apartament>();
			Staff = new ObservableCollection<Personal>();
			LoadFiles();
		}

		~Hotel()
		{
			MessageBox.Show("Все изменения сохранены!");
			SaveFile();
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
				if(ap.Host != null)
				{
					if (ap.Number == number && ap.Host.Name.ToLower() == name.ToLower())
					{
						ThisIsApart(number);
						return true;
					}
				}

			return false;
		}

		public void ChooseGuest()
		{
			List_Guest.Clear();
			foreach(var r in Living_Rooms)
			{
				if (r.use)
				{
					List_Guest.Add(r.Host);
				}
			}
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

		public void GoInEating()
		{
			IsEat = IsRoom as RoomRestAndBar;
		}

		public void AddDish(string dish)
		{
			(IsRoom as RoomRestAndBar).Menu.Add(dish);
		}

		public void DeleteDish()
		{
			(IsRoom as RoomRestAndBar).Menu.Remove(Dish);
		}

		public void ClearMain(string job)
		{
			for (int i = 0; i < Staff.Count; ++i)
				if (Staff[i].Job == job && Staff[i].IsMain == true)
				{
					Staff[i].IsMain = false;
					break;
				}
		}

		public void DismissStaff()
		{
			if (IsPerson.IsMain == true)
			{
				Entertaiment_Room[IsPerson.Job].Main = null;
			}
			Staff.Remove(IsPerson);
			IsPerson = null;
		}

		public void FindFreeRooms(string st, string ed)
		{
			Free_Rooms.Clear();
			foreach(var r in Living_Rooms)
			{
				Free_Rooms.Add(r);
			}

			DateTime start = DateTime.Parse(st);
			DateTime end = DateTime.Parse(ed);
			foreach (var r in List_Of_Order)
			{
				DateTime In = DateTime.Parse(r.Data_in);
				DateTime Out = DateTime.Parse(r.Data_out);
				if ((start.Date >= In.Date && start.Date < Out.Date) || (end.Date > In.Date && end.Date < Out.Date))
				{
					int num = r.Number_Room;
					for (int i = 0; i < Free_Rooms.Count; ++i)
						if (Free_Rooms[i].Number == num)
						{
							try
							{
								Free_Rooms.Remove(Free_Rooms[i]);
							}
							catch { }
							break;
						}
				}
			}
		}

		protected void ClearListLivingRoom()
		{
			string s = DateTime.Now.ToShortDateString();
			for (int i = 0; i < Living_Rooms.Count; ++i)
			if (Living_Rooms[i].Host != null)
				{
					DateTime end = DateTime.Parse(Living_Rooms[i].Host.Data_out);
					if (DateTime.Now.Date >= end.Date)
					{
						Living_Rooms[i].Host = null;
						Living_Rooms[i].use = false;
					}
				}
		}

		protected void AddListLiving()
		{
			foreach (var p in List_Of_Order)
			{
				DateTime start = DateTime.Parse(p.Data_in);
				DateTime end = DateTime.Parse(p.Data_out);

				if (start.Date <= DateTime.Now.Date && DateTime.Now.Date < end.Date)
				{
					int num = p.Number_Room;
					for (int i = 0; i < Living_Rooms.Count; ++i)
						if (Living_Rooms[i].Number == num)
						{
							Living_Rooms[i].Host = p;
							Living_Rooms[i].use = true;
							break;
						}
				}
			}
		}

		public void AddNewHost()
		{
			NewHost = new Guest();
		}

		public void DeleteHost()
		{
			
			foreach (var r in Living_Rooms)
			{
				if (IsHost.Number_Room == r.Number)
				{
					r.use = false;
					r.Host = null;
					break;
				}
			}
			IsHost = null;
			try
			{
				List_Of_Order.Remove(IsHost);
				List_Guest.Remove(IsHost);
			}
			catch { }
		}

		public void LeaveHost()
		{
			
			foreach (var r in Living_Rooms)
			{
				if (IsHost.Number_Room == r.Number)
				{
					r.use = false;
					r.Host = null;
					break;
				}
			}
			foreach (var h in List_Of_Order)
			{
				if (Equals(h, IsHost))
				{
					h.Data_in = "00.00.0000";
					h.Data_out = "00.00.0000";
					break;
				}
			}
			List_Guest.Remove(IsHost);
			IsHost = null;
		}

		public void CreateNewGuest(string din, string dout)
		{
			NewHost.Number_Room = IsFreeApart.Number;
			NewHost.Data_in = din;
			NewHost.Data_out = dout;
			List_Of_Order.Add(NewHost);
			DateTime start = DateTime.Parse(din);
			if (DateTime.Now.Date >= start)
			{
				IsFreeApart.Host = NewHost;
				IsFreeApart.use = true;
			}
			AddNewHost();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

		public void LoadFiles()
		{
			string path = @"D:\ООП 4 сем\LabProject\LabProject\Files\";
			XmlSerializer formForERoom = new XmlSerializer(typeof(EntertaimentRoom[]));
			XmlSerializer formForLRoom = new XmlSerializer(typeof(Apartament[]));
			XmlSerializer formForStaff = new XmlSerializer(typeof(Personal[]));
			XmlSerializer formForGuest = new XmlSerializer(typeof(Guest[]));

			using (FileStream fs = new FileStream(path + "Staff.xml", FileMode.OpenOrCreate))
			{
				Personal[] MyStaff = (Personal[])formForStaff.Deserialize(fs);

				Staff.Clear();
				foreach (var p in MyStaff)
				{
					Staff.Add(p);
				}
			}

			using (FileStream fs = new FileStream(path + "Guest.xml", FileMode.OpenOrCreate))
			{
				Guest[] MyGuest = (Guest[])formForGuest.Deserialize(fs);

				List_Of_Order.Clear();
				foreach (var p in MyGuest)
				{
					List_Of_Order.Add(p);
				}
			}

			using (FileStream fs = new FileStream(path + "ERoom.xml", FileMode.OpenOrCreate))
			{
				EntertaimentRoom[] MyERoom = (EntertaimentRoom[])formForERoom.Deserialize(fs);

				All_Servise_Room.Clear();
				Entertaiment_Room.Clear();
				foreach (var p in MyERoom)
				{
					All_Servise_Room.Add(p);
					Entertaiment_Room.Add(p.Name, p);
				}
			}
			using (FileStream fs = new FileStream(path + "LRoom.xml", FileMode.OpenOrCreate))
			{
				Apartament[] MyLRoom = (Apartament[])formForLRoom.Deserialize(fs);

				Living_Rooms.Clear();
				foreach (var p in MyLRoom)
				{
					Living_Rooms.Add(p);
				}

				ClearListLivingRoom();
				AddListLiving();
			}
		}

		public void SaveFile()
		{
			string path = @"D:\ООП 4 сем\LabProject\LabProject\Files\";
			XmlSerializer formForERoom = new XmlSerializer(typeof(EntertaimentRoom[]));
			XmlSerializer formForLRoom = new XmlSerializer(typeof(Apartament[]));
			XmlSerializer formForStaff = new XmlSerializer(typeof(Personal[]));
			XmlSerializer formForGuest = new XmlSerializer(typeof(Guest[]));

			DirectoryInfo dirInfo = new DirectoryInfo(path);

			foreach (FileInfo file in dirInfo.GetFiles())
			{
				file.Delete();
			}
		

			using (FileStream fs = new FileStream(path + "ERoom.xml", FileMode.OpenOrCreate))
			{
				formForERoom.Serialize(fs, All_Servise_Room.ToArray());
			}

			using (FileStream fs = new FileStream(path + "LRoom.xml", FileMode.OpenOrCreate))
			{
				formForLRoom.Serialize(fs, Living_Rooms.ToArray());
			}

			using (FileStream fs = new FileStream(path + "Staff.xml", FileMode.OpenOrCreate))
			{
				formForStaff.Serialize(fs, Staff.ToArray());
			}

			using (FileStream fs = new FileStream(path + "Guest.xml", FileMode.OpenOrCreate))
			{
				formForGuest.Serialize(fs, List_Of_Order.ToArray());
			}

		}
	}
}
