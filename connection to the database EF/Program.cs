namespace connection_to_the_database_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user =new User();
            user.name = "aprar";

            Console.WriteLine(user.name);
        }
    }
}
