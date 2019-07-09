﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 9, 6, 5, 4, 2 };

            InsertionSort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void InsertionSort(int[] array)
        {
            int temp;
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];                
                index = i - 1;
                while(index>=0 && array[index]>temp)
                {
                    array[index + 1] = array[index];
                    index--;
                }
                array[index + 1] = temp;
            }
        }
    }
}
