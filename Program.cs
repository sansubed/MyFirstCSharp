﻿namespace CSharpLearning
{
    class Program
    {
        int a;
        int b;
        public Program()
        {

        }
        public Program(int a1)
        {

            a = a1;


        }

        public Program(int a1, int b1)
        {
            a = a1;
            b = b1;
        }
        public void PrintMessage()
        {
            Console.WriteLine("Hello, Santona!");
        }

        

        public bool PrintMessage(int a, int b)
        {
            if (a == b && a > b)
            {
                return true;
            }
            else return false;
        }

        //ProgramTest inherits class Program -> child class
        class ProgramTest : Program
        {
            
            
            public int PrintMessage(int a)
            {
                return (a);
            }
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program(1,2);
            Console.WriteLine("I am from class Program and I am object2 a "+obj2.a);

            //this can only use the properties of the child class 
            ProgramTest obj3 = new ProgramTest();
            Console.WriteLine("I am from class ProjectTest, obj3 "+obj3.PrintMessage(1));
            
            obj1.PrintMessage();
            //Console.WriteLine(obj2.PrintMessage(1));
            Console.WriteLine("I am from class Program: "+obj2.PrintMessage(3,1));

           //instantiated an object of the child class and assigned it to a refernce of base class.
            Program obj4 = new ProgramTest();
            obj4.PrintMessage();
            //using the method of the parent class 
            Console.WriteLine("I am object 4 which is object of child class but assigned to parent class "+obj4.PrintMessage(1,2));
            
        }

        
    }
}
