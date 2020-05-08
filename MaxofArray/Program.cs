using System;

namespace MaxofArray
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
               //Print Max of Array
            int[] arr = new int[]{13,55,7,19,65,12,34};
            IntegerDelegate arrDelegate = () => {
                int b = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] >= b){
                        b = arr[i];
                    }
                }
                Console.Write(b);
            };
            arrDelegate();
        }
    }
}
