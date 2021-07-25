using Nancy;
using System;

public class Class1 : NancyModule
{
		public Class1()
		{
			Get = _ => "Hello World!";
		}
}
