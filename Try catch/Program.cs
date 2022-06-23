using System;

namespace test_program
{
    class program
    {

        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter the first value :");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the secound value :");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 + num2);
            }
            catch (Exception e)
            {

                Console.WriteLine("Pls enter the integar values :" + e);
            }
            finally
            {
                Console.WriteLine("YES :");
            }

            Console.ReadLine();
        }
    }
}
