using System;

// class MyInteger {
//     public void GetThree(int x) {
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//     }
// }

// generic

class MyData<T> {
    public void GetThree(T x) {
        Console.WriteLine(x);
        Console.WriteLine(x);
        Console.WriteLine(x);
    }
}

class MyApp {
    static void Main() {
        MyData<string> s = new MyData<string>();
        s.GetThree("hello");
        MyData<double> d = new MyData<double>();
        d.GetThree(23.35);
    }
}
