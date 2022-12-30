using System;

namespace Section1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the firstnumber");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the secondnumber");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("the numbers between{0} and {1}", firstnumber, secondnumber);

            for (int i = firstnumber; i <= secondnumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                        {

                        }

                        if (counter == 0 && i != 1)
                        {
                            Console.WriteLine("0", i);
                            {
                            }
                        }
                    }
                }
            }
        }
    }
}



































