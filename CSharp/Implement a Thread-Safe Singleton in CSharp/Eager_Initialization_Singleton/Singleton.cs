using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eager_Initialization_Singleton
{
    // 'sealed' prevent it from being inherited.
    // If the Singleton class were not sealed, it could be subclassed
    public sealed class Singleton
    {
        // The Singleton instance is created when the class is loaded.
        private static readonly Singleton instance = new Singleton();

        // Private constructor to prevent instantiation from outside.
        private Singleton()
        {
            // Initialize any resources here if needed.
        }

        // Public method to provide global access to the instance.
        public static Singleton GetInstance()
        {
            return instance;
        }
    }

}
