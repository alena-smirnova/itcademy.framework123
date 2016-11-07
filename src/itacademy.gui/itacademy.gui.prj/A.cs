using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace itacademy.gui
{
	public interface ISerializableConfiguration
	{
		void Save();

		void Load();
	}

	public class ConfigurationService
	{
		public IReadOnlyList<ISerializableConfiguration> Configurations { get; }

		public ConfigurationService(IReadOnlyList<ISerializableConfiguration> configurations)
		{
			Configurations = configurations;
		}

		public void Save()
		{
			foreach(var configuration in Configurations)
			{
				configuration.Save();
			}
		}

		public void Load()
		{
			foreach(var configuration in Configurations)
			{
				configuration.Load();
			}
		}
	}

	public interface ILog
	{
		void Info(string message);

		void Error(string message, Exception exc);

		void Warning(string message);
	}

	public sealed class B
	{
		public void Method()
		{

		}
	}

	public static class Verify
	{
		public static class Argument
		{
			public static void IsNotNull<T>(T parameter, string parameterName)
			{
				if(parameter == null)
				{
					throw new ArgumentNullException(parameterName);
				}
			}
		}
	}

	/// <summary>Класс A.</summary>
	public sealed class A : IC
	{
		#region Data
		
		private double _y;

		#endregion
		
		#region .ctor

		/// <summary>Создает <see cref="A"/>.</summary>
		public A(B b)
		{
			Verify.Argument.IsNotNull(b, nameof(b));

			B = b;
			X = 5;

			B.Method();
		}

		#endregion

		#region Properties

		public B B { get; }

		public int X { get; }

		public double Y
		{
			get { return _y; }
			set
			{
				_y = value;
			}
		}

		#endregion

		#region Methods

		/// <summary>Меняет местами значения аргументов.</summary>
		/// <typeparam name="T">Тип аргументов.</typeparam>
		/// <param name="x">x</param>
		/// <param name="y">y</param>
		/// <exception cref="ArgumentException">Возникает в случает некорректных аргументов.</exception>
		public static void Swap<T>(ref T x, ref T y)
		{
			var temp = x;
			x = y;
			y = temp;
		}

		#endregion
	}
}
