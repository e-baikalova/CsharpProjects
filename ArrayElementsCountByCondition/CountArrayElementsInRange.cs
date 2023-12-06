//program counts elements in array in range [20, 90]
using System;

class Program {
    //read array length
    static int ReadInt(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    //array population
    static int[] GenerateArray(int size, int leftRange, int rightRange)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i=0; i < size; i++)
        {
            tempArray[i] = rand.Next(leftRange, rightRange + 1);
        }

        return tempArray;
    }

    //print array 
    static void PrintArray(int[] array)
    {
        Console.WriteLine("исходный массив: [" + string.Join(",", array) + "]");
    }

    //count array elemnts in predefined range
    static void CountElements(int[] array, int leftRange, int rightRange)
    {
        int countElements = 0;
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] >= leftRange && array[i]<=rightRange)
            {
                countElements++;
            }
        }

        Console.WriteLine("количество элементов массива на отрезке [" + leftRange + ", " + rightRange + "] = " + countElements);
    }


    //main code
    static void Main() {
        int size = 10; //ReadInt("Введите размер массива: ");
        int[] myArray = GenerateArray(size, 1, 100);
        PrintArray(myArray);
        CountElements(myArray,20,90);
    }
}