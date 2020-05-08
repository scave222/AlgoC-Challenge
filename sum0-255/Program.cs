using System;

namespace sum0_255
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Print int and sum 0-255
            IntegerDelegate intAndSum = () => {
                int a = 0;
                for (int i = 0; i <= 255; i++)
                {
                    a += i;
                    Console.Write(i + " sum = " + a + ", ");
                }
            };
            intAndSum();
        }
    }
}
