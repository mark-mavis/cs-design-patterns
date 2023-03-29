﻿namespace NonThreadSafe_Singleton
{   // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.

    // EN : The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed class SingletonClass
    {
        private static int InstanceCount = 0;
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private SingletonClass() { InstanceCount++; }

        // The Singleton's instance is stored in a static field. There there are
        // multiple ways to initialize this field, all of them have various pros
        // and cons. In this example we'll show the simplest of these ways,
        // which, however, doesn't work really well in multithreaded program.
        private static SingletonClass? _instance = null;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                //If you are creating an app with multithreading support, you 
                //should place a thread lock hear

                return _instance = new SingletonClass();
            }
            return _instance;
        }

        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public void SomeBussinessLogic() { Console.WriteLine($"Instance Number: {InstanceCount}"); }
    }
}