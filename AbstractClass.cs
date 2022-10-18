public class AbstractClass
{
    public AbstractClass(string[] args)
    {
        Dog dog = new Dog();
        Console.WriteLine("\nPlease enter a dog name");
        dog.SetName(Console.ReadLine());
        Console.WriteLine("\n==== Output =====");
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
 
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
 
    public abstract class Animal
    {
        private string Name;
 
        public void SetName(string name)
        {
            Name = name;
        }
 
        public string GetName()
        {
            return Name;
        }
 
        public abstract void Eat();
    }
}