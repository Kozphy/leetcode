
namespace linkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "bee", "applied" };
            myLinkList<string> linkList = new myLinkList<string>("apple");
            foreach(var item in data) { 
                linkList.Append(item);
            }

            linkList.Print();
            Console.WriteLine(linkList.length);
            linkList.Remove("bee");
            linkList.Print();

        }
    }
}