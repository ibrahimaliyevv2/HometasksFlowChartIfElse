using System;

class program4
{
public static void findSeason(int m)
{

	switch (m)
	{
		case 12:
		case 1:
		case 2:
			Console.WriteLine("WINTER");
			break;
		case 3:
		case 4:
		case 5:
			Console.WriteLine("SPRING");
			break;
		case 6:
		case 7:
		case 8:
			Console.WriteLine("SUMMER");
			break;
		case 9:
		case 10:
		case 11:
			Console.WriteLine("AUTUMN");
			break;
		default:
			Console.WriteLine("Wrong option");
			break;
	}
}


public static void Main()
{
	int m = Convert.ToInt32(Console.ReadLine());;
	Console.WriteLine("For Month number: " + m);
	findSeason(m);

}
}