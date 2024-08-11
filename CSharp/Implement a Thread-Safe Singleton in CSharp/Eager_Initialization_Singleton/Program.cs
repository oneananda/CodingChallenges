namespace Eager_Initialization_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            // Both should have the same hash code since they refer to the same instance.
            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            Console.ReadLine();
        }
    }
}
