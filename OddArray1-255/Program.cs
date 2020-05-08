using System;

namespace OddArray1_255
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
               //Return Odd Array 1-255
            int[] OddArray = new int[128];
            int i;
            int num = 0;
            IntegerDelegate OddArr = () => {           
                for(i = 1; i <= 255; i++)
                {              
                    if(i % 2 != 0){
                        OddArray[num] = i;                   
                        Console.Write(OddArray[num] + ",");
                        num++;
                    }   
                }  
            };
            OddArr();
        }
    }
}
