using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;



class Program
{
    

    static void Main(string[] args)
    {
        for (int n = 100_000; n <= 1_000_000; n += 100_000)
        {

            Random rn = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) arr[i] = rn.Next(1, 1000);
            Console.WriteLine("\nDla kroku o wartości: " + n);
            RandomValuesArr(arr);
            AscValuesArr(arr);
            DescValuesArr(arr);
            VshapeValuesArr(arr);
            ConstValuesArr(n);
        }
        

    }

    static void SelectionSort(int[] arr) //dobrać sobie z neta
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_id = i;
            for (int j = i + 1; j < n; j++) if (arr[j] < arr[min_id]) min_id = j;
            int temp = arr[min_id];
            arr[min_id] = arr[i];
            arr[i] = temp;
        }
    }

    static void InsertionSort(int[] arr) //dobrać sobie z neta
    {
        for (int i = 1; i < arr.Length; ++i)
        {
            int current = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = current;
        }
    }

    public static void BubbleSort(int[] arr) //dobrać sobie z neta
    {
        int temp;
        bool swapped;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    static void RandomValuesArr(int[] arr)
    {
        double[] Tsuma = new double[gIterations];
        Console.WriteLine("\n");
        Console.WriteLine("Tablica z losowym ustawieniem wartości");
        Console.WriteLine("Średni czas wykonania dla: ");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            SelectionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        double avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Selection Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            InsertionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Insertion Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            BubbleSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Bubble Sort: " + avg + " [s]");
    }


    static void AscValuesArr(int[] arr)
    {
        Array.Sort(arr);

        double[] Tsuma = new double[gIterations];
        Console.WriteLine("\n");
        Console.WriteLine("Tablica z rosnącym ustawieniem wartości");
        Console.WriteLine("Średni czas wykonania dla: ");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            SelectionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        double avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Selection Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            InsertionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Insertion Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            BubbleSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Bubble Sort: " + avg + " [s]");
    }

    static void DescValuesArr(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);

        double[] Tsuma = new double[gIterations];
        Console.WriteLine("\n");
        Console.WriteLine("Tablica z malejącym ustawieniem wartości");
        Console.WriteLine("Średni czas wykonania dla: ");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            SelectionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        double avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Selection Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            InsertionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Insertion Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            BubbleSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Bubble Sort: " + avg + " [s]");
    }

    static void VshapeValuesArr(int[] arr)
    {
        Array.Sort(arr, 0, arr.Length / 2 + 1);
        Array.Reverse(arr, 0, arr.Length / 2 + 1); 
        Array.Sort(arr, arr.Length / 2, arr.Length / 2 + arr.Length % 2);

        double[] Tsuma = new double[gIterations];
        Console.WriteLine("\n");
        Console.WriteLine("Tablica z  V-kształtnym ustawieniem wartości");
        Console.WriteLine("Średni czas wykonania dla: ");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            SelectionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        double avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Selection Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            InsertionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Insertion Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            BubbleSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Bubble Sort: " + avg + " [s]");
    }

    static void ConstValuesArr(int iteration)
    {
        int[] arr = new int[iteration];
        for (int i=0; i < arr.Length; i++) arr[i] = 8;
        double[] Tsuma = new double[gIterations];
        Console.WriteLine("\n");
        Console.WriteLine("Tablica ze stałymi wartościami");
        Console.WriteLine("Średni czas wykonania dla: ");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            SelectionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        double avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Selection Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            InsertionSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Insertion Sort: " + avg + " [s]");

        for (int i = 0; i < gIterations; i++)
        {
            long StartingTime = Stopwatch.GetTimestamp();
            BubbleSort(arr);
            long EndingTime = Stopwatch.GetTimestamp();
            long ElapsedTime = EndingTime - StartingTime;
            Tsuma[i] = ElapsedTime * (1.0 / Stopwatch.Frequency);
        }
        avg = Tsuma.Sum() / gIterations;
        Console.WriteLine("Bubble Sort: " + avg + " [s]");
    }
    
        const int gIterations = 10;    
}

