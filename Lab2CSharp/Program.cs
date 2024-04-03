using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Replace elements in an interval with zero using a one-dimensional array");
            Console.WriteLine("2. Replace elements in an interval with zero using a two-dimensional array");
            Console.WriteLine("3. Replace all maximum elements with zeros");
            Console.WriteLine("4. Sum of elements on the secondary diagonal");
            Console.WriteLine("5. Count positive elements in each row of a jagged array");
            Console.WriteLine("0. Exit");
            Console.Write("\nOption: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Task1_OneDimensional();
                    break;
                case 2:
                    Task1_TwoDimensional();
                    break;
                case 3:
                    Task2();
                    break;
                case 4:
                    Task3();
                    break;
                case 5:
                    Task4();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void Task1_OneDimensional()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for(int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the start of the interval: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the interval: ");
        int end = int.Parse(Console.ReadLine());

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] >= start && array[i] <= end)
            {
                array[i] = 0;
            }
        }

        Console.WriteLine("Modified array:");
        foreach(int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Task1_TwoDimensional()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[,] array = new int[size, size];

        Console.WriteLine("Enter the elements of the array:");
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Enter the start of the interval: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the interval: ");
        int end = int.Parse(Console.ReadLine());

        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                if(array[i, j] >= start && array[i, j] <= end)
                {
                    array[i, j] = 0;
                }
            }
        }

        Console.WriteLine("Modified array:");
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Task2()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for(int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array.Max();

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == max)
            {
                array[i] = 0;
            }
        }

        Console.WriteLine("Modified array:");
        foreach(int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Task3()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[,] array = new int[size, size];

        Console.WriteLine("Enter the elements of the array:");
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sum = 0;
        for(int i = 0; i < size; i++)
        {
            sum += array[i, size - i - 1];
        }

        Console.WriteLine($"Sum of elements on the secondary diagonal: {sum}");
    }

    static void Task4()
    {
        Console.Write("Enter the number of rows: ");
        int numberOfRows = int.Parse(Console.ReadLine());
        List<int[]> jaggedArray = new List<int[]>();

        for (int i = 0; i < numberOfRows; i++)
        {
            Console.Write($"Enter the size of row {i + 1}: ");
            int size = int.Parse(Console.ReadLine());
            int[] row = new int[size];

            Console.WriteLine($"Enter {size} elements for row {i + 1}:");
            for (int j = 0; j < size; j++)
            {
                row[j] = int.Parse(Console.ReadLine());
            }

            jaggedArray.Add(row);
        }

        int[] positiveCounts = new int[numberOfRows];
        for (int i = 0; i < jaggedArray.Count; i++)
        {
            positiveCounts[i] = 0;
            foreach (int element in jaggedArray[i])
            {
                if (element > 0)
                {
                    positiveCounts[i]++;
                }
            }
        }

        Console.WriteLine("Number of positive elements in each row:");
        foreach (int count in positiveCounts)
        {
            Console.WriteLine(count);
        }
    }
}