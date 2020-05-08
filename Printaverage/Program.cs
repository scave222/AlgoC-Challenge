using System;

namespace Printaverage
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Print average
                int[] getaverage = {66,2,34,12,45,62};
                IntegerDelegate gettingAverage = () => {
                    double a = 0;
                    foreach(int num in getaverage){
                        a += (double)num;
                    }
                    Console.Write(a / getaverage.Length);
                };
                gettingAverage();
        }
    }
}
