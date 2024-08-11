# Eager Initialization Singleton in C#

This repository demonstrates the implementation of a Singleton design pattern using **Eager Initialization** in C#. Eager initialization ensures that a single instance of the class is created when the class is loaded, making it inherently thread-safe without the need for explicit locking.

## Overview

The Singleton pattern restricts the instantiation of a class to a single instance and provides a global point of access to that instance. Eager initialization is a simple and efficient way to achieve this in C#.

### Features

- **Thread-Safe**: The Singleton instance is created at the time of class loading, ensuring thread safety without the need for locks.
- **Simple Implementation**: The pattern is implemented using a `private static readonly` field.
- **Easy to Use**: Provides a global access point to the Singleton instance through a `GetInstance()` method.

### Explanation

Static Instance Initialization: The Singleton instance is created as a static field when the class is loaded. The static readonly keyword ensures that the instance is initialized only once and cannot be modified afterward.

Private Constructor: The constructor is private to prevent other classes from creating new instances of the Singleton.

Global Access: The GetInstance() method provides a global access point to the Singleton instance.