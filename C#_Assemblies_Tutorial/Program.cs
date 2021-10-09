namespace Assemblies_Tutorial
{

    /*
     * 
      Assemblies
    - There are two types of assemblies in .net
      1. Executables(can be executed, they consume/have dll, they run in a separate memory space which means we can 
    run multiple instances of an exe file of a project at the same time but we  cannot run a dll directly because 
    dll requires a host/consumer/executable that uses a dll.We only build dll files to check if there are any errors 
    in the code or not)

      2. DLL(Dynamic Linked Libraries, cannot be executed they are only build for error checking, they are used in 
    other executable assemblies as references)
     // dll files contain intermediate language code, in case of .net this intermediate language is msil 
    (msft intermediate language). Due to this common msil .net framework is becomes a windows cross platform 
    tool that supports more than 60 language and can run application on multiple windows versions.

    How to create a dll assembly?
    - right click on existing project solution
    - go to add
    - new proj
    - select class library
    - ok


    how to use an assembly in other sub_projects/assemblies?
    - go to references of the sub_project/assembly
    - go to projects and add the dependent sub_project/assembly
    - add a using <assembly_name> directive at the top of the file in which the instances of class of other assemblies
      will be created.

    Note: if one assembly X is added as reference in assembly Y or in some executable project, then it is not possible to add assembly Y or any project in the X assembly.i.e cyclic dependencies or cyclic references are not allowed.

    "class libraries are not executables they can only be build to check errors but they are not executed like executable assemblies / executable projects"


     */
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
