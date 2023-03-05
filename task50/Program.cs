int[][] arrayOfArrays =
{
    new[] {1, 4, 7, 2 },
    new[] {5, 9, 2, 3 },
    new[] {8, 4, 2, 4 }
};

int[] indices = Console.ReadLine()!
    .Split(',')
    .Select(x => Convert.ToInt32(x)).ToArray();

int verticalIndex = indices[0] - 1;
int horisontalIndex = indices[1] - 1;

if (arrayOfArrays.Length > verticalIndex && arrayOfArrays[verticalIndex].Length > horisontalIndex)
    Console.WriteLine(arrayOfArrays[verticalIndex][horisontalIndex]);
else Console.WriteLine("Индексы вышли за границы массива, элемент не найден");