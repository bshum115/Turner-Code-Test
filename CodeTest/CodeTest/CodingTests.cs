using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest
{
    [TestClass]
    public class CodingTests
    {
        /// <summary>
        /// Print to the console the time difference in seconds between the two dates below
        /// </summary>
        [TestMethod]
        public void PrintSecondsBetweenTwoDateTimesTest()
        {
            var dateTime1 = DateTime.Parse("6/1/2015 12:00 AM");
            var dateTime2 = DateTime.Now;

            const int SECONDSINMINUTE = 60;
            const int SECONDSINHOUR = 3600;
            const int SECONDSINDAY = 86400;
            
            var difference = dateTime2 - dateTime1;
            int differenceDays = difference.Days * SECONDSINDAY;   //Gets difference between dates in seconds
            int differenceHours = difference.Hours * SECONDSINHOUR;   //Gets difference between hours in seconds
            int differenceMinutes = difference.Minutes * SECONDSINMINUTE;    //Gets difference between minutes in seconds
            int differenceSeconds = difference.Seconds;
            double differenceMillisec = System.Convert.ToDouble(difference.Milliseconds) / 1000;    //Gets difference between milliseconds in seconds
            
            Console.WriteLine("Difference between the two dates in seconds are: " + (differenceDays + differenceHours + differenceMinutes + differenceSeconds + differenceMillisec) + " seconds.");


        }

        /// <summary>
        /// For the numbers 1 to 100 do the following:
        ///     - Print the number
        ///     - If the number is a multiple of 3 then print "Hello"
        ///     - If the number is a multiple of 5 then print "Goodbye"
        ///     - If the number is a multiple of both 3 and 5 then print "Hello and Goodbye"
        /// </summary>
        [TestMethod]
        public void HelloGoodbyeTest()
        {
            for(int i = 1; i < 101; i++)
            {
                Console.Write(i + ": ");
                if(i % 15 == 0)
                {
                    Console.Write("Hello and Goodbye");
                }
                else
                {
                    if(i % 5 == 0)
                    {
                        Console.Write("Goodbye");
                    }
                    else
                    {
                        if(i % 3 == 0)
                        {
                            Console.Write("Hello");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Create a method that divides two numbers. 
        /// If there is an exception print an error message that the input is invalid and the input arguments.
        /// Exercise the exception handling scenario.
        /// </summary>
        [TestMethod]
        public void ExceptionTest()
        {

            OtherMethods m = new OtherMethods();
            m.ExceptionMethod(999999, 0);
        }

        /// <summary>
        /// Create a base Animal class:
        ///     - Name property
        ///     - method Speak() 
        ///     - non-public but accessible from derived class method for printing the Name which will used before Speak is called
        /// 
        /// Create two derived classes from Animal for Dog and Cat
        ///     - override Speak and print the name before speaking
        ///     
        /// Example:  Dog:  "Spot barked", Cat:  "Kit meowed"
        /// 
        /// </summary>
        [TestMethod]
        public void ObjectOrientedTest()
        {
            Dog a = new Dog("Spot");
            Cat b = new Cat("Kit");

            a.Speak();
            b.Speak();

        }

        /// <summary>
        /// Write as a comment the SQL for the following:
        /// 
        /// Return the phone number and product names and purchased date for people whose 
        /// first name is "Jeff" whom have purchased something since 1/1/2016:
        /// 
        /// Assume Tables: 
        /// 
        ///     Persons
        ///         PersonId
        ///         FirstName
        ///         LastName
        ///         PhoneNumber
        ///         
        ///     PurchasedProducts        
        ///         PurchasedProductId
        ///         PersonId
        ///         ProductName
        ///         PurchasedDate
        ///         
        /// </summary>
        [TestMethod]
        public void SqlTest()
        {
            /*
             
            Select Persons.PhoneNumber, PurchasedProducts.ProductName, PurchasedProducts.PurchasedDate
            FROM Persons INNER JOIN PurchasedProducts ON Persons.PersonsId = PurchasedProducts.PersonId
            WHERE Persons.FirstName = 'Jeff' AND PurchasedProducts.PurchasedDate >= '2016-01-01 00:00:00.000'
            
             */
        }

        /// <summary>
        /// Create a method that prints a passcode with the following criteria:
        ///     - 3 characters
        ///     - 1st:  random # 0 -9
        ///     - 2nd:  number needs to be greater than 1st (random)
        ///     - 3rd:  alpha character (A-Z) (random)
        /// </summary>
        [TestMethod]
        public void GeneratePasscodeTest()
        {
            OtherMethods x = new OtherMethods();
            x.passcodeMethod();
        }

        /// <summary>
        /// Create a C# class that expoes a Name property where the class has only one instance to provide global access.
        /// Hint: the class is a commonly used design pattern.
        /// 
        /// Exercise use of the class:
        ///     - Set the Name property
        ///     - Print the name property to the console
        /// </summary>
        [TestMethod]
        public void DesignPatternTest()
        {
            DesignPattern p = new DesignPattern();
            String name = p.globalName = "Bob";
            Console.Write(name);
        }
    }
}
