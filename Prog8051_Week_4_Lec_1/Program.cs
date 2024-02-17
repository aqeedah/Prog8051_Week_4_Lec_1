using System;
class Program
{
    static void Main(string[] args)
    {
        //Loops
        //For Loop
            int count = 0;
        int sum = 0;
           for(int a = 0; a<=10; a = a+1)
            {
               if(a%2 == 0)
                {
                sum = sum + a;
                count++;
                Console.WriteLine(a);
                }
           // Console.WriteLine("even numbers :" + count + "");
        }
        Console.WriteLine("even numbers :" + count + "and the total value is: "+ sum);
        //While Loop
        int num = 0;
        while(num < 7)
        {
            Console.WriteLine("hi");
            num++;
        }
        int num1 = 35;
        bool found = true;
        int countmyguess = 0;
        while(found)
        {
            Console.WriteLine("Please enter number:");
            int guess = Convert.ToInt32(Console.ReadLine());
            if( guess == num1 )
            {
                found = false;
                Console.WriteLine("yay!!!");
            }
            countmyguess++;
        }
        Console.WriteLine(countmyguess);
    }
}