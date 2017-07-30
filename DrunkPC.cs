using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
//
// Drunk PC
// applications that generates
// random mouse and keyboard
// inputs 
// threads
// system windows forms namespace & assembly
// hidden app

namespace DrunkPC
{
    class MainClass
    {
        public static Random _random = new Random();

        /// <summary>
        /// enter point for prank app
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Drunk Pc by Tim ;)");

            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyBoardThread = new Thread(new ThreadStart(DrunkKeyboadThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThread = new Thread(new ThreadStart(DrunkPopupThread));

			DateTime future = DateTime.Now.AddSeconds(10);
            Console.WriteLine("5secs");
			while (future > DateTime.Now)
			{
				Thread.Sleep(5000);
			}

            //start all threads
            drunkMouseThread.Start();
            drunkKeyBoardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThread.Start();

            future = DateTime.Now.AddSeconds(10);
            while (future > DateTime.Now)
            {
                Thread.Sleep(90000);
            }
            Console.WriteLine("exiting");

            drunkMouseThread.Abort();
            drunkKeyBoardThread.Abort();
            drunkSoundThread.Abort();
            drunkPopupThread.Abort();
        }

        #region Thread Functions 
        //random mouse movements
        public static void DrunkMouseThread()
        {
            //Console.WriteLine("mouse");

            int moveX;
            int moveY;

			while (true)
            {
                Console.WriteLine(Cursor.Position.ToString());
                moveX = _random.Next(60) - 14;
                moveY = _random.Next(60) - 14;
                Cursor.Position = new System.Drawing.Point
                    (Cursor.Position.X + moveX, Cursor.Position.Y + moveY);

                Thread.Sleep(700);
            }
        }
        //drunk keyboard thread
        public static void DrunkKeyboadThread()
        {
			//Console.WriteLine("keyboard");
			while (true)
            {
                Char key = (char)(_random.Next(26) + 65);

                if(_random.Next(2) == 0)
                {
                    key = char.ToLower(key);
                }
                SendKeys.SendWait(key.ToString());
                Thread.Sleep(_random.Next(1000));
            }
        }
        //random noises
        public static void DrunkSoundThread()
        {
			//Console.WriteLine("sound");
			while (true)
            {
                if(_random.Next(100) > 50)
                {
                    switch(_random.Next(5))
                    {
                        case 0:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 1:
                            SystemSounds.Beep.Play();
                            break;
                        case 2:
                            SystemSounds.Exclamation.Play();
                            break;
						case 3:
                            SystemSounds.Question.Play();
							break;
						case 4:
                            SystemSounds.Hand.Play();
							break;
                    }

                    SystemSounds.Asterisk.Play();
                }

                Thread.Sleep(200);
            }
        }
        //random pop ups
        public static void DrunkPopupThread()
        {
			//Console.WriteLine("popup");
			while (true)
            {
                if (_random.Next(100) > 60)
                {
                    switch (_random.Next(2))
                    {
                        case 0:
							MessageBox.Show("Internet Explorer has stopped working",
				   "Internet Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            case 1:
                            MessageBox.Show("Your system is out of date",
                                            "Microsoft Windows 10", MessageBoxButtons.OK
                                            , MessageBoxIcon.Warning);

                            break;
                    }

                    
                }

                Thread.Sleep(10000);
            }
        }
        #endregion 
        //end
    }
}
