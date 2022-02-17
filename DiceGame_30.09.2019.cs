using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //START
            //Type Defining

            string name, hst1, hst2, option;
            int a, b, c, d, s, t, hst1score, hst2score;

            //Variable Defining
            Random r = new Random();
            name = " ";
            s = 0;
            option = " ";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            hst1 = "Cem Ak ";
            hst1score = 30;
            hst2 = "Sibel Yaman ";
            hst2score = 18;
            t = 0;
            Console.ForegroundColor = ConsoleColor.Blue;

            //Welcome text and getting name

            Console.WriteLine("********** WELCOME TO DICE GAME **********");

            Console.WriteLine(" PLEASE ENTER YOUR NAME ");
            name = Console.ReadLine();



            Console.WriteLine("---MENU---");
            Console.WriteLine(" PLEASE SELECT FROM THE OPTIONS BELOW: ");
            Console.WriteLine(" 1- GAME MODE 1: THROW DICE RANDOMLY   ");
            Console.WriteLine(" 2- GAME MODE 2: THROW DICE YOURSELF   ");
            Console.WriteLine(" 3- SHOW HIGH SCORE TABLE              ");
            Console.WriteLine(" 4- EXIT                               ");

            option = Console.ReadLine();

            if (option == "4")
            {
                Console.WriteLine(" For quiting please press 'ENTER' ...  ");
                Console.ReadLine();
            }

            else if (option == "3")
            {
                Console.WriteLine(" ***HIGH SCORE TABLE*** \n" + hst1 + hst1score + "\n" + hst2 + hst2score);
                Console.ReadLine();
            }

            else if (option == "2")
            {

                Console.WriteLine("PLEASE ENTER THE FİRST DICE: ");
                a = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("PLEASE ENTER THE SECOND DICE: ");
                b = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("PLEASE ENTER THE THIRD DICE: ");
                c = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("PLEASE ENTER THE FOURTH DICE: ");
                d = Convert.ToInt16(Console.ReadLine());

                t = a + b + c + d;

                if (t < 4 || t > 24)
                {
                    Console.WriteLine("*** ERROR: PLEASE ENTER JUST DICE NUMBER WHICH RANGES [1,6] ***");
                    Console.ReadLine();
                }

                // range diamond shape

                // condition 9

                if ((4 <= t && t <= 7) || (21 <= t && t <= 24))
                {
                    s = s + 30;
                    Console.WriteLine("You get points from the rules: \n'9' ");
                    
                }

                // condition 8

                else if ((8 <= t && t <= 11) || (17 <= t && t <= 20))
                {
                    s = s + 4;
                    Console.WriteLine("You get points from the rules: \n'8' ");
                }
                // condition 7

                else
                {
                    s = s + 2;
                    Console.WriteLine("You get points from the rules: \n'7' ");
                }

                // all same diamond shape (condition 1)

                if ((a == b) && (b == c) && (a == d))
                {
                    s = s + 300;
                    Console.WriteLine("'1' ");
                }

                // only three dice same (condition 2)

                else if ((a == b && b == c) || (a == d && a == b) || (b == c && c == d) || (a == d && a == c))
                {
                    s = s + 16;
                    Console.WriteLine("'2' ");
                }

                // a two-of-a kind and a pair (condition 3)

                else if ((a == b && c == d) || (a == c && b == d) || (a == d && b == c))
                {
                    s = s + 20;
                    Console.WriteLine("'3' ");
                }

                //only two dice same (condition 4)

                else if ((a == b) || (a == c) || (a == d) || (b == c) || (b == d) || (c == d))
                {
                    s = s + 3;
                    Console.WriteLine("'4' ");
                }

                //all different (condition 5)

                else
                {
                    s = s + 5;
                    Console.WriteLine("'5' ");
                }

                //even odd diamond shape (condition 6)

                if (((a % 2 == 0) && (b % 2 == 0) && (c % 2 == 0) && (d % 2 == 0)) ||
                    ((a % 2 == 1) && (b % 2 == 1) && (c % 2 == 1) && (d % 2 == 1)))
                {
                    s = s + 12;
                    Console.WriteLine("'6' ");
                }

                //high score table 

                if (s > hst1score)
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + name + " " + s + "\n" + hst1 + hst1score + "\n" + hst2 + hst2score);
                }

                else if (s > hst2score)
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + hst1 + hst1score + "\n" + name + " " + s + "\n" + hst2 + hst2score);
                }

                else
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + hst1 + hst1score + "\n" + hst2 + hst2score + "\n" + name + " " + s);
                }







                Console.ReadLine();

            }


            else if (option == "1")
            {



                a = r.Next(1, 7);
                b = r.Next(1, 7);
                c = r.Next(1, 7);
                d = r.Next(1, 7);

                Console.WriteLine("The first dice is: " + a + "\n" + "\n" + "The second dice is: " + b + "\n");
                Console.WriteLine("The third dice is: " + c + "\n" + "\n" + "The fourth dice is: " + d);

                t = a + b + c + d;

                // range diamond shape

                // condition 9

                if ((4 <= t && t <= 7) || (21 <= t && t <= 24))
                {
                    s = s + 30;
                    Console.WriteLine("You get points from the rules: \n'9' ");
                }

                // condition 8

                else if ((8 <= t && t <= 11) || (17 <= t && t <= 20))
                {
                    s = s + 4;
                    Console.WriteLine("You get points from the rules: \n'8' ");
                }
                // condition 7

                else
                {
                    s = s + 2;
                    Console.WriteLine("You get points from the rules: \n'7' ");
                }

                // all same diamond shape (condition 1)

                if ((a == b) && (b == c) && (a == d))
                {
                    s = s + 300;
                    Console.WriteLine("'1' ");
                }

                // only three dice same (condition 2)

                else if ((a == b && b == c) || (a == d && a == b) || (b == c && c == d) || (a == d && a == c))
                {
                    s = s + 16;
                    Console.WriteLine("'2' ");
                }

                // a two-of-a kind and a pair (condition 3)

                else if ((a == b && c == d) || (a == c && b == d) || (a == d && b == c))
                {
                    s = s + 20;
                    Console.WriteLine("'3' ");
                }

                //only two dice same (condition 4)

                else if ((a == b) || (a == c) || (a == d) || (b == c) || (b == d) || (c == d))
                {
                    s = s + 3;
                    Console.WriteLine("'4' ");
                }

                //all different (condition 5)

                else
                {
                    s = s + 5;
                    Console.WriteLine("'5' ");
                }

                //even odd diamond shape (condition 6)

                if (((a % 2 == 0) && (b % 2 == 0) && (c % 2 == 0) && (d % 2 == 0)) ||
                    ((a % 2 == 1) && (b % 2 == 1) && (c % 2 == 1) && (d % 2 == 1)))
                {
                    s = s + 12;
                    Console.WriteLine("'6' ");
                }

                //high score table 

                if (s > hst1score)
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + name + " " + s + "\n" + hst1 + hst1score + "\n" + hst2 + hst2score);
                }

                else if (s > hst2score)
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + hst1 + hst1score + "\n" + name + " " + s + "\n" + hst2 + hst2score);
                }

                else
                {
                    Console.WriteLine("\n" + " ***HIGH SCORE TABLE*** \n" + hst1 + hst1score + "\n" + hst2 + hst2score + "\n" + name + " " + s);
                }







                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("*** ERROR: PLEASE ENTER 1 , 2 ,3 or 4 ***");
                
                Console.ReadLine();
            }

            
        }
    }
}
