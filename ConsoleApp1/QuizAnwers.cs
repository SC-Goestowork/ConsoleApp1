using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class QuizAnwers
    {
        public string Number9Answer(string input)
        {
            if (input.Equals(null))
                input = "value is null. Please enter a series of strings";
            else
                input = input.ToUpper();

            return input;
        }

        public double Number8Answer(double input)
        {
            double output = 0;

            output = Math.Sqrt(input);

            if (output < 0)
                throw new Exception("output is a negative number");

            return output;
        }

        public double Number6Answer(double a, double denominator)
        {
            double output = 0;

            if (denominator == 0)
                throw new Exception("denominator must not be zero");
            else
                output = a / denominator;
            return output;
        }

        public int Number4Answer(string input)
        {
            int output = 0;

            bool failure = int.TryParse(input, out output);

            if (failure.Equals(true))
                throw new Exception("cannot be parsed to integer");

            return output;
        }

        public DateTime Number7Answer(string input)
        {
            DateTime output = DateTime.Now;

            bool failure = DateTime.TryParse(input, out output);

            if (failure.Equals(true))
                throw new Exception("input must be date time");

            return output;
        }

        public int Number2Answer(int input)
        {
            if (input > 1000 || input < 0) 
                throw new Exception("input is less than 0 or greater than 1000");

            return input;
        }

        public void Number5Answer(List<uint> input)
        {
            uint output = 0;

            foreach (uint i in input)
            {
                if (i > Int32.MaxValue)
                {
                    Console.WriteLine("invalid interger input. must be within Int32 limits");
                    break;
                }
                else
                    System.Console.WriteLine(output);
            }
        }
        
        public double Number3Answer(int[] input)
        {
            double output = 0;

            if (input.Length == 0)
                throw new Exception("array is empty");

            output = input.Average();

            return output;
        }

        public int Number10Answer(int input)
        {
            int factorial = 1;
            if (input == 0)
                return factorial;
            else
            {
                for (int i = 1; i <= input; i++)
                {
                    factorial = factorial * i;
                }
            }

            if (factorial > Int32.MaxValue)
                throw new Exception("factorial exceeds Int32 limits");

            return factorial;
        }

        public void Number1Answer(string filepath)
        {
            // Opening the stream and reading it back.
            using (FileStream fs = File.Open(filepath, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
    }
   

}
