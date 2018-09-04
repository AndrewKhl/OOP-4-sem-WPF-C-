using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	[Serializable]
	public abstract class Peoples
	{
		protected string name;
		protected string bithday;
		protected string comments;
		protected string photo;
	}

	[Serializable]
	public class Guest: Peoples, INotifyPropertyChanged
	{
		private int number_room;
		private string data_in;
		private string data_out;

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

		public int Number_Room
		{
			get
			{
				return number_room;
			}
			set
			{
				number_room = value;
				OnPropertyChanged("Number");
			}
		}

		public string Bithday
		{
			get
			{
				return bithday;
			}
			set
			{
				bithday = value;
				OnPropertyChanged("Bithday");
			}
		}

		public string Comments
		{
			get
			{
				return comments;
			}
			set
			{
				comments = value;
				OnPropertyChanged("Comments");
			}
		}

		public string Photo
		{
			get
			{
				return photo;
			}
			set
			{
				photo = value;
				OnPropertyChanged("Photo");
			}
		}

		public string Data_in
		{
			get
			{
				return data_in;
			}
			set
			{
				data_in = value;
				OnPropertyChanged("Data_in");
			}
		}

		public string Data_out
		{
			get
			{
				return data_out;
			}
			set
			{
				data_out = value;
				OnPropertyChanged("Data_out");
			}
		}

		public Guest(string name, int number, string date, string dout, string din, string photo, string comments)
		{
			Name = name;
			Number_Room = number;
			Bithday = date;
			Data_in = din;
			Data_out = dout;
			Photo = photo;
			Comments = comments;
		}

		public Guest()
		{
			Name = "";
			Number_Room = 0;
			Data_in = "";
			Data_out = "";
			Comments = "";
			Photo = "";
			Bithday = "";
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
