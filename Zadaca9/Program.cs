namespace Zadaca9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......Divide two integer number........\n");
            try
            {
                Console.WriteLine("Enter first integer number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer number: ");
                int num2 = int.Parse(Console.ReadLine());

                int resultInt = DivideInteger(num1, num2);
                    Console.WriteLine("The result is: " + resultInt);
                

            } catch (DivideByZeroException) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Division integer number by zero is not allowed");
                Console.ResetColor();
            } catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! You must enter integer number");
                Console.ResetColor();
            }
            
            static int DivideInteger(int num1, int num2)
            {
                return num1 / num2;
            }

            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("......Divide two decimal number.........\n");
            try
            {
                Console.WriteLine("Enter first decimal number ");
                double num1Double = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second decimal number ");
                double num2Double = double.Parse(Console.ReadLine());

                double resultDouble = DivideDouble(num1Double, num2Double);
                Console.WriteLine("The result is: " + resultDouble);
                Console.WriteLine("--------------------------------\n");
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! You must enter decimal number");
                Console.ResetColor();
            }
            static double DivideDouble(double num1Double, double num2Double)
            {
                if (num1Double == 0 || num2Double == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    throw new Exception("Divide decimal number by zero is not allowed");
                    Console.ResetColor() ;
                }
                return num1Double / num2Double;
            }

            Console.WriteLine("......Divide two decimal number - NO EXCEPTION.........\n");

                Console.WriteLine("Enter first decimal number ");
                double num1DoubleN = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second decimal number ");
                double num2DoubleN = double.Parse(Console.ReadLine());

                double result = num1DoubleN / num2DoubleN;    
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("--------------------------------\n");

            // Analiza: Kad se ne koristi try/catch, aplikacija puca, dok u suprotnom aplikacija funkcionise i "hvata" greske
        }
    }
}