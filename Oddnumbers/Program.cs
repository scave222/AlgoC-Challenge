using System;

namespace Oddnumbers
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Print all Odd numbers from 1 - 255
            IntegerDelegate Oddnum = () => {
                for (int i = 1; i <= 255; i++)
                {
                    if(i % 2 != 0)
                    {
                        Console.Write(i + ",");
                    }
                }
            };
            Oddnum();
        }
    }
}
