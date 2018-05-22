using System;

namespace Generics
{
	public class Demo4 : BaseDemo
	{
		public interface IEchoThings<T>
		{
			T Echo(T obj);
		}
		public class InvariantSample<T> : IEchoThings<T>
		{
			public T Echo(T obj) => obj;
		}
		public void Run()
		{
			Banner();

			InvariantSample<object> foo;
			InvariantSample<string> bar = new InvariantSample<string>();
			//foo = bar;
		}
	}
}
