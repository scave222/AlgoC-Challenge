using System;

namespace Squareeachnum
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
             // Square each num in an array
                int[] squareNum = {6,2,4,2,5,8};
                IntegerDelegate NumSquare = () => {

                    for (int i = 0; i < squareNum.Length; i++)
                    {
                        squareNum[i] = squareNum[i] * squareNum[i];
                        Console.Write(squareNum[i] + ","); 
                    }
                };
                NumSquare();
        }
    }
}
