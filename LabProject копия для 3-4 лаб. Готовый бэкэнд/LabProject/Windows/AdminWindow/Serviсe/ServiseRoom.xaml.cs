﻿using System;
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
    /// Логика взаимодействия для ServiseRoom.xaml
    /// </summary>
    public partial class ServiseRoom : Window
    {
		Hotel Hotel;
        public ServiseRoom()
        {
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			DataContext = Stock.MainWindowDC;
			Hotel = Stock.MainWindowDC as Hotel;
		}

		private void Add(object sender, RoutedEventArgs e)
		{
			if (Serv.Text != "")
				Hotel.IsRoom.Service.Add(Serv.Text.ToString());
			Serv.Text = "";
		}

		private void Delete(object sender, RoutedEventArgs e)
		{
			Hotel.IsRoom.Service.Remove(Hotel.Serv);
		}
	}
}
