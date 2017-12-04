using System;

namespace Consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*<- start crimment block
             * hello fello
             * ends comment block /* */

            string name = "Lillemor "; //this is how i can write comments in C#
            Console.WriteLine(name + ":hello world!");

            String ageStr = Console.ReadLine();

            Console.WriteLine(ageStr);

            int age = Convert.ToInt32(ageStr);
            age++; //age=age + 1; är samma som age++;

            Console.WriteLine("you will be" + age + "next year!");
            if (age > 20)
            {
                Console.WriteLine("you can buy beer next year!");
            }
            else
            {
                Console.WriteLine("still soda for you sorry");
            }

            // old code above,not needed for the next part to work

            bool keepAlive = true;

            while (keepAlive)
            {
                //int selection = Convert.ToInt32(Console.ReadLine());

                int selection = getNumberFromUser();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("You selected number One");
                        break;
                    case 2:
                        Console.WriteLine("You selected number two");
                        break;
                    case -1:
                        keepAlive = false;
                        break;

                    default: //not needed for the sitch to work
                        Console.WriteLine("incorrect selection!");
                        break;
                }
            }
        }

        static int getNumberFromUser()
        {
            int num = 0;// Delflt Zero

            int.TryParse(Console.ReadLine(), out num);

            return num;

        }

    }
}//namespace


