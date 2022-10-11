using System;
using System.Collections;
 
public class Task8_ArrayListObjects
{
    public Task8_ArrayListObjects(string[] args)
    {
        ArrayList list = new ArrayList();
 
        int total = 3;
        for (int i = 0; i < total; i++)
        {
            Console.Write("Name[" + (i + 1) + "]: ");
            string name = Console.ReadLine();
            Console.Write("Age[" + (i + 1) + "]: ");
            int age = int.Parse(Console.ReadLine());
 
            list.Add(new Person() {
                Name = name,
                Age = age
            });
        }

        Console.WriteLine("===== Output =====");
        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }
    }
 
    public class Person
    {
        public string Name;
        public int Age;
 
 
        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}