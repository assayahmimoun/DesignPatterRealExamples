namespace FluentInterfaceDesignPatternSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var query = new QueryBuilder()
                .Select("Name, Age")
                .From("Users")
                .Where("Age > 21")
                .Build();
            Console.WriteLine(query);  // Outputs: SELECT Name, Age FROM Users WHERE Age > 21
            Console.ReadKey();
        }
    }
}