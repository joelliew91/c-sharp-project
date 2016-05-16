using System;

namespace ref_prog{
    class Program{
        private string name = "This is me before";
        public void changeVal(ref string arg){
            arg = "This is me now";
        }
        public void printstr(){
            Console.WriteLine(name);
        }
    }
    
    class Demo{
        static void Main(string[] args){
            Program p = new Program();
            p.printstr();
            string k = "This is me before";
            Console.WriteLine(k);
            p.changeVal(ref k);
            Console.WriteLine(k);
        }
    }
}