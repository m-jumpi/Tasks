using System;

class Program
{
    public static void Main()
    {
        Input(out int[] massiv);

        var sumElements = SumElements(massiv);
        Console.WriteLine($"Summ of all elements in array = {sumElements}");

        var avarage = Avarage(massiv);
        Console.WriteLine($"Avarage = {avarage:N2}");

        var sumPositiveNegative = SumPositiveNegative(massiv);
        Console.WriteLine($"Sum of possitive elements = {sumPositiveNegative.sumPositive}\nSum of negative elements = {sumPositiveNegative.sumNegative}");

        var sumEvenOdd = SumEvenOdd(massiv);
        Console.WriteLine($"Sum of even elements = {sumEvenOdd.sumEven}\nSum of odd elements = {sumEvenOdd.sumOdd}");

        var maxMin = FindMaxMin(massiv);
        Console.WriteLine($"Max element = {maxMin.maxElement} at index {maxMin.maxIndex}\nMin element = {maxMin.minElement} at index {maxMin.minIndex}");

        var sumMaxMin = SumMaxMin(massiv);
        Console.WriteLine($"Sum of elements between min and max elemants = {sumMaxMin}");
    }

    public static void Input(out int[] massiv)
    {
        int n = IntCheck($"Please enter a number of elements in array:");
        massiv = new int[n];
        for (int i = 0; i < n; i++)
        {
            massiv[i] = IntCheck($"Enter element {i}:");
        }
    }

    public static int SumElements(int[] massiv)
    {
        int result = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            result += massiv[i];
        }
        return result;
    }

    public static double Avarage(int[] massiv)
    {
        return (double)SumElements(massiv) / (double)massiv.Length;
    }

    public static (int sumNegative, int sumPositive) SumPositiveNegative(int[] massiv)
    {
        int sumNegative = 0;
        int sumPositive = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                sumNegative += massiv[i];
            }
            if (massiv[i] > 0)
            {
                sumPositive += massiv[i];
            }
        }
        return (sumNegative, sumPositive);
    }

    public static (int sumEven, int sumOdd) SumEvenOdd(int[] massiv)
    {
        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                sumEven += massiv[i];
            }
            else
            {
                sumOdd += massiv[i];
            }
        }
        return (sumEven, sumOdd);
    }

    public static (int maxElement, int maxIndex, int minElement, int minIndex) FindMaxMin(int[] massiv)
    {
        int minElement = int.MaxValue;
        int maxElement = int.MinValue;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > maxElement)
            {
                maxElement = massiv[i];
            }
        }

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < minElement)
            {
                minElement = massiv[i];
            }
        }

        int minIndex = Array.IndexOf(massiv, minElement);
        int maxIndex = Array.IndexOf(massiv, maxElement);
        return (maxElement, maxIndex, minElement, minIndex);
    }

    public static int SumMaxMin(int[] massiv)
    {
        int minIndex = Array.IndexOf(massiv, massiv.Min());
        int maxIndex = Array.IndexOf(massiv, massiv.Max());
        int result = 0;

        if (minIndex < maxIndex)
        {
            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                result += massiv[i];
            }
        }

        if (minIndex > maxIndex)
        {
            for (int i = maxIndex + 1; i < minIndex; i++)
            {
                result += massiv[i];
            }
        }
        return result;
    }

    public static int IntCheck(string message)
    {
        Console.WriteLine(message);
        var inputLine = Console.ReadLine();
        int resutl;
        while (!int.TryParse(inputLine, out resutl))
        {
            Console.WriteLine("Invalid Input");
            inputLine = Console.ReadLine();
        }
        return resutl;
    }
}