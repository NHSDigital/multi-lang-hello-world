using NUnit.Framework;

namespace ConsoleApplication1
{
	public class Program
	{
		static void Main(string[] args)
		{
		}
	}

	public class HelloWorld
	{
		public string Foo()
		{
			return "Hello World";
		}
	}

	[TestFixture]
	public class HelloWorldTests
	{
		[Test]
		public void Test1()
		{
			var helloWorld = new HelloWorld();

			var expectedResult = "Hello World";

			Assert.That(helloWorld.Foo(), Is.EqualTo(expectedResult));
		}
	}
}
