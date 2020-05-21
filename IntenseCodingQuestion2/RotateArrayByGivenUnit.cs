/*
 * This project is for taking in an input array and the unit by which
 * it has to be rotated and diplay the corresponding rotated array.
 * Developed By C Akhil Chowdary on 20/05/2020 
 */

using System;

//namespace
namespace IntenseCodingQuestion2
{
    //OUr Class
    class RotateArrayByGivenUnit
    {
        static void Main(string[] args)
        {
            int k, n; //Length of array and the Unit by which it has to be rotated.
           
            //Infinite loop
            while (true)
            {
                //Taking the length of Array
                Console.WriteLine("Enter the length of Array");
                bool isNInteger = int.TryParse(Console.ReadLine(), out n);
                while(!isNInteger||n<1)
                {
                    Console.WriteLine("Please Enter Natural Numbers only");
                    isNInteger = int.TryParse(Console.ReadLine(), out n);
                }

                //Declaring Input and Output Arrays
                int[] InputArray = new int[n];
                int[] RotatedArray = new int[n];

                //Taking Input Array
                Console.WriteLine("Enter the input array");
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        InputArray[i] = int.Parse(Console.ReadLine());
                    }
                }
                //Catch block for exceptions occurred in Reading Input Array
                catch (Exception)
                {
                    Console.WriteLine("Enter Integers Only");
                    continue;
                }
              
                //Taking the unit by which Array has to be rotated
                Console.WriteLine("Enter the value by which you want to rotate the Array");
                bool isKInteger = int.TryParse(Console.ReadLine(), out k);
                while (!isKInteger )
                {
                    Console.WriteLine("Please Enter Natural Numbers only");
                    isKInteger = int.TryParse(Console.ReadLine(), out k);
                }

                //Conditional check-1 for the Unit by which Array has to be rotated: it must be made less than the length of array
                if (k >= n)
                    k %= n;

                //Conditional check-2 for the Unit by which Array has to be rotated it must be a positive integer
                while (k < 0)
                    k += n;

                //Storing the resulting array in output array
                for (int i = 0; i < n; i++)
                {
                    RotatedArray[(i + k) % n] = InputArray[i];
                }

                //Displaying output
                Console.WriteLine("The Rotated Array:", k);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(RotatedArray[i] + " ");
                }
                Console.WriteLine("---Thank You---");

                Console.ReadKey();
            }
        }
    }
}
