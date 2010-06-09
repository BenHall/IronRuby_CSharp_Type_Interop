using System;

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

    public class Manager
    {
        public double Salary { get { return 100000.00; } }
    }

    public class Assistant
    {
        public double Salary { get { return 10000.00; } }
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
    }
}
