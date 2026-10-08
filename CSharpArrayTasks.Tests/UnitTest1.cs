using CSharpArrayTasks;
using Xunit;

namespace CSharpArrayTasks.Tests;

public class AlgorithmTests
{
    // --- Part 1 Tests: Search Algorithms ---

    [Fact]
    public void LinearSearch_KeyExists_ReturnsCorrectIndex()
    {
        int[] arr = { 3, 1, 7, 4, 9 };
        int key = 7;
        int expected = 2;

        int actual = SearchAlgorithms.LinearSearch(arr, key);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LinearSearch_KeyDoesNotExist_ReturnsMinusOne()
    {
        int[] arr = { 3, 1, 7, 4, 9 };
        int key = 5;
        int expected = -1;

        int actual = SearchAlgorithms.LinearSearch(arr, key);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BinarySearch_KeyExists_ReturnsCorrectIndex()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11 };
        int key = 7;
        int expected = 3;

        int actual = SearchAlgorithms.BinarySearch(arr, key);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BinarySearch_KeyDoesNotExist_ReturnsMinusOne()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11 };
        int key = 4;
        int expected = -1;

        int actual = SearchAlgorithms.BinarySearch(arr, key);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountOccurrences_KeyOccursMultipleTimes_ReturnsCount()
    {
        int[] arr = { 2, 5, 2, 8, 2, 1, 2 };
        int key = 2;
        int expected = 4;

        int actual = SearchAlgorithms.CountOccurrences(arr, key);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountOccurrences_KeyDoesNotExist_ReturnsZero()
    {
        int[] arr = { 2, 5, 2, 8, 2, 1, 2 };
        int key = 9;
        int expected = 0;

        int actual = SearchAlgorithms.CountOccurrences(arr, key);

        Assert.Equal(expected, actual);
    }

    // --- Part 2 Tests: Sorting Algorithms ---

    [Fact]
    public void BubbleSort_Ascending_SortsArrayCorrectly()
    {
        int[] arr = { 4, 1, 7, 2, 5 };
        int[] expected = { 1, 2, 4, 5, 7 };

        SortAlgorithms.BubbleSort(arr);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void BubbleSortDescending_SortsArrayCorrectly()
    {
        int[] arr = { 4, 1, 7, 2, 5 };
        int[] expected = { 7, 5, 4, 2, 1 };

        SortAlgorithms.BubbleSortDescending(arr);

        Assert.Equal(expected, arr);
    }

    [Fact]
    public void BubbleSort_MinAndMax_IdentifiedCorrectly()
    {
        int[] arr = { 9, 3, 6, 1 };

        SortAlgorithms.BubbleSort(arr);

        Assert.Equal(1, arr[0]); // Min
        Assert.Equal(9, arr[arr.Length - 1]); // Max
        Assert.Equal(new int[] { 1, 3, 6, 9 }, arr);
    }
}
