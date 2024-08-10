using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private static readonly object lockObj = new object();

        // Private constructor to prevent instantiation from outside.
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    // Lazy Initialization: The Singleton instance is created only when
                    // it is needed for the first time, not at the time of class loading.
                    // This is achieved by checking if instance is null before creating it.
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
