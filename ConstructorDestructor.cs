
 
public class ConstructorDestructor
{
    public ConstructorDestructor(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];

        Console.WriteLine("Please enter persons name");
        for (int i = 0; i < total; i++)
        {
            Console.Write($"Person[{i + 1}]: ");
            persons[i] = new Person(Console.ReadLine());
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }

     public class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }
 
        ~Person()
        {
            Name = string.Empty;
        }
    }

}