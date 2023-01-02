using System;

namespace ConsoleApp48;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
        string nonNullOperation = 
            operation ?? throw new ArgumentNullException(nameof(operation));

        if (nonNullOperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("...logging...");
               

                throw new CalculationException(ex);
            }
        }
        

        else if (nonNullOperation == "-")
        {
            try
            {
                return Substract(number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("...logging...");
                

                throw new CalculationException(ex);
            }
        }
       

         else if (nonNullOperation == "+")
        {
            try
            {
                return Add(number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("...logging...");
                

                throw new CalculationException(ex);
            }
        }
        

        else if (nonNullOperation == "*")
        {
            try
            {
                return Multiply(number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("...logging...");
                
                throw new CalculationException(ex);
            }
        }
        else
        {
            throw new CalculationOperationNotSupportedException(operation);
        }


    }



    private int Divide(int number, int divisor) => number / divisor;

    private int Add(int number1, int number2) => number1 + number2;

    private int Substract(int substractor, int substracting) => substractor - substracting;

    private int Multiply(int number1, int number2) => (number1 * number2);
}

