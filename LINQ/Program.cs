namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           var tvShowsList = new List<string>() { "Suits","Jack Ryan", "Elementary","Ozark", "The Blacklist"};

            //var tvShowsListOrdered = tvShowsList.OrderBy(name => name.Length).ToList();

            //foreach (var tvShow in tvShowsListOrdered) 
            //{ 
            //    Console.WriteLine(tvShow);
            //}

           // tvShowsListOrdered.ForEach(Console.WriteLine);

            tvShowsList.OrderBy(name => name.Length).ToList().ForEach(Console.WriteLine);
        }
    }
}
