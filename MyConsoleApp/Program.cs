using MyLibrary;

namespace MyConsoleApp;

internal class Program
{
	static void Main(string[] args)
	{
		MessageWriter MyWriter = new MessageWriter();
		MyWriter.Write("Hello");

		FiggleWriter FWriter = new FiggleWriter();
		FWriter.Write("Hello, figgle");
	}
}
