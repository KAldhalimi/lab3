using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hello, whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi there " + name + "!");
            goback();

            int n1;
            void goback()
            {
                bool goOn = false;
                     Console.Write("Input a number: ");
                     n1 = int.Parse(Console.ReadLine());

                    if (n1 % 2 == 0)
                    {
                        if (n1 >= 2 && n1<25)
                        {
                        Console.WriteLine("Evan and less then 25");
                       

                        }
                        else if(n1 >= 26 && n1 <=60)
                        
                         {
                             Console.WriteLine("even");
                        }
                    else if (n1 > 60 )
                       

                    {
                        Console.WriteLine(n1 + " even");
                    }

                    Console.WriteLine("{0} is an even number", n1);
                        Console.WriteLine("would you like to contine y/n");
                        string input = Console.ReadLine();
                        input = input.ToLower();
                        if (input == "y")
                        {
                        goOn = true;
                        goback();
                        }
                        else if (input == "n")
                        {
                            goOn = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} is an odd number", n1);
                        Console.WriteLine("would you like to contine y/n");
                        string input = Console.ReadLine();
                        Console.WriteLine();
                        input = input.ToLower();
                        if (input == "y")
                        {
                            goOn = true;
                        }
                        else if (input == "n")
                        {
                            goOn = false;
                        }

                    if (goOn == true)
                    {
                        goback();
                    }
                       

                }


            }
        }

     



        }
    }

