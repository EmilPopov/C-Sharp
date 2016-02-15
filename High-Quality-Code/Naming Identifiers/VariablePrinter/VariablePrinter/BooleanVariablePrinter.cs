namespace VariablePrinter
{
    using System;

    public class BooleanVariablePrinter
    {
        public void Print(bool value)
        {
            string valueAsString = value.ToString();
            Console.WriteLine(valueAsString);
        }
    }
}
