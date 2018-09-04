using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabProject
{
	/// <summary>
	/// Логика взаимодействия для AddNewHost.xaml
	/// </summary>
	public partial class AddNewHost : Window
	{
		Hotel Hotel;
		public AddNewHost()
		{
			InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
			Hotel = Stock.MainWindowDC as Hotel;
			Hotel.AddNewHost();
		}

		private void InfoAboutApartment(object sender, RoutedEventArgs e)
		{
			if ((Stock.MainWindowDC as Hotel).IsApartament != null)
			{
				ApartInfo Apr = new ApartInfo(1);
				Apr.Show();
			}
		}

		private void Find(object sender, RoutedEventArgs e)
		{
			if (StartDate.Text == "" || EndDate.Text == "")
			{
				MessageBox.Show("Пожалуста, введите даты регистрации!");
			}
			else
			{
				DateTime start = DateTime.Parse(StartDate.Text);
				DateTime end = DateTime.Parse(EndDate.Text);
				if (start.Date > end.Date)
				{
					MessageBox.Show("Первая дата не может быть больше!");
				}
				else
				{
					if (DateTime.Now.Date > start.Date)
					{
						MessageBox.Show("Данная дата уже прошла!");
					}
					else
						Hotel.FindFreeRooms(StartDate.Text, EndDate.Text);
				}			
			}
		}

		private void AddNewGuest(object sender, RoutedEventArgs e)
		{
			DateTime start = DateTime.Parse(StartDate.Text.ToString());
			DateTime end = DateTime.Parse(EndDate.Text.ToString());
			if (start.Date > end.Date)
			{
				MessageBox.Show("Первая дата не может быть больше!");
			}
			else
			{
				try
				{
					TimeSpan time = end - start;
					int money = time.Days * Hotel.IsFreeApart.Price;
					Hotel.CreateNewGuest(StartDate.Text, EndDate.Text);
					MessageBox.Show("Клиент успешно добавлен!\nК оплате " + money.ToString() + "$");
					Hotel.FindFreeRooms(StartDate.Text, EndDate.Text);
					Name.Text = "";
					Comments.Text = "";
					Photo.Text = "";
					Date.Text = "";
				}
				catch
				{
					MessageBox.Show("Ошибка добавления!");
				}
			}		
		}
	}
}
