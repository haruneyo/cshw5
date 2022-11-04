int[] array = new int[6];
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"The {i} index is: {array[i]}");
}
System.Console.WriteLine(FindEvenNumbersInArray(array));

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
}

string FindEvenNumbersInArray(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0) count++; ;
    }
    return $"The total amount of even numbers is: {count}";
}