using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LabProject
{
	public class RulesForName: ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			string[] words = value.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (words.Length != 3)
				return new ValidationResult(false, "Строка должна быть в формате ФИО");

			foreach(var w in words)
			{
				if (!Char.IsUpper(w[0]))
					return new ValidationResult(false, "ФИО должны начинаться с большой буквы");
			}

			return new ValidationResult(true, null);
		}
	}

	public class RulesForNumber : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			int year;
			try
			{
				year = Int32.Parse((string)value);
			}
			catch
			{
				return new ValidationResult(false, "Недопустимые символы");
			}

			return new ValidationResult(true, null);
		}
	}

	public class RulesForDate : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			DateTime date;
			try
			{
				date = DateTime.Parse(value.ToString());
			}
			catch
			{
				return new ValidationResult(false, "Дата должна быть в формате DD.MM.YY");
			}

			int days = (DateTime.Now - date).Days;
			if (days < 6574)
				return new ValidationResult(false, "Нельзя регистрировать человека моложе 18 лет");
			else
				return new ValidationResult(true, null);
		}
	}
}
