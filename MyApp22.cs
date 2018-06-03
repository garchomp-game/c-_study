// using System;
using DotinstallNamespace;
// 名前空間
namespace DotinstallNamespace {
  class User {
    public void SayHi() {
      // Console.WriteLine("hi!");
      System.Console.WriteLine("hi!");
    }
  }
}
class MyApp {

  static void Main() {
    // DotinstallNamespace.User user = new DotinstallNamespace.User();
    User user = new User();
    user.SayHi();
  }
}
