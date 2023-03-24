using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Sami_Lahham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome To My Game!");
            Console.WriteLine("Its hard (BE READY)!");
            char[] lines = { '_', '_', '_', '_' };

            print_lines(lines);

            bool win = false;
            string tw = getTodayWord();
            int heart = tw.Length;
            while (heart > 0) {
                Console.WriteLine(" ");
                char c = askUser();
                int result = checkletter(tw, c, lines);
                if (result == -1)
                {
                    heart--;
                    Console.WriteLine("you have " + heart + " hearts left! ");

                }
                else {
                    lines[result] = c;
                }
                if (heart == 1)
                {
                    Console.Write("WATCH OUT!!");
                    Console.WriteLine(" ");
                }


                print_lines(lines);

                if (checkwin(lines)) {
                    win = true;
                    break;
                } 
            }

            if (win)
            {
                Console.WriteLine("You Won!=)");
            }
            else
            {
                Console.WriteLine("You Lost!-_-");
            }
        }


        public static char askUser()
        {
            Console.WriteLine("Please Enter a Char :");
            char c = Console.ReadLine()[0];
            return c;
        }

        public static string getTodayWord()
        {
            string[] arr = { "loop", "home", "good", "door", "lose","easy","ball","kick","wall","hard","soft","mall","game" };
            Random random = new Random();
            int rnd = random.Next(arr.Length);
            return arr[rnd];
        }
        public static int checkletter(string todayword, char ch, char[] list)
        {
            for (int i = 0; i < todayword.Length; i++)
            {
                if (todayword[i] == ch && list[i] != ch)
                {
                    return i;
                }
            }

            return -1;
        }
        public static bool checkwin(char[] lines)
        {
            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == '_')
                {
                    return false;
                }

            }

            return true;
        }

        public static void print_lines(char[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i] + " ");
            }

            Console.Write('\n');
        }
    }
}

