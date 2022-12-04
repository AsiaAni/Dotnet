// Console.Clear();
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine ();
// }

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
     for (int i = 0; i < array.Length - 1; i++)
     {
        int minPosotion = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosotion]) minPosotion = j;
        }

        int temporary = array[i];
        array[i] = array[minPosotion];
        array[minPosotion] = temporary;
     }
}

PrintArray(arr);
SelectionSort(arr);