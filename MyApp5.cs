using System;

class MyApp {

    static void Main() {
        var signal = Console.ReadLine();

        switch(signal) {
            case "red":
            Console.WriteLine("Stop!");
            break;
            case "blue":
            case "green":
            Console.WriteLine("Go1!");
            break;
            case "yellow":
            Console.WriteLine("Caution!");
            break;
            default:
            Console.WriteLine("wrong  signal");
            break;
        }
    }
}
