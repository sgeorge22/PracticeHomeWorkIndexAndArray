using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2           
            int x = 10;
            int y = 20;

            int tempNum = x;
            x = y;
            y = tempNum;

            Console.WriteLine("Problem 2");
            Console.WriteLine($"{x} \n{y}\n");

            //Problem 3
            Console.WriteLine("Problem 3");
            int numValue = 1234;
            string stringValue = numValue.ToString();
            string reverse = string.Empty;

            for ( int i = stringValue.Length - 1; i >= 0; i--)
            {
                reverse += stringValue[i];
            }

            Console.WriteLine(reverse);
            Console.WriteLine("");

            //Problem 4
            //Rewrite this looking for SPECIFICALLY the last two characters 
            Console.WriteLine("Problem 4");
            string dateNow = DateTime.Now.ToString();
            Console.WriteLine(dateNow);

            if (dateNow.EndsWith("AM"))
            {
                Console.WriteLine("Good Morning! \n");
            }

            else
            {
                Console.WriteLine("Good Evening! \n");
            }

            //Problem 5
            Console.WriteLine("Problem 5");
            int[] array = new int[5] { 2, 4, 6, 8, 10 };
            string arrayReversed = string.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayReversed += array[i];
            }

            Console.WriteLine(arrayReversed);
            Console.WriteLine("");

            //Problem 6
            Console.WriteLine("Problem 6");
            foreach (int i in array)
            {
               // I am still having  some trouble with this one. Would love a helper hint or maybe going over it together. All research I come across is showing using array.reverse or the IEnumerable.reverse
            }

            //Problem 7 written out
     //       set up the array for ints1

     //       int a = ints1[2]  assigns 7 to int a

     //       int b = MethodB(a) will then be passed through MethodB param.
     //               MethodB(7)
     //               {
     //                   return 7 * 7
     //               }
     //           will assign the value of 14 to int b.


     //      MethodC(a, b); we will pass in the values of a and b into the MethodC params
					//MethodC(7, 14)
     //               {
     //                   x = 14;
     //               }

     //       ints1[1] = MethodB(ints1[0]) would pass into methodB the value 3. 3 * 3 = 9

     //                           9 would then be assigned to the ints1[1] value

        }
    }
}
