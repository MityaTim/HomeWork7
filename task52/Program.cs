int[][] arrayOfArrays =
{
    new[] {1, 4, 7, 2 },
    new[] {5, 9, 2, 3 },
    new[] {8, 4, 2, 4 }
};

foreach (int[] array in arrayOfArrays)
    Console.WriteLine(array.Average());