using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itacademy.gui.Dialogs
{
	public static class TestAsyncProgressMethods
	{
		public static async Task TestProgress(IProgress<ProgressArgs> progress)
		{
			for(var i = 1; i <= 100; i++)
			{
				await Task.Delay(1000);

				progress.Report(new ProgressArgs() { Text = $@"Text: {i}", Percent = i });
			}
		}
	}
}
