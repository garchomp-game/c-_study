using System;

class User {
    public string name;
    public User(string name) {
        this.name = name;
    }

    public User(): this("nobody") {
    }

    public void SayHi()
    {
        Console.WriteLine($"hi! {this.name}");
    }
}

class MyApp {
    static void Main() {
        User user = new User("garchomp");
        User hoge = new User();
        Console.WriteLine(user.name);
        user.SayHi();
        Console.WriteLine(hoge.name);
        hoge.SayHi();
    }
}
