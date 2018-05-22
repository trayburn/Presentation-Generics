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
		}

		public void Run()
		{
			Banner();

			Sample<int>.Index = 100;
			Console.WriteLine(Sample<string>.Index);
		}
    }
}
