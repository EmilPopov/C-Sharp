
namespace FurnitureManufacturer.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int min, string message = null)
        {
            if (text.Length < min)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
        public static void CheckIfLessOrEqualToZero(decimal number, string message = null)
        {
            if (number <= 0)
            {
                throw new NullReferenceException(message);
            }
        }
    }
}
