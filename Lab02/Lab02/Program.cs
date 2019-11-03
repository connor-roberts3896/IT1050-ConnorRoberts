using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);

            Console.WriteLine("{0}\n{1}","Hello World!",     "From Connor");
            Console.ReadLine();

            Console.WriteLine("Hello World!     From Connor");
            Console.ReadLine();

            //Question 1: At what point in the program does our C# Console Application execution?
            //Answer: I'm having a hard time understanding the phrasing of this question, but I believe the answer is when you delcare "method main"

            //Question 2: What is the difference between an integer type variable and a double / floating-point variable?
            //Answer: Integers are whole numbers that can't have decimals.  Doubles and floats can store numbers that are not whole numbers.  Floats can hold 7 digits and doubles can hold 16 digits.

            //Question 3: We can create blocks of code that we can call by name using a method.  Give an example of a method from Chapter 4.
            //Answer: A few examples cited in chapter 4 are the bank account example, which is that the method hides all the work the bank does to display your balance for you, making it easy to simply pull out your phone and look instead of walking into the bank vault to count your money.
            //cont. Another example is the gas pedal of a car.  The gas pedal hides the inner workings of the car that actually make it go.  This makes it so that people who know nothing about how a car works can still drive a car.

            //Question 4: Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.  To read the value of an instance variable, we create method called a 'GET' accessor.  To assign a value ton instance variable, we use a method called a 'SET' accessor.
            //Answer: I filled in the blanks of the question with the correct answers.

            //Question 5: What is the difference between a class and an object? How many instances of a class can we create?
            //Answer: A class houses methods that accomplish certain tasks assigned to the class.  An object, as I understand it, is what allows the class to perform the tasks it describes. A class can't operate without objects.
            //cont. You can have multiple instances of a class, which are needed to have that class perform the task that it's designed for.

        }
    }
}
