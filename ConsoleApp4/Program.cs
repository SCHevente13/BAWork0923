namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Model model = new Model();
            foreach(KeyValuePair<string,int> i in model.PublisherCount())
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
            Console.WriteLine("---");
            foreach (KeyValuePair<string, int> i in model.GenreCount())
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
        }
    }
}
