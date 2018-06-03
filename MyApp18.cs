using System;

class User {
    // staticはインスタンス化しなくて使えるため、カウントしたり蓄積するのに使える。
    private static int count = 0;
    public User() {
        User.count++;
    }
    public static void GetCount() {
        Console.WriteLine($"# of instances: {count}");
    }

}

class MyApp {
    static void Main() {
        User.GetCount();
        User user1 = new User();
        User user2 = new User();
        User user3 = new User();
        User.GetCount();
    }
}
