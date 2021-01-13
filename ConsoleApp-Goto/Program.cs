using System;

namespace ConsoleApp_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
        inelegible:
            Console.WriteLine("You are nor eligible to vote!!");

            Console.WriteLine("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 18)
            {
                goto inelegible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
        }
    }
}

//Regresar a goto en caso de cumplirse la condicion inelegible