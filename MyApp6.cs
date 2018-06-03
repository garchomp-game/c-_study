using System;

class MyApp {

    static void Main() {
        var i = 100;

        while (i < 10) {
            Console.WriteLine($"loop:{i}");
            i++;
        }

        do {
            Console.WriteLine($"loop2:{i}");
            i++;
        } while (i < 10);
    }
}
