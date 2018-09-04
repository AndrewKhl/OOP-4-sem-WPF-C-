using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
	class Personal : Peoples, INotifyPropertyChanged
	{

		protected string job;
		protected int salary;

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

		public string Job
		{
			get
			{
				return job;
			}
			set
			{
				job = value;
				OnPropertyChanged("Job");
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

		public int Salary
		{
			get
			{
				return salary;
			}
			set
			{
				salary = value;
				OnPropertyChanged("Salary");
			}
		}

		public Personal(string name, int salary)
		{
			Name = name;
			Salary = salary;
		}

		public Personal()
		{
			Name = "";
			Bithday = "";
			Photo = "";
			Salary = 0;
			Comments = "";
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
