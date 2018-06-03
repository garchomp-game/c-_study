using System;

class User {
    private string name = "me!";

    public string Name {
        get { return this.name;}// getter
        set {
            if (value != "") {
                // setter getter内で分岐することも可能。
                this.name = value;
            }
        }// setter
    }
    // public string Name {get; set;} = "me!";
}


class MyApp {
    static void Main() {
        User user = new User();
        Console.WriteLine(user.Name);
        user.Name = "garchomp_otoka";
        Console.WriteLine(user.Name);
        user.Name = "";
        Console.WriteLine(user.Name);
    }
}
