using System;

namespace L2{
    
    class A: object {
        public void sayHello(){
            Console.WriteLine("This is from Class A");
        }
    }
    
    class B: A {
        public void sayHello(){
            
            Console.WriteLine("This is from Class B");
        }
    }
    
    class Main_tester {
        static void Main(string [] args){
            A varA = new A();
            B varB = new B();
            varA.sayHello();
            varB.sayHello();
            
        }
    }
    
    
}