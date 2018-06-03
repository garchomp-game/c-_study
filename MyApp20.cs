using System;

interface ISharable {
    void Share();
}

class User :ISharable{
    public void Share() {
        Console.WriteLine("now sharing...");
    }
}

class MyApp {
    static void Main() {
        User user = new User();
        user.Share();
    }
}
