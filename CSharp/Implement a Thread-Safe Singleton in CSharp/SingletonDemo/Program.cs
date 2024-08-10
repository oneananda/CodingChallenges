namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSingleton();
            TestSingleton();
            // Calling mutiple times resulting the same hash code is being displayed

            // Going for parallel invoke

            Parallel.Invoke(
                ()=>TestSingleton(),
                ()=>TestSingleton(),
                ()=>TestSingleton());

            Console.ReadLine();
        }

        private static void TestSingleton()
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.GetHashCode());
        }
    }
}
