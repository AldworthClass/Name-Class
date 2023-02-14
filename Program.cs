namespace Name_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name teacher;
            teacher = new Name("Steve", "Aldworth");
            Console.WriteLine(teacher.FirstName);
            teacher.FirstName = "Steven";
            Console.WriteLine(teacher);

        }
    }
}