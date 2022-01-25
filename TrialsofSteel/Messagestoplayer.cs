using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialsofSteel
{
    public class Messagestoplayer
    {
        public static void greeting()
        {

            if (Program.gimmeConsoleoutput == true)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Messagestoplayer.greeting called\n\n");
                Console.ResetColor();
                
            }
            Console.WriteLine("Greetings new player and welcome to the Trials of Steel");
            newgameloadgame();
        }

        public static void newgameloadgame()
        {
            string gamechoice;
            int gamechoiceasint32;
            if (Program.gimmeConsoleoutput == true)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Messagestoplayer.newgameloadgame called\n\n");
                Console.ResetColor();               
            }
            Console.WriteLine("Please choose an option.   \n1. Start New Game.  \n2.Load a Saved Game (PS not working yet)");

            gamechoice = Console.ReadLine();
            gamechoiceasint32 = Convert.ToInt32(gamechoice);
            if (gamechoiceasint32 == 1) 
            {
                chooseclass();
                choosecharname();
            }

            }

        public static void chooseclass()
        {
            string classchoice;
            int classchoiceint32;
            if (Program.gimmeConsoleoutput == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Messagestoplayer.chooseclass called\n\n");
                Console.ResetColor();
            }

            Console.WriteLine("please choose your destiny \n\n 1. Way of the Blade \n 2. Way of the Shadows \n 3. Way of the Wild \n 4. Way of the Forces");
            classchoice = Console.ReadLine();
            classchoiceint32 = Convert.ToInt32(classchoice);

            if (Program.gimmeConsoleoutput == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("class choice is " + classchoice + "and classchoiceint32 is" + classchoiceint32);
                Console.ResetColor();
            }

            if (classchoiceint32 == 1)
            {
                Player.playerclass = Classpicker.classes[0];
                Console.WriteLine(" You have chosen the Way of the Blade as your destiny");
            }
            else if (classchoiceint32 == 2)
            {
                Player.playerclass = Classpicker.classes[1];
                Console.WriteLine(" You have chosen the Way of the Shadows as your destiny");
            }
            else if (classchoiceint32 == 3)
            {
                Player.playerclass = Classpicker.classes[2];
                Console.WriteLine(" You have chosen the Way of the Wilds as your destiny");
            }
            else if (classchoiceint32 == 4)
            {
                Player.playerclass = Classpicker.classes[3];
                Console.WriteLine(" You have chosen the Way of the Forces as your destiny");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            

        }

        public static void choosecharname()
        {
            string charnamechoice;
            if (Program.gimmeConsoleoutput == true)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Messagestoplayer.choosecharname called\n\n");
                Console.ResetColor();
            }
            Console.WriteLine("What is your name? Write below and press enter...");

            charnamechoice = Console.ReadLine();
            Player.playerName = charnamechoice;
            Console.WriteLine("Welcome " + Player.playerName);
        }
        //after this its repeating so need to enter the world (another codeblock or save char parameters)






    }
}             
                   
                    
                
             
           
                
             
            
        
    

