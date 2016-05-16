using System;

class Program1{
    private double val;
    
    public double myval{
        get{return val;}
        set{val = value;}
    }
    public override string ToString(){
        return "This is worth " + myval;
    }
    public static void Main(string[] args){
        Program1 p = new Program1();
        
        p.myval = 7.7;
        Console.WriteLine(p);
    }
}
