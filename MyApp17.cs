using System;

class Team {
    // このような配列管理専用のクラスをインデクサという。
    // インデクサは、アクセサ　型[] 変数名　＝　new 型[数]; となる
    private string[] members = new string[3];
    // publicでは、添字がついた形で呼び出すので、thisを使って、添字は数値を使うためのi
    // 添字付きでの呼び出しの場合はthis[型 i] コンストラクタはClass()
    public string this[int i] {
        get { return this.members[i];}
        set { this.members[i] = value;}
    }
}

class MyApp {
    static void Main() {
        Team giants = new Team();
        giants[0] = "garchomp";
        giants[1] = "hoge";
        giants[2] = "hogera";
        Console.WriteLine(giants[0]);
    }
}
