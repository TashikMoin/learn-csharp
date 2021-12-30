using System;

namespace ExtensionMethods
{

    /* 
     * If we extend methods directly by writing them in the original classes then we will have
     * to test the entire class again just because of the inclusion of the new method which
     * adds additional cost for the testing team and it is risky because it may cause bugs in
     * stable code.
     * 
     * Solutions,
     * 1. Inheritance
     * 2. Extension Methods
     * 
     * We can extend methods in an existing class using inheritance but the issues with
     * the inheritance approach are,
     * 1. Only classes are inherited, Structures cannot be inherited.
     * 2. Sealed classes cannot be inherited.
     * 3. The parent class object will not have access to call the extended methods.
     * 
     * We can also extend methods using Extension methods, It removes all the issues of the
     * inheritance approach of extending methods. It does not adds any additional testing cost
     * as the new extended methods are decoupled from the base class, methods can be extended in
     * sealed class and the parent class objects will have access to all the extended + existing 
     * methods.
     * 
     * Steps to create an extension method,
     * 1. create a static class.
     * 2. define your extension method in it but remember the extension method must be a static 
     * function and must have,
     * firt parameter ---> this <class in which method will be extended> obj
     * 
     * This first parameter is only for binding this newly created extension method with the
     * class specified after this keyword. Also, in order to add parameters to the functions, we
     * can add other parameters after adding ',' but this first parameter is for binding purpose
     * we do not have to pass it to the method at the time of calling.
     * 
     * Note: Extension methods are defined as "static" but are converted to "non-static" methods
     * after binding with the class.
     * 
     * Also, we can use the first binded parameter to have access of the existing value of the
     * caller object.
     
     * If your extension method has same name as existing method of a class then extension method will not be called. The priority will be given to the base method.
     * 
    */
    class X
    {

        public void ExistingMethod()
        {
            Console.WriteLine("Existing Method");
        }
    }

    static class ExtenderClass
    {
        public static void HelloWorld(this X Obj)
        {
            Console.WriteLine("HelloWorld!");
        }

        public static void PrintNaturalNumbers(this Int32 Number)
        {
            Console.WriteLine("\nNatural Numbers,");
            for (int i = 1; i <= Number; ++i)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public static void Greet(this string Obj)
        {
            Console.WriteLine("\nHello, " + Obj);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Extending a function in a user defined class
            X Obj = new X();
            Obj.HelloWorld();

            // Extending a function in a sealed class
            string Name = "Tashik";
            Name.Greet();

            // Extending a function in predefined structure
            Int32 Number = 10;
            Number.PrintNaturalNumbers();

        }
    }
}
