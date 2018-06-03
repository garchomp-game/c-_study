using System;

class User {
    public string name;
    public User(string name) {
        this.name = name;
    }

    public User(): this("nobody") {
    }

    public virtual void SayHi()
    {
        Console.WriteLine($"hi! {this.name}");
    }
}

class AdminUser: User {
    public AdminUser(string name): base(name) {
        // baseでコンストラクタの継承。継承したいメソッドを記述
    }
    public void SayHello() { // オーバーライドするには、元にvirtual、継承先にorverrideをつける
        Console.WriteLine($"hello {name}");
    }

    public override void SayHi() {
        Console.WriteLine($"[admin] hi {name}");
    }
}

class MyApp {
    static void Main() {
        User user = new User("garchomp");
        AdminUser hoge = new AdminUser("hoge");
        Console.WriteLine(user.name);
        user.SayHi();
        Console.WriteLine(hoge.name);
        hoge.SayHi();
        hoge.SayHello();
    }
}
