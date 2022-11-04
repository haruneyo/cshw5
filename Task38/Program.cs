double[] array = { -28.82, 39.31, -7, 36, 78.38, -56.9, 34.2 };
double max = MaxInArray(array);
double min = MinInArray(array);
System.Console.WriteLine(DifferenceMaxMin(max, min));

double MaxInArray(double[] a)
{
    double max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max) max = a[i];
    }
    return max;
}

double MinInArray(double[] a)
{
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < min) min = a[i];
    }
    return min;
}

double DifferenceMaxMin(double maxNumber, double minNumber)
{
    double difference = maxNumber - minNumber;
    return difference;
}