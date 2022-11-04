int[] array = new int[6];
FillArray(array);
void FillArray(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
        System.Console.WriteLine($"The {i} index is: {a[i]}");
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"The total amount of even numbers is: {count}");
}