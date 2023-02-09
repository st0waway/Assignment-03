namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IBird bird = new Penguin();

			bird.Fly();
		}

		interface IBird
		{
			int LayEggs();
			void Fly();
		}

		class Hawk : IBird
		{
			public int LayEggs() { return 1; }

			public void Fly()
			{
				Console.WriteLine("Hawk flies");
			}
		}

		class Penguin : IBird
		{
			public int LayEggs() { return 1; }
			public void Fly() => throw new NotImplementedException();
		}
	}
}