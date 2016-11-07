using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autofac;

namespace itacademy.gui
{
	using extentions;

	public class NModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{


			base.Load(builder);
		}
	}

	static class Program
	{
		private static IContainer CreateContainer()
		{
			var containerBuilder = new ContainerBuilder();

			containerBuilder
				.RegisterType<B>()
				.AsSelf();

			containerBuilder
				.RegisterType<A>()
				.AsSelf()
				.As<IC>();

			containerBuilder
				.RegisterModule<NModule>();

			containerBuilder.RegisterInstance<B>(new B());

			return containerBuilder.Build();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = CreateContainer();
			var c = container.Resolve<A>();

			IList<string> list = new List<string>();
			list.Add("1234");
			list.Add("54321");

			list.Print();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
