using First_Assembly;
using System;

namespace Second_Assembly
{
    public class Second_Assembly_Class
    {
        // Successfull Build 

        /* 
         * Everything defined inside a namespace can only have 2 access modifiers (public or internal) writing private,
         * protected and protected internal etc with the classes or other types inside a namespace will give an error.
         * However, for class member attribute and member functions, we can use all the c# access specifiers.
         * 
         * Defining a class as internal means it is only accessible inside that project/assembly.
         * Defining a class as public means it is accessible for everyone (in other projects, assemblies also).         
         * By Default access modifier of Class is 'Internal' and 'Private' for Data Members and  Member Functions 
         * of a Class.
        */

        public void Test()
        {
            First_Assembly_Class Obj = new First_Assembly_Class();
            Console.WriteLine(Obj.public_attribute);
            /* only public variable is accessible because it is the "scope of second_assembly_project", here we are 
             * trying to access the variables in a "class of a different sub project or assembly".
             * 
             * internal ---> only accessibly inside the files, classes, namespaces etc of the same project or assembly
             * protected internal ---> if the classes inside "X project or X assembly" inherits a class that exist 
             *                         in a Y assembly or Y project having a protected internal variable, then the 
             *                         protected internal attribute is accessible in classes of X assembly or X
             *                         project.
             * protected ---> attributes are accessible in child classes of all the assemblies or projects
             * private protected ---> attributes are accessible in the origin assembly or origin project.
             *                        attributes are not accessible in child classes made in other assemblies 
             *                        or projects.
             * public ---> public to everyone  (all the assemblies/project 's classes, namespaces etc)
             * private ---> only accessible inside the scope of the class of the origin assembly
             */
        }
    }


    public class Test_Assembly_Class : First_Assembly_Class
    {
        public void Test()
        {
            this.protected_internal_attribute = 10;
            /* Allowed because this class is inheriting a class of another assembly having a protected internal attribute. If
             * it was a private protected variable, then it is not allowed */

            // this.private_protected_attribute = 15; /* gives error not allowed */
        }
    }
}
