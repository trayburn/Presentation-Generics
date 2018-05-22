using System;

namespace Generics
{
	public class BaseDemo
	{
		public void Banner()
		{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("-------------------------------------");
		}
	}
}
