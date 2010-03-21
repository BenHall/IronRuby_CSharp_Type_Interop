using System;
using System.Reflection;

namespace InteropExample
{
    public interface IAnimal { void Speak();}

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof");
        }

        public void Walk()
        {
            Console.WriteLine("Walkies...");
        }
    }
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    public class AnimalFarm
    {
        public IAnimal GetAnimal(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            Type t = assembly.GetType(String.Format("{0}.{1}", assemblyName.Name, className));
            return (IAnimal)Activator.CreateInstance(t);
        }

        public void Say(IAnimal obj)
        {
            Console.WriteLine("IAnimal Method");
            Console.WriteLine(obj.GetType().Name);
        }

        public void Say(object obj)
        {
            Console.WriteLine("Object Method");
            Console.WriteLine(obj.GetType().Name);
        }

        public void Say(Dog obj)
        {
            Console.WriteLine("Dog Method");
            Console.WriteLine(obj.GetType().Name);
        }
    }
}
