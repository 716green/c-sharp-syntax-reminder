using System;

namespace Pythagorean_Theorem
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Stereotypical Pythagorean Theorem console app to brush up on C# syntax\n\n");
      double a = 0;
      double b = 0;

      //* Get sides via user input 
      a = GetSideA();
      b = GetSideB();


      //* Convert sides to double 
      double numA = Convert.ToDouble(a);
      double numB = Convert.ToDouble(b);

      consolelog("Side A: " + numA + "\nSide B: " + numB + "\n");

      double numC = CalculateSideC(numA, numB);

      consolelog("Side C is: " + numC.ToString());
      consolelog("\n\nPress any key to exit");

      //* Stop program from exiting instantly 
      Console.ReadKey();
    }

    //* Methods
    public static double CalculateSideC(Double sideA, Double sideB)
    {
      // * Get side c squared
      Double cSquared = (sideA * sideA) + (sideB * sideB);
      consolelog("Side C^2: " + cSquared.ToString());

      //* Get sqrt of side c squared
      Double sideC = Math.Round(Math.Sqrt(cSquared), 2);
      return sideC;
    }

    //? To mimic TypeScript for the 🤣's
    public static void consolelog(String value)
    {
      Console.WriteLine(value);
    }

    public static bool TestInputNum(string input)
    {
      //* Test input values for being over 0 and numbers
      bool doubleTest = double.TryParse(input, out double result);
      bool amountTest = result > 0;
      consolelog("doubleTest " + doubleTest + "\namountTest " + amountTest);

      if (doubleTest != true || amountTest != true)
      {
        //! Falied test
        Console.WriteLine("📛 Invalid Entry - Please enter a number \n\n");
        return false;
      }
      else
      {
        //* Good, move on
        Console.WriteLine("✅" + result + " is a valid entry \n\n");
        return true;
      }
    }

    //* Abstracted out code to get the user input. This can be further abstracted to 1 method instead of 2
    public static double GetSideA()
    {
      consolelog("Please enter value for A:");
      string valA = Console.ReadLine();
      if (TestInputNum(valA))
      {
        return Double.Parse(valA);
      }
      else
      {
        return GetSideA();
      }
    }
    public static double GetSideB()
    {
      consolelog("Please enter value for B:");
      string valB = Console.ReadLine();
      if (TestInputNum(valB))
      {
        return Double.Parse(valB);
      }
      else
      {
        return GetSideB();
      }
    }



  }

}
