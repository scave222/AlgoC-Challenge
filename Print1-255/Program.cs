using System;

namespace Print1_255
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Print 1 - 255
            IntegerDelegate integerDelegate = () => {
                for(int i = 1; i <= 255; i++)
                {
                    Console.Write(i + ",");
                }
            };
            integerDelegate();
        }
    }
}
