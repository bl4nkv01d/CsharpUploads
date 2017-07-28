/*
credits to barnacules nerdgasm || codegasm
(i may do my own script similiar to this in
the future)
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace MagicEightBall
{
	class MainClass
	{
		public static void Main(string[] args)
		{

            ConsoleColor oldColor = Console.ForegroundColor;

			introText();

            Random randObj = new Random();

			while (true)
			{
				string questionString = getQuestionFromUser();

				int numberOfSleepSecs = randObj.Next(5) + 1;
				Thread.Sleep(numberOfSleepSecs * 300);

				if (questionString.Length <= 1)
				{
                    Console.WriteLine("ask a question (type quit to exit)");
					continue;
				}

				if (questionString.ToLower() == "quit")
				{
					break;
				}



				int randNum = randObj.Next(7);

                Console.ForegroundColor = (ConsoleColor)randNum;

				switch (randNum)
				{
					case 0:
						{
							Console.WriteLine("YESSS");
							break;
						}
					case 1:
						{
							Console.WriteLine("no....");
							break;
						}
					case 2:
						{
							Console.WriteLine("maybe.. ;)");
							break;
						}
					case 3:
						{
							Console.WriteLine("OMG YES YES YES");
							break;
						}
					case 4:
						{
							Console.WriteLine("yea!");
							break;
						}
					case 5:
						{
							Console.WriteLine("no....");
							break;
						}
					case 6:
						{
							Console.WriteLine("of course not");
							break;
						}
				}
			}


			//Console.ForegroundColor = oldColor;
		}
		static void introText()
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Magic 8 Ball");
		}
		static string getQuestionFromUser()
		{
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string questionString = Console.ReadLine();
			return questionString;
		}
	}
}
