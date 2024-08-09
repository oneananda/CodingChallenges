# Implement a Thread-Safe Singleton in C#

## Implement a thread-safe Singleton class in C#. A Singleton class ensures that only one instance of the class is created and provides a global point of access to that instance. The challenge is to implement this pattern correctly in a multi-threaded environment, ensuring that only one instance is created even if multiple threads attempt to instantiate the Singleton simultaneously.


## Requirements:

Implement a Singleton class named Singleton.
Ensure that the Singleton is thread-safe.
Implement a method GetInstance() that returns the single instance of the class.
Prevent the Singleton instance from being created more than once.
Implement a simple test to ensure the Singleton pattern works as expected.