using System;

namespace NumberGuessingGame
{
	class Program
	{
		static void Main(string[] args)
		{
			//calling methode that intoduce robote
			IntroduceAlice();

			//calling methode to set random number.
			RandomNumber();
		}

		private static void RestartOrExit()
		{
			Console.WriteLine("do you want to Restart the game " +
				"enter Y and Press EnterKey\n" +
				"or to exit the game Press EnterKey");
			var Y = Console.ReadLine();
			if (Y == "y")
				RandomNumber();
		}

		private static void RandomNumber()
		{
			//create an object of rondom class
			Random random = new Random();

			//set a ramdom number in variable
			int number = random.Next(0, 101);

			//calling Gusse number methode
			GusseTheNumber(number);
		}

		/// <summary>
		/// Gusse number methode.
		/// By user
		/// </summary>
		/// <param name="rNumber"></param>
		private static void GusseTheNumber(int rn)
		{
			//set Initial value to variable.
			int UserValue = 101;

			//loop is terminate when user gusse the number.
			while (UserValue != rn)
			{
				//show the message.
				Console.WriteLine("Enter your Gusse");

				//get value from the user.
				var getValue = Console.ReadLine();

				//validation of user value
				if (Int32.TryParse(getValue, out int IsInt))
					UserValue = IsInt;
				else
					Console.WriteLine("enter valid number");

				if (UserValue > rn)
					Console.WriteLine("it is a larg value");
				else
					Console.WriteLine("it is a small value");
			}

			Console.WriteLine($"You Win,\nnumber is{UserValue}\n" +
				$"Thanks For Playing");
			RestartOrExit();
		}

		/// <summary>
		/// introduce robot it self and show rules of game.
		/// </summary>
		private static void IntroduceAlice()
		{
			var Alice = "Hi I am Alice, Let's playe a game\n";
			Console.WriteLine($"{Alice}I Though A number in between 0 to 100,\n" +
				$"you have to gusse the number.\n" +
				$"I Will provide you some hints after you enter a wrong answer\n");
		}
	}
}
