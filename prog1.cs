using System;

namespace Test{
    class Jay{
        static void Main(string [] args){
        Console.WriteLine("This is a Test");
        Test.innertest.Prog2 newvar = new Test.innertest.Prog2();
        newvar.sayhello();
        Test.innertest.Prog2 newvar2 = new Test.innertest.Prog2();
        newvar2.sayhello();

    }

    }

    
    namespace innertest
    {
       class Prog2 {
            public void sayhello(){
                Console.WriteLine("This is from nested class"); 
            }
            // override object.Equals
        }
        
    }
}

