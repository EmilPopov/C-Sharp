
namespace GenericLists.TestGenericList
{
    using GenericLists;
    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(8);
            list.Add(15);
            list.Add(30);
            list.Add(45);
            list.Remove(2);
        }
    }
}
