using System;

class MyApp {
    static void Main() {
        var x = 10;
        Console.WriteLine(x / 3);
        Console.WriteLine(x / (double)3);

        var y = 5;
        y++;
        Console.WriteLine(y);
        y--;
        Console.WriteLine(y);

        var z = 6;
        z += 10;
        Console.WriteLine(z);

        var flag = true;
        Console.WriteLine(!flag);
    }
}
