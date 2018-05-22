using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Demo1 : BaseDemo
    {
		class Sample<T>
		{
			public T Value { get; set; }
		}

		public void Run()
		{
			Banner();
			var obj1 = new Sample<int> { Value = 123 };
			var obj2 = new Sample<string> { Value = "hello" };
			Console.WriteLine(obj1.Value);
			Console.WriteLine(obj2.Value);
		}
    }
}
