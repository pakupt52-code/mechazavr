namespace CSharpArrayTasks;

public static class SearchAlgorithms
{
    // Part 1, Task 1 & Task 2: Linear search algorithm returning index or -1 if not found.
    public static int LinearSearch(int[] a, int key)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == key)
            {
                return i; // Return index of key when found
            }
        }
        return -1; // Return -1 if key is not found
    }

    // Part 1, Task 3: Binary search on a sorted array returning index or -1 if not found.
    public static int BinarySearch(int[] a, int key)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (a[mid] == key)
            {
                return mid; // Key found at mid
            }

            if (a[mid] < key)
            {
                left = mid + 1; // Search in right half
            }
            else
            {
                right = mid - 1; // Search in left half
            }
        }

        return -1; // Key not found
    }

    // Part 1, Task 4: Count occurrences of key in array
    public static int CountOccurrences(int[] a, int key)
    {
        int count = 0;
        foreach (int item in a)
        {
            if (item == key)
            {
                count++; // Increment count when item matches key
            }
        }
        return count;
    }
}

public static class SortAlgorithms
{
    // Part 2, Task 1 & Task 4: Bubble sort in ascending order
    public static void BubbleSort(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Compare adjacent elements
                if (a[j] > a[j + 1])
                {
                    // Swap elements using temp variable
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    // Part 2, Task 2: Bubble sort in descending order
    public static void BubbleSortDescending(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Compare adjacent elements for descending order
                if (a[j] < a[j + 1])
                {
                    // Swap elements using temp variable
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CSharp Array Tasks Executable.");
    }
}
