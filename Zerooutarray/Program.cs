using System;

namespace Zerooutarray
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Zero out array negative number
                int[] ArrNeg = {-6,2,-4,2,-5,8};
                IntegerDelegate ZeroNegNum = () => {
                    for(int i = 0; i < ArrNeg.Length; i++)
                    {
                        if(ArrNeg[i] < 0){
                            ArrNeg[i] = 0;
                        }
                        Console.Write(ArrNeg[i] + ",");
                    }
                };
                ZeroNegNum();
        }
    }
}
