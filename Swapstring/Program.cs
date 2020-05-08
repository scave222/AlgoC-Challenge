using System;
using System.Collections;

namespace Swapstring
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
             //Swap string for array negative value
            ArrayList SwapString = new ArrayList() {3,-4,5,6,-8,-1};
            IntegerDelegate ArrayNegative = () => {
                for(int i = 0; i < SwapString.Count; i++){
                    if((int)SwapString[i] < 0){
                        SwapString[i] = "Codebits";
                    }
                    Console.Write(SwapString[i] + ",");
                }
            };
            ArrayNegative();
        }
    }
}
