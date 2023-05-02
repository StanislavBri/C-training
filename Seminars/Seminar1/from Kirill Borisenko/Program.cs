bool isWork = true;

while (isWork)
{
	Console.Write("Enter a number of task ");

	if (int.TryParse(Console.ReadLine(), out int i))
	{
		switch (i)
		{
			case 1:
			{
				int a = int.Parse(Console.ReadLine());
				int b = int.Parse(Console.ReadLine());

				if (b == Math.Sqrt(a))
				{
					Console.WriteLine("Yes");
				}
				else Console.WriteLine("No");
				break;
			}
			case 2:
			{
				int a = int.Parse(Console.ReadLine());

				switch (a)
				{
					case 1:
					{
						Console.WriteLine("Monday");
						break;
					}
					default:
						break;
				}
				break;
			}

			case -1: isWork = false; break;
		}
	}
}