public class Task2
{
    public Task2(string[] args)
    {

        Console.WriteLine("Please enter persons name");
    
        int total = 3;
        Person[] persons = new Person[total];
 
        for (int i = 0; i < total; i++)
        {
            Console.Write("Person[" + (i + 1) + "]: ");
            if (i == 0)
            {
                persons[i] = new Teacher(Console.ReadLine());
            }
            else
            {
                persons[i] = new Student(Console.ReadLine());
            }
        }

        Console.WriteLine("\n==== Output =====");
        for (int i = 0; i < total; i++)
        {
            if (i == 0)
            {
               ((Teacher)persons[i]).Explain();
 
            }
            else
            {
                ((Student)persons[i]).Study();
            }
        }
    }

    public class Person
    {
        public string Name;
 
        public Person(string name)
        {
            Name = name;
        }
 
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }

    public class Student: Person
    {
        public Student(string name): base(name)
        {
           Name = name;
        }
        public void Study(){
            Console.WriteLine($"{Name} is studying");
        }
    }

    public class Teacher: Person
    {
        public Teacher(string name): base(name)
        {
           Name = name;
        }
        public void Explain(){
            Console.WriteLine($"{Name} is explaining");
        }
    }

}