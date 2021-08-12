// Handles a Format Exception if user does not enter a number
using System;
using static System.Console;
using System.Globalization;
class DebugEleven01
{
   static void Main()
   {
      double salary;
      string salVal;
      bool isValidSalary;
      while(!isValidSalary)
      {
         try
         {
            Write("Enter an employee's salary ");
            salVal = ReadLine();
            salary = Convert.ToDouble(salVal);
            isValidSalary = true;
         }
         catch(FormatException e)
         {
            WriteLine(e.Message);
         } 
         WriteLine("The salary {0} is valid", salary.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
      }
     
   }
}
