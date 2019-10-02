using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Warrior mooving game****");
            Console.WriteLine("Enter 'W/w' or 'S/s' or 'A/a' or 'D/d' to move\n");
            do
            {
                Console.WriteLine("Your direction is?");
                Move(ReadAnswerFromUser());
                Console.WriteLine("One more step? Type 'y' to continue...");
            }
            while (IsMovingNext(ReadAnswerFromUser()));            
        }

        
        /// <summary>
        /// Move the character.
        /// </summary>
        /// <param name="inputedCharacter">Direction char code such as 'W'/'w' 'S'/'s' 'A'/'a' and 'D'/'d'.</param>
        static void Move(char inputedCharacter)
        {
            inputedCharacter = Char.ToLower(inputedCharacter);
            switch (inputedCharacter)
            {
                case 'w':
                    Console.WriteLine("-I'm moving UP!");
                    break;
                case 's':
                    Console.WriteLine("-I'm moving DOWN!");
                    break;
                case 'a':
                    Console.WriteLine("-I'm moving LEFT!");
                    break;
                case 'd':
                    Console.WriteLine("-I'm moving RIGHT!");
                    break;
                default:
                    Console.WriteLine("-You type wrong command to the person.\nNext time he'll come to you and show you what to do >_<");
                    break;
            }
        }

        /// <summary>
        /// Ask user: is moving next?
        /// </summary>
        /// <param name="inputedCharacter"></param>
        /// <returns>Return boolean result of the response.</returns>
        static bool IsMovingNext(char inputedCharacter)
        {
            if (Char.ToLower(inputedCharacter) == 'y')
            {
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Game is over. Press any key to close");
                Console.ReadKey();
                return false;
            }
        }

        /// <summary>
        /// Reads user entered char.
        /// </summary>
        /// <returns>Return a char.</returns>
        static char ReadAnswerFromUser()
        {
            Console.Write("Your answer is:");
            try
            {
                return char.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return ReadAnswerFromUser();
            }
        }
    }
}
