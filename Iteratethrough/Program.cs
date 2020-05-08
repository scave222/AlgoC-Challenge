using System;

namespace Iteratethrough
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Iterate through an array and print all its value
            int[] iterate = {66,2,34,12,45,62};
            IntegerDelegate iteration = () => {
                foreach(int num in iterate){
                    Console.Write(num + ",");
                }
            };
            iteration();
        }
    }
}
