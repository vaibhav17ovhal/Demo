using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Example
    {
        public void Add()
        {
            /*
            Data Types:
            int a = 10;
            double b = 10.0;
            char c = 'C';
            string d = "Vaibhav";
            bool f = true;
            */

            /*
            Console.WriteLine("Vaibhav");
            Console.WriteLine("Ovhal");
            int num1 = 'd';

            string a = "Good Morning";
            string b = "Vaibhav";
            Console.WriteLine(b, a);
           

            Console.Write("Enter the 1st num: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd num: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + number2);

            
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", How are you?");
            Console.WriteLine("Hello {0}, How are you?", name);
            Console.WriteLine($"Hello {name}, How are you?");
            

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Addition of " + num1 + " and " + num2 + " is: " + sum);
            //Console.WriteLine("Addition of {0} and {1} is: {2}", num1, num2, sum);
            //Console.WriteLine($"Addition of {num1} and {num2} is: {sum}");

            int sub = num1 - num2;
            Console.WriteLine("Subtracting " + num1 + " from " + num2 + " equals: " + sub);
            //Console.WriteLine("Subtracting {0} from {1} equals: {2}", num1, num2, sub);
            //Console.WriteLine($"Subtracting {num1} from {num2} equals: {sub}");

            int multi = num1 * num2;
            Console.WriteLine("Multiply " + num1 + " and " + num2 + " equals: " + multi);
            //Console.WriteLine("Multiply {0} and {1} gives result: {2}", num1, num2, multi);
            //Console.WriteLine($"Multiply {num1} and {num2} gives: {multi}");

            int div = num1 / num2;
            Console.WriteLine("Dividing " + num1 + " from " + num2 + " gives " + div);
            //Console.WriteLine("Dividing {0} from {1} gives: {2}", num1, num2, div);
            //Console.WriteLine($"Dividing {num1} from {num2} gives: {div}");
            */

            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            if (name.Length > 2 && name.Length < 5)
            {
                Console.WriteLine("Hello {0}, How are you?", name);
            }
            else if (name.Length > 5)
            {
                Console.WriteLine("The name is greater than 5 characters.");
            }
            else
            {
                Console.WriteLine("The name is less than 3 characters.");
            } 
            

            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter your name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine("Hello " + name1 + " and " + name2);
            Console.WriteLine("Hello {1} and {0}", name1 , name2);
            Console.WriteLine($"Hello {name1} and {name2}");
        }
    }
}
