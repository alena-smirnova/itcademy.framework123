using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itacademy.gui.extentions
{
	public static class Extentions
	{
		public static void Print(this IEnumerable list)
		{
			if(list == null)
			{
				throw new ArgumentNullException(nameof(list));
			}

			foreach(var item in list)
			{
				Debug.WriteLine(item);
			}
		}
	}
}
