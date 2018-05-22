using System;
using System.Collections.Generic;

namespace Generics
{
	public class Demo5 : BaseDemo
	{
		public class ContravariantComparer<T> : IComparer<T>
		{
			public int Compare(T x, T y)
			{
				if (x.GetHashCode() == y.GetHashCode()) return 0;
				else if (x.GetHashCode() > y.GetHashCode())
					return 1;
				else
					return -1;
			}
		}

		public void Run()
		{
			Banner();

			SortedSet<string> set = new SortedSet<string>(new ContravariantComparer<object>())
			{
				"a", "b", "c", "d"
			};



			foreach (var x in set)
			{
				Console.WriteLine(x);
			}
		}
	}
}
