using System;
namespace _05.DateModifier
{
	public class DateModifier
	{
		public static int CalculateDateDiffInDays(DateTime firstDate, DateTime secondDate)
		{
			TimeSpan reulst = firstDate - secondDate;

			return Math.Abs(reulst.Days);
		}
	}
}

