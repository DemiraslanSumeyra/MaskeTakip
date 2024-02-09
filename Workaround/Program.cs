using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person person1 = new Person();
        person1.FirstName = "Sümeyra";

        Person person2 = new Person();
        person2.FirstName = "İlker";
    }
}