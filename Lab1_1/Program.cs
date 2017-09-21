using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run =true;
            while(run == true)
            {
                Console.WriteLine("Enter Length:");
                var length = Console.ReadLine();
                Console.WriteLine("Enter Width:");
                var width = Console.ReadLine();
                Console.WriteLine("Enter height:");
                var height = Console.ReadLine();

                //Checking for Valid numbers from  user
                bool validationStatus = UserInputValidation(length, width, height);

                if (validationStatus == true)
                {
                    double varLength = double.Parse(length);
                    double varWidth = double.Parse(width);
                    double varHeight = double.Parse(height);

                    PrintCalculation(varLength, varWidth, varHeight);
                }
                run = Continue();
            }
        }
               
        public static void PrintCalculation(double _length, double _width, double _height)
        {           
                double ansArea = CalcArea(_length, _width);
                Console.WriteLine($"Area: {ansArea}");
                double ansPerimeter = CalcPerimeter(_length, _width);
                Console.WriteLine($"Perimeter: {ansPerimeter}");
                double ansVolume = CalcVolume(_length, _width, _height);
                Console.WriteLine($"Volume: {ansVolume}");
            
        }
        public static bool UserInputValidation( string _length, string _width, string _height)
        {
            try              
            {
                double value;
                //No null or spaces allowed
                if (string.IsNullOrWhiteSpace(_length) || string.IsNullOrWhiteSpace(_length))
                {
                    Console.WriteLine("Please enter valid numbers.");
                    return false;
                }
                else if (!double.TryParse(_length, out value) || !double.TryParse(_width, out value) || !double.TryParse(_height, out value))
                {
                    Console.WriteLine("Please enter correct number and try again.");
                    return false;
                }
                else{return true;
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine($"{ex.GetType()}  means  {ex.Message}");
                return false;
            }
        }

        public static double CalcArea(double _length, double _width)
        {
            double areaRect = _length * _width;
            return areaRect;
        }
        public static double CalcPerimeter(double _length, double _width)
        {
            double perimeterRect = 2 * (_length + _width);
            return perimeterRect;
        }

        public static double CalcVolume(double _length, double _width, double _height)
        {
            double volumeRect = (_length * _width * _height);
            return volumeRect;
        }
  
        public static bool Continue()
        {
            Console.WriteLine("Do you want to continue?(y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goAhead;
            if (input == "y")
            {
                goAhead = true;

            }
            else if (input == "n")
            {
                goAhead = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, please try again");
                goAhead = Continue();
            }
            return goAhead;
        }
    }
}
