using System;

namespace L2{
    
    class A: object {
        public virtual void sayHello(){
            Console.WriteLine("This is from Class A");
        }
    }
    
    class B: A {
        public override void sayHello(){
            
            Console.WriteLine("This is from Class B");
        }
        public static void identity(){
            Console.WriteLine("What is this B");
        }
    }
    
    class Main_tester {
        static void Main(string [] args){
            A varA = new A();
            B varB = new B();
            varA.sayHello();
            varB.sayHello();
            varA = new B();
            varA.sayHello();
            B.identity();
            
        }
    }
    
    
}