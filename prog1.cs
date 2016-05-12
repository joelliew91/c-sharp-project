using System;

namespace Test{
    
    class Prog{
        public static void Main(string [] args){
            Console.WriteLine("This is a Test");
            Test.innertest.Prog2 newvar = new Test.innertest.Prog2();
            newvar.sayhello();
        }
    }
    
    namespace innertest
    {
        public class Prog2{
            public void sayhello(){
                Console.WriteLine("This is from nested class"); 
            }
        }
    }
}