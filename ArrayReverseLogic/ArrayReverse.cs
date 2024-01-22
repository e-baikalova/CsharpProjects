
using System;

class myProgram {
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

    //my reverse method
    static int[] MyReverseMethod(int[] array) 
    {
        int temporary=0;

        for (int i = 0; i < array.Length/2; i++) 
        {
            temporary = array[i]; 
            array[i] = array[array.Length-1-i];
            array[array.Length-1-i] = temporary;
        }

        return array;
    } 

    //my reverse method with temp array
    static int[] MyReverseMethod2(int[] array) 
    {
        int[] newArray=new int[array.Length] ;

        for (int i = 0; i < array.Length; i++) 
        {
            newArray[array.Length-i-1] = array[i]; 
        }

        for (int i = 0; i < array.Length; i++) 
        {
            array[i] = newArray[i]; 
        }

        return array;
    } 

    //main code
    static void Main() {
        int size = 10; //ReadInt("Введите размер массива: ");
        int[] myArray = GenerateArray(size, -10, 10);
        PrintArray(myArray);
        Array.Reverse(myArray);
        PrintArray(myArray);
        PrintArray(MyReverseMethod(myArray));
        PrintArray(MyReverseMethod2(myArray));
    }
}
