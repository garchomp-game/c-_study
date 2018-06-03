using System;

class MyApp {
    static void SayHi(string name, int age = 23)
    {
        Console.WriteLine($"hi! {name} ({age})");
    }
    static void Main() {
        SayHi("garchomp", 20);
        SayHi("hoge");
        SayHi(age: 26, name: "hogehoge");
    }
}
