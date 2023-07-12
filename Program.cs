using System;

class Program
{
    static void Main()
    {

        /* This example shows how to use TryParse method to convert string to int*//*
        string intString = "789";
        int intValue;
        if (int.TryParse(intString, out intValue))
        {
            Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
        }
        else
        {
            Console.WriteLine("TryParse failed. Invalid input string.");
        }

        *//* This example shows how to  Convert method to convert string to double*//*
        string doubleString = "6.21";
        try
        {
            double doubleValue = Convert.ToDouble(doubleString);
            Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Convert failed. Invalid input format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Convert failed. Input value is too large or too small.");
        }

         *//*This example shows how to use Parse method to convert string to decimal*//*
        string decimalString = "12.24";
        try
        {
            decimal decimalValue = decimal.Parse(decimalString);
            Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse failed. Invalid input format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Parse failed. Input value is too large or too small.");*/


        //Example to Convert a string to an integer using the TryParse method.
        string input1 = "10";
        int result1;

        if (int.TryParse(input1, out result1))
        {
            int multipliedValue = result1 * 5;
            Console.WriteLine("Conversion successful. Result: " + multipliedValue);
        }
        else
        {
            Console.WriteLine("Conversion failed. Invalid input.");
        }

        //Convert a string to a DateTime object using the Convert method.
        try
        {
            DateTime result2 = Convert.ToDateTime("2023-07-12");
            DateTime modifiedDate = result2.AddMonths(-1);
            Console.WriteLine("Conversion successful. Modified DateTime: " + modifiedDate);
        }
        catch (FormatException)
        {
            Console.WriteLine("Conversion failed. Invalid format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Conversion failed. Value is too large or too small.");
        }

        //Convert a string to a TimeSpan object using the Parse method.
        try
        {
            TimeSpan result3 = TimeSpan.Parse("02:30:00");
            TimeSpan modifiedTime = result3.Add(new TimeSpan(2, 0, 0));
            Console.WriteLine("Conversion successful. Modified TimeSpan: " + modifiedTime);
        }
        catch (FormatException)
        {
            Console.WriteLine("Conversion failed. Invalid format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Conversion failed. Value is too large or too small.");
        }
    }
    }


