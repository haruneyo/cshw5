int[] array = new int[6];
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"The {i} index is: {array[i]}");
}
System.Console.WriteLine(SumInArray(array));

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-100, 100);
    }
}

string SumInArray(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (i % 2 != 0) sum += a[i];
    }
    return $"The sum of all uneven numbers in the array is: {sum}";
}