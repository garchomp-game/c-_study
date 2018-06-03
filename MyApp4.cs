using System;

class MyApp {

    static void Main() {
        var score = int.Parse(Console.ReadLine());
        // if (score > 80) {
        //     Console.WriteLine("gread!");
        // } else if(score > 60){
        //     Console.WriteLine("good!");
        // } else {
        //     Console.WriteLine("so so...");
        // }

        Console.WriteLine((score > 80) ? "great" : "so so...");
    }
}
