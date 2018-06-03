using System;

class MyApp {

    static void Main() {
        var scores = new [] {10, 30, 20};

        // for (int i = 0; i < scores.Length; i++) {
        //     Console.WriteLine(scores[i]);
        // }

        foreach(int score in scores) {
            Console.WriteLine(score);
        }
    }
}
