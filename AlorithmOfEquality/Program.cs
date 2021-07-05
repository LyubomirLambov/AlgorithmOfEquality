﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlorithmOfEquality
{
    class Program
    {
         static int BinarySearch(int[]Array,int desired)
        {
            int left = 0;
            int right = Array.Length - 1;
            while(left<=right)
            {
                int mid = (left + right) / 2;
                if (desired==Array[mid])
                {
                    return mid;
                }
                else if (desired<Array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] Array = new int[] {1,3,5,7,9,11,15,27,35,42};
            int desired;
            Console.WriteLine("Enter your desired integer so we can search trough the array : ");
            desired = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(Array, desired);
            foreach (int a in Array)
                Console.WriteLine("Element " +a);
            for (int i=0;i<=Array.Length;i++)
            {
                if (desired == Array[i])
                {
                    Console.WriteLine(true);
                }
                else if (desired!=Array[i])
                {
                    Console.WriteLine(false);
                }
            }
            
        }
    }
}
