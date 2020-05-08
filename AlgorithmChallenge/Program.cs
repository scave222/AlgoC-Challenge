using System;
using System.Collections;

namespace AlgorithmChallenge
{
    public delegate void IntegerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
                //Print 1 - 255
            // IntegerDelegate integerDelegate = () => {
            //     for(int i = 1; i <= 255; i++)
            //     {
            //         Console.Write(i + ",");
            //     }
            // };
            // integerDelegate();

                //Print int and sum 0-255
            // IntegerDelegate intAndSum = () => {
            //     int a = 0;
            //     for (int i = 0; i <= 255; i++)
            //     {
            //         a += i;
            //         Console.Write(i + " sum = " + a + ", ");
            //     }
            // };
            // intAndSum();

                //Print Max of Array
            // int[] arr = new int[]{13,55,7,19,65,12,34};
            // IntegerDelegate arrDelegate = () => {
            //     int b = 0;
            //     for(int i = 0; i < arr.Length; i++)
            //     {
            //         if(arr[i] >= b){
            //             b = arr[i];
            //         }
            //     }
            //     Console.Write(b);
            // };
            // arrDelegate();

                //Return Odd Array 1-255
            // int[] OddArray = new int[128];
            // int i;
            // int num = 0;
            // IntegerDelegate OddArr = () => {           
            //     for(i = 1; i <= 255; i++)
            //     {              
            //         if(i % 2 != 0){
            //             OddArray[num] = i;                   
            //             Console.Write(OddArray[num] + ",");
            //             num++;
            //         }   
            //     }  
            // };
            // OddArr();

                //Return array count greater than Y
            // int[] ArrayCount = {2,3,4,6,8,4};
            // Func<int,int> Arrcount = (Y) => {
            //     int number = 0;
            //     foreach(int num in ArrayCount){
            //         if(num > Y){
            //             number++; 
            //         }
                   
            //     }
            //      return number;
            // };
            // int result = Arrcount(2);
            // Console.Write(result);

                //Print the Max,Min,Average Array Values
            // int[] MaxMinAve = {5,10,21,35,23};
            // int max = MaxMinAve[0];
            // int min = MaxMinAve[0];
            // double sum = 0;
            // IntegerDelegate maxMinAverage = () => {
            //     foreach(int num in MaxMinAve){
            //         sum += num;
            //         if(num > max){
            //             max = num;
            //         }
            //         if(min > num){
            //             min = num;
            //         }
            //     }
            //     double average = sum / (double)MaxMinAve.Length;
            //     Console.WriteLine("The maximum is " + max);
            //     Console.WriteLine("The minimum is " + min);
            //     Console.WriteLine("The average is " + average);
            // };
            // maxMinAverage();

                //Swap string for array negative value---------------------------------------------
            int[] SwapString = {3,-4,5,6,-8,-1};
            IntegerDelegate ArrayNegative = () => {
                int count = 0;

                foreach(int num in SwapString){
                    count++;
                    if(num < 0){
                        (string)SwapString[count] = "Codebits";
                    }
                    Console.WriteLine(num + ",");
                }
            };
            ArrayNegative();

                //Print all Odd numbers from 1 - 255
            // IntegerDelegate Oddnum = () => {
            //     for (int i = 1; i <= 255; i++)
            //     {
            //         if(i % 2 != 0)
            //         {
            //             Console.Write(i + ",");
            //         }
            //     }
            // };
            // Oddnum();

                //Iterate through an array and print all its value
            // int[] iterate = {66,2,34,12,45,62};
            // IntegerDelegate iteration = () => {
            //     foreach(int num in iterate){
            //         Console.Write(num + ",");
            //     }
            // };
            // iteration();

                //Print average
                // int[] getaverage = {66,2,34,12,45,62};
                // IntegerDelegate gettingAverage = () => {
                //     double a = 0;
                //     foreach(int num in getaverage){
                //         a += (double)num;
                //     }
                //     Console.Write(a / getaverage.Length);
                // };
                // gettingAverage();

                    // Square each num in an array
                // int[] squareNum = {6,2,4,2,5,8};
                // IntegerDelegate NumSquare = () => {

                //     for (int i = 0; i < squareNum.Length; i++)
                //     {
                //         squareNum[i] = squareNum[i] * squareNum[i];
                //         Console.Write(squareNum[i] + ","); 
                //     }
                // };
                // NumSquare();

                    //Zero out array negative number
                // int[] ArrNeg = {-6,2,-4,2,-5,8};
                // IntegerDelegate ZeroNegNum = () => {
                //     for(int i = 0; i < ArrNeg.Length; i++)
                //     {
                //         if(ArrNeg[i] < 0){
                //             ArrNeg[i] = 0;
                //         }
                //         Console.Write(ArrNeg[i] + ",");
                //     }
                // };
                // ZeroNegNum();

                    //Shift Array values left
                // int[] ArrShift = {2,5,4,7,1,8};
                // IntegerDelegate ShiftArray = () => {
                //     int count = 1;
                //     for (int i = 0; i < ArrShift.Length; i++)
                //     {
                //         if(count == ArrShift.Length){
                //             ArrShift[i] = 0;
                //         }else{
                //             ArrShift[i] = ArrShift[i + 1];
                //         }
                        
                //         Console.Write(ArrShift[i] + ",");
                //         count++;
                //     }
                    
                // };
                // ShiftArray();





            
            
            
        }
    }
}
