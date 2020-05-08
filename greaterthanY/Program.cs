using System;

namespace greaterthanY
{
    class Program
    {
        static void Main(string[] args)
        {
             //Return array count greater than Y
            int[] ArrayCount = {2,3,4,6,8,4};
            Func<int,int> Arrcount = (Y) => {
                int number = 0;
                foreach(int num in ArrayCount){
                    if(num > Y){
                        number++; 
                    }
                   
                }
                 return number;
            };
            int result = Arrcount(2);
            Console.Write(result);
        }
    }
}
