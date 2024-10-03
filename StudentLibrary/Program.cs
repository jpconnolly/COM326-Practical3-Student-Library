using StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Jane Doe", 18);

        student1.Display();
        student2.Display();

        // Implement GetOlder
        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("Implementing student older");
        student1.Display();
        student2.Display();
    }

}
