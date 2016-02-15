namespace VariablePrinter
{
    public class Printer
    {
        public static void Main()
        {
            var printer = new BooleanVariablePrinter();
            printer.Print(true);
        }
    }
}
