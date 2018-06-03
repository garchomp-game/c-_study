using System;

abstract class User {
    public abstract void SayHi();
}

class Japanese: User {
    public override void SayHi() {
        Console.WriteLine("こんにちは");
    }
}

class American: User {
    public override void SayHi() {
        Console.WriteLine("hello");
    }
}

class MyApp {
    static void Main() {
        Japanese aki = new Japanese();
        aki.SayHi();
        American tom = new American();
        tom.SayHi();
    }
}
