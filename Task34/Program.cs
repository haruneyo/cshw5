int[] array = new int[6];
int count = 0;
FillArray(array);
void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"The {i} index is: {array[i]}");
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"The total amount of even numbers is: {count}");