using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Services
{
	public static class Helper
	{
		public static bool EmailIsValid(string val)
		{
			string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
			Match match = Regex.Match(val.Trim(), pattern, RegexOptions.IgnoreCase);

			if (match.Success)
				return true;
			else
				return false;
		}
	}

}
