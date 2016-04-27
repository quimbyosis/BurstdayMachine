using System;

namespace BurstdayMachine
{
	class Program
	{
		static void Main()
		{
			while (true)
			{
				Console.Write("You say it's your birthday?! (Y/N/Q(uit cuz ain't nobody got time for this)):");
				
				var myBirthday = Console.ReadLine();

				if (myBirthday.ToLower() == "y")
				{
					Console.WriteLine("HOLY CRAP! HAPPY BIRTHDAY! Are you pumped?! (Y/M(eh))");
					var amIPumped = Console.ReadLine();
					if (amIPumped.ToLower() == "y")
					{
						while (true)
						{
							Console.WriteLine("WOOOO! How pumped are you?! Type the number of woos: ");
							var woos = Console.ReadLine();
							try
							{
								var wooNumber = int.Parse(woos);
								if (wooNumber <= 0)
								{
									Console.WriteLine("Stay positive, bro.");
								}
								else
								{
									for (int i = 0; i != wooNumber; i++)
									{
										Console.WriteLine("Woo!");
									}
									break;
								}
							}
							catch (FormatException)
							{
								Console.WriteLine("Stick with the program, numbers only bro.");
								continue;
							} 
						}
					}
					else if (amIPumped.ToLower() == "m")
					{
						Console.WriteLine("B-b-b-b-but... it's your birthday! Aren't you 42? Do you know what that means?! (Y/N)");
						var meaning = Console.ReadLine();
						if (meaning.ToLower() == "y")
						{
							Console.WriteLine("That's right! It's the meaning of Life, the Universe, and everything! Good on you.");
						}
						else
						{
							Console.WriteLine("It's the meaning of Life, the Universe, and everything! At least you can be psyched about that.");
						}
					}
					else
					{
						Console.WriteLine("YES OR NO PLSKTHNX.");
					}
				}
				else if (myBirthday.ToLower() == "n")
				{
					Console.WriteLine("Don't lie.");
				}
				else if (myBirthday.ToLower() == "q")
				{
					Console.WriteLine("Later, brah.");
					break;
				}
				else
				{
					Console.WriteLine("YES, NO, OR QUIT PLSKTHNX!");
				}
			}
		}
	}
}
