using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Debugging_application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input;
            input = new int[3];
            int first = input[0];
            int second = input[1];
            int third = input[2];
            Console.WriteLine("Please enter an integer and hit enter");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer and hit enter");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer and hit enter");
            third = Convert.ToInt32(Console.ReadLine()); 

            
            Debug.WriteLine("Debug Information-Product Starting ");
            Debug.Indent();
            Debug.WriteLine("The first number is " + first, "Field");
            Debug.WriteLine("The Second number is " + second, "Field");
            Debug.WriteLine("The third number is " + third, "Field");
            Debug.WriteLine("The sum of all of the numbers is " + (first + second + third), "Calc");
            
            Debug.WriteLineIf(first < 50, " first is Less than 50");

            Debug.WriteLineIf(first > 50, "first isgreater than 50");

            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.IO.File.CreateText("Debug_Output.txt"));
                 Debug.Listeners.Add(tr1);
            Debug.WriteLine("The first number is " + first, "Field");
            Debug.WriteLine("The Second number is " + second, "Field");
            Debug.WriteLine("The third number is " + third, "Field");
            Debug.WriteLine("The sum of all of the numbers is " + (first + second + third), "Calc");
            Debug.Unindent();
            Debug.WriteLine("Debug Information-Product Ending");
            Debug.Flush();
        }

    }
}
