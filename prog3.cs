using System;

namespace out_prog{
    class Program{
        
        static void sayHello(){
            System.Console.WriteLine("Hello, this is the program!");
        }
        
        static void Out_Method(out string arg){
            arg = "This is the Out_Method";
        
        }
    
        static void Main(string[] args){
            Program p = new Program();
            string test;
            Program.sayHello();
            Out_Method(out test);
            //p.Out_Method(test);
            //test = " This is the in method";
            Console.WriteLine(test);
            }   
    }

}
