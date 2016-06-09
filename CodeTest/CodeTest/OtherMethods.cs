using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class OtherMethods
    {

        public void ExceptionMethod(int num1, int num2)
        {
            double result = 0;
            try
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("The input is invalid. The insertted input arguments are: " + num1 + " and " + num2, e);
            }
            finally
            {
                Console.WriteLine("Method has been fully executed.");
            }
        }

        public void passcodeMethod()
        {
            String passcode = "";
            Random rand = new Random();

            String letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int pass1 = rand.Next(0, 10);
            int pass2;
            if (pass1 == 9)
            {
                pass2 = 9;
            }
            else
            {
                pass2 = rand.Next(pass1 + 1, 10);
            }
             
            int index = rand.Next(0,letters.Length);
            String pass3 = letters.Substring(index,1);

            passcode = pass1.ToString() + pass2.ToString() + pass3;

            Console.Write(passcode);


        }

    }
}
