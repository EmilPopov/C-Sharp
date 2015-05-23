
namespace WarMachines.Models
{
    using System;
    public static class Validator
    {
        public static void StringNullOrEmpty(string value,string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }
       
        public static void NullObject(object value ,string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
