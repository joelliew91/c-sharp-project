using System;

class Program{
    private string name;
    private int[] arr;
    private Random r = new Random(10);
    
    public void init(){
        name = "this is for control-flow";
        arr = new int[10];
        for(int i=0;i<arr.Length;i++){
            arr[i] = r.Next(0,10);
        }
    }
    public void print(){
        Console.WriteLine(name);
        foreach(int myarr in arr){
            if(myarr>8)
                Console.WriteLine("this is greater than 8");
            else
            {
                Console.WriteLine("this is lesser than 8");
            }
            switch(myarr){
                case 9:
                    Console.WriteLine("This is equals 9");
                    break;
                //case >5:
                //    Console.WriteLine("This is greater than 5");
                //    break;
                case 5:
                    Console.WriteLine("This is equals 5");
                    break;
                default:
                    Console.WriteLine("This is not 5 or 9");
                    break;
            }
        }
        
       
    }
}

class Demo{
    static void Main(string[] args){
        Program p = new Program();
        p.init();
        p.print();
    }
}