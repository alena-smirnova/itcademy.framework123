using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itacademy.gui.Dialogs
{
	public partial class ProgressForm : Form
	{
		public ProgressForm(Progress<ProgressArgs> progress)
		{
			InitializeComponent();

			_progressBar.Style = ProgressBarStyle.Continuous;

			progress.ProgressChanged += OnProgressChanged;
		}

		private void OnProgressChanged(object sender, ProgressArgs e)
		{
			_progressBar.Value = e.Percent;
			_lblText.Text = e.Text;
		}
	}
}
