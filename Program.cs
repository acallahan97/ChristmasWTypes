using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a constant of type double
            const double PI = 3.14;

            //Variable Declarations
            int height;
            string lastname;
            bool isConfused;
            char middleInitial;
            decimal balance;
            double x;

            //Variable Initializations
            height = 6;
            lastname = "Callahan";
            isConfused = true;
            middleInitial = 'M';
            balance = 10.00M;
            x = 10.00;

            Console.WriteLine($"My last name is {lastname}, I am {height} tall. You might ask me {x} times if this project makes me confused and that is {isConfused}. I feel like I have {balance} brain cells doing this, but at least I know {PI}!");
        }
    }
}

