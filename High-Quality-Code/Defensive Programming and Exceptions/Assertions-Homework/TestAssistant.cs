namespace Assertions
{
    using System;
    using System.Linq;

    internal static class TestAssistant
    {
        internal static bool IsSorted<T>(T[] arr) where T : IComparable<T>
        {
            bool isSorted = true;

            int length = arr.Length;
            if (length == 1)
            {
                return isSorted;
            }

            for (int i = 1; i < length; i++)
            {
                if (arr[i - 1].CompareTo(arr[i]) == 1)
                {
                    isSorted = false;
                    return false;
                }
            }

            return isSorted;
        }

        internal static T GetMinValue<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
        {
            T minValue = arr.Skip(startIndex).Take(endIndex - startIndex + 1).Min();

            return minValue;
        }
    }
}
