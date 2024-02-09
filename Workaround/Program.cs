using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person person1 = new Person();
        person1.FirstName = "SÜMEYRA";
        person1.LastName = "DEMİRASLAN";
        person1.DateOfBirthYear = 1994;
        person1.NationalIdentity = 123;

        Person person2 = new Person();
        person2.FirstName = "İlker";

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


        Console.ReadLine();

    }




}