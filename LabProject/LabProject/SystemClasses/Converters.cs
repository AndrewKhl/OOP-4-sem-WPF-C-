using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LabProject
{
	public class PhotoStaff : IValueConverter
	{
		string path = @"D:\ООП 4 сем\LabProject\LabProject\Images\PhotoStaff\";
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				string s = value.ToString();
				if (s.IndexOf(path) >= 0)
					return s.Remove(s.IndexOf(path), path.Length);
				else
					return value;
			}
			else
				return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return path + value;
		}
	}

	//public class PhotoERoom : IValueConverter
	//{
	//	string path = ;
	//	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	//	{
	//		if (value != null)
	//		{
	//			string s = value.ToString();
	//			if (s.IndexOf(path) >= 0)
	//				return s.Remove(s.IndexOf(path), path.Length);
	//			else
	//				return value;
	//		}
	//		else
	//			return value;
	//	}

	//	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	//	{
	//		return path + value;
	//	}
	//}

	public class ConvertName : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string[] word = value.ToString().Split(' ');
			if (word.Length > 2)
				return word[1] + " " + word[2];
			else
				return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}
	}
}
