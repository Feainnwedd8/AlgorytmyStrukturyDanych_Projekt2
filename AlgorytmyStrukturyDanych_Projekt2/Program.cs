/*
 POMYSŁY

rozbić to np na robienie liczenie czasu i wykonan od razu w funkcji sortowania, jednak zrobić 
osobne tablice dla kazdego typu (rosnoca, malejace, V itd)
wywolywać funkcje, ktora od razu zrobi te 10 pomiarów, policzy srednie i wypisze ilosc wykonan

NIECH TO BEDA FUNKCJE KORZYSTAJACE Z OSOBNO ZROBIONYCH FUNKCJI SORTUJACYCH
TZN FUNKCJA KTORA PO 10 RAZY WYWOLUJE SORT_XXXX, LICZY ITD

MOZE TO Z JEDNEJ TABLICY WARTOSCI ZROBIC TE KILKA RODZAJOW? 
  
  
  */


using System;

class Program
{
    static void Main(string[] args)
    {
        for (int n = 100000; n == 1000000; n += 100000)
        {

            Random rn = new Random();
            int[] arr = new int[n];

            
        }
        

    }

    static void SelectionSort(int[] arr)
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

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }
}