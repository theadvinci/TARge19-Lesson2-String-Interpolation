using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            string firstName;
            string lastName;
            string lemmikVärv;

            Console.WriteLine("How may I refer to you dear human?");
            firstName = Console.ReadLine();
            Console.WriteLine("Does your lineage also have a moniker?");
            lastName = Console.ReadLine();
            //Console.WriteLine("Hello, " + firstName + " " + lastName);

            Console.WriteLine("I greet you {0} {1}", firstName, lastName);


            Console.WriteLine("What are your colors homie?");
            lemmikVärv = Console.ReadLine();

            if (lemmikVärv == "green" || lemmikVärv == "Green") 
            {
                Console.WriteLine("I hate green!");
            }

            else
            {
                Console.WriteLine("Well... I don't hate it.");
            }
                
            Console.ReadLine();
        }
    }
}
