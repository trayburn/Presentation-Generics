using System;
using System.Collections.Generic;

namespace Generics
{
	public class Demo6 : BaseDemo
	{
		public void Run()
		{
			Banner();

			IEnumerable<string> list = new List<string>() { "a", "b", "c", "d", "e" };
			IEnumerable<object> foo;
			// IEnumerable is Covariant (only OUTs the T)
			// This assignment is acceptable because 
			// any code which expects an object can take a string
			foo = list;
			// This assignment is NOT acceptable because
			// code which expects a string cannot take an object
			//list = foo;
		}
	}
}
