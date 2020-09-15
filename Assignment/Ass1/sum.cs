using System;  
 namespace add  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            int Num1, Num2;  
            Console.WriteLine(" Enter a Num1");  
            Num1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(" Enter a Num2");  
            Num2 = Convert.ToInt32(Console.ReadLine());  
            int Result;  
            Result = Num1 + Num2;  
            Console.WriteLine("Sum of two Numbers:" + Result.ToString());  
            if(Result>500)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");

            }
        }  
    }  
} 