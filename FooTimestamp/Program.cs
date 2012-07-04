using System;
using System.Collections.Generic;
using System.Linq;

namespace FooTimestamp
{
	public class Foo
	{
		public DateTime Timestamp { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Foo> foos = new List<Foo>() { new Foo() { Timestamp = new DateTime(2012, 7, 1) } };
			var maxTimestamp = foos.Any() ? foos.Max(x => x.Timestamp) : new DateTime(2012, 7, 2);
		} // put a breakpoint here
	}
}
