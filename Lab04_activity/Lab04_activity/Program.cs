using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Task 1: Displaying Jagged Array ====");
            activity1();
            Console.WriteLine();
            Console.WriteLine("==== Task 2: Printing 1D Jagged Array ====");
            activity2();
            Console.WriteLine();
            Console.WriteLine("==== Task 3: Displaying 2D Jagged Array ====");
            activity3();
            Console.WriteLine();
            Console.WriteLine("==== Task 4: Array Manipulations ====");
            activity4();
            Console.WriteLine();
        }

        private static void activity1()
{
    int[][] jaggedArray = new int[4][];
    jaggedArray[0] = new int[2] { 1, 3 };  // Changed values in row 1
    jaggedArray[1] = new int[4] { 11, 22, 33, 44 };  // Changed values in row 2
    jaggedArray[2] = new int[6] { 5, 10, 15, 20, 25, 30 };  // Changed values in row 3
    jaggedArray[3] = new int[3] { 100, 200, 300 };  // Changed values in row 4

    Console.WriteLine("Jagged Array Contents:");
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        Console.Write($"Row {i + 1}: [ ");
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j]);
            if (j < jaggedArray[i].Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" ]");
    }
}


        private static void activity2()
        {
            int[][] jaggedArray1D = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            Console.WriteLine("1D Jagged Array:");
            for (int i = 0; i < jaggedArray1D.Length; i++)
            {
                Console.Write($"Array {i + 1}: ");
                foreach (int value in jaggedArray1D[i])
                {
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void activity3()
        {
            int[][,] jaggedArray2D = new int[2][,]
            {
                new int[,] { {1, 2}, {3, 4} },
                new int[,] { {5, 6, 7}, {8, 9, 10} }
            };

            Console.WriteLine("\n2D Jagged Array (Formatted):");
            for (int i = 0; i < jaggedArray2D.Length; i++)
            {
                Console.WriteLine($"2D Array {i + 1}:");
                int rows = jaggedArray2D[i].GetLength(0);
                int cols = jaggedArray2D[i].GetLength(1);

                Console.Write("    ");
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"Col{col + 1}\t");
                }
                Console.WriteLine();

                for (int row = 0; row < rows; row++)
                {
                    Console.Write($"Row {row + 1}: ");
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(jaggedArray2D[i][row, col] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private static void activity4()
        {
            string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            PrintArray(weekdays);
            ChangeArray(weekdays);
            Console.WriteLine("Arrays after the call to ChangeArray (reversed):");
            PrintArray(weekdays);
            Console.WriteLine();
            ChangeArrayElements(weekdays);
            Console.WriteLine("Arrays after changing individual elements:");
            PrintArray(weekdays);
            Console.ReadLine();
        }

        static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        static void ChangeArray(string[] array)
        {
            Array.Reverse(array);
            Console.WriteLine("The first element after reversing is: {0}", array[0]);
        }

        static void ChangeArrayElements(string[] array)
        {
            if (array.Length > 2)
            {
                array[2] = "Tuesday";
            }
            if (array.Length > 3)
            {
                array[3] = "Wednesday";
            }
        }
    }
}