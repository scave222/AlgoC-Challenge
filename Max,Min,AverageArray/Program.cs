using System;

namespace Max_Min_AverageArray
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
             //Print the Max,Min,Average Array Values
            int[] MaxMinAve = {5,10,21,35,23};
            int max = MaxMinAve[0];
            int min = MaxMinAve[0];
            double sum = 0;
            IntegerDelegate maxMinAverage = () => {
                foreach(int num in MaxMinAve){
                    sum += num;
                    if(num > max){
                        max = num;
                    }
                    if(min > num){
                        min = num;
                    }
                }
                double average = sum / (double)MaxMinAve.Length;
                Console.WriteLine("The maximum is " + max);
                Console.WriteLine("The minimum is " + min);
                Console.WriteLine("The average is " + average);
            };
            maxMinAverage();
        }
    }
}
