using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     differences:
       1:interface cant have implementation its contain only decleration ,means can not have concrete methods
       1:abstract class cant have implementation for abstract function only , but unlike interface it can have concrete methods means simple function with impelementation

       2:abstract class can inherit from interface
       2:interface can not inherit from abstract class or other class it can only inherit from interface
       
       3:interface does not allow any access modifier and its all member by default is public
       3:abstract class allow access modifier and its all members by default is private as it is class
       
       4:interface can not have fields means variable;
       4:abstract can have fields as it have implemmentations
       
      5:A class can inherit from multiple interfaces at the time 
      5:In C#, a class can inherit from at most one class, 
         whether it's an abstract class or a regular (concrete) class.
         This is known as single inheritance. You cannot inherit from multiple classes simultaneously in C#. 
         This is a fundamental constraint of the language's type system. 
     */
      //extra::Static Class- Its a class which can contain only static member in it and we can't create the object of static class,
      //bcoz it doesn't have any instance member in it
namespace InterfaceVsAbstract
{
    abstract class user {
        public void fun()
        {
            Console.WriteLine("this is the first class method");
            Console.ReadLine();
        }
    }

    abstract class user1:user,Iuser{
        string name = "naveed";
        //concrete function
         public void print()
        {
            Console.WriteLine(this.name);
        }
        //abstract function
        abstract public void user(); 
         public void display()
        {
            Console.WriteLine("this is interface implementation in abstract class");
            Console.ReadLine();
        }
    }
    interface Iuser //:user error its not interface
    {
        //int id;
        void display();
    }


    internal class Program:user1
    {

       override public void user()
        {
            Console.WriteLine("this is the implementation for abract function of abstract class");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program prog=new Program();
            prog.fun();
            prog.user();
            prog.display();
      
         

        }
    }
}
