using System;
using System.Collections.Generic;

namespace Generics
{
	public class Demo3 : BaseDemo
	{
		public class Sample<T>
		{
			public static T Index { get; set; }
		}

		public void Run()
		{
			Banner();

			Sample<int>.Index = 123;
			Sample<string>.Index = "hello world";

			Console.WriteLine(Sample<int>.Index);
			Console.WriteLine(Sample<string>.Index);
		}
	}
}
