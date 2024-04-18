### The following are the guidelines to implement the Singleton Design Pattern in C#.

1. We need to declare a constructor that should be **private and parameterless**. This is required because it will restrict the class from being instantiated from outside the class. It only instantiates from within the class.
2. The class should be declared **sealed**, ensuring it cannot be inherited. This is going to be useful when you are dealing with the nested class.
3. We must create a **private static variable** referencing the class’s singleton instance.
4. We also need to create a **public static property/method** that will return the singleton instance of the class. This method or property first checks whether an instance of the singleton class is created. If the singleton instance is created, it returns that instance; otherwise, it will create an instance and then return it.
