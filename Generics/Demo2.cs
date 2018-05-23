using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Demo2 : BaseDemo
    {
		public class Sample<T>
		{
			public static int Index { get; set; }
			public static T Value { get; set; }
		}

		public void Run()
		{
			Banner();

			Sample<int>.Index = 100;
			Sample<int>.Value = 123;
			Console.WriteLine(Sample<int>.Index);
			Console.WriteLine(Sample<int>.Value);
			Console.WriteLine(Sample<string>.Index);
			Console.WriteLine(Sample<string>.Value);
		}
    }
}
