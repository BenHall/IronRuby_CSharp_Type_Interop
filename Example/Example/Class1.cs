using System;
using System.Reflection;

namespace Example
{
    public abstract class Employee
    {
        protected abstract double Salary { get; }

        public override string ToString()
        {
            return string.Format("Salary: {0}", Salary);
        }
    }

    public class Manager : Employee
    {
        protected override double Salary { get { return 100000.00; } }
    }

    public class Assistant : Employee
    {
        protected override double Salary { get { return 10000.00; } }
    }

    public class PayRoll
    {
        public void Pay(Employee e)
        {
            Console.WriteLine("Paying Employee: {0} from standard account", e);
        }

        public void Pay(Assistant a)
        {
            Console.WriteLine("Paying Assistant: {0} from standard account", a);
        }

        public void Pay(Manager m)
        {
            Console.WriteLine("BONUSES ALL ROUND!!");
            Console.WriteLine("Paying Manager: {0} from special account", m);
        }

        public void Pay(object o)
        {
            Console.WriteLine("Unable to pay {0}", o);
        }

        public Employee GenerateNewEmployee(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            Type t = assembly.GetType(String.Format("{0}.{1}", assemblyName.Name, className));
            return (Employee)Activator.CreateInstance(t);
        }
    }
}
